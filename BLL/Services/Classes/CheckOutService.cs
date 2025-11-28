using BLL.Services.Interfaces;
using D_A_L.Repositories.Interfaces;
using DAL.DTO.Requests;
using DAL.DTO.Responses;
using DAL.Models;
using DAL.Models.DAL.Models;
using DAL.Repositories.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Stripe.Checkout;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.Classes
{
    public class CheckOutService : ICheckOutService
    {
        private readonly ICartRepository _cartRepository;
        private readonly IOrderRepository _orderRepository;
        private readonly IEmailSender _emailSender;
        private readonly IOrderItemRepository _orderItemRepository;
        private readonly IProductRepository _productRepository;

        public CheckOutService(ICartRepository cartRepository, IOrderRepository orderRepository, 
            IEmailSender emailSender, IOrderItemRepository orderItemRepository, IProductRepository productRepository)
        {
            _cartRepository = cartRepository;
            _orderRepository = orderRepository;
            _emailSender = emailSender;
            _orderItemRepository = orderItemRepository;
            _productRepository = productRepository;
        }



        public async Task<bool> HandlePaymentSuccessAsync(int orderId)
        {
            var order = await _orderRepository.GetUserByOrderAsync(orderId);

            var subject = "";
            var body = "";

            if (order.PaymentMethod == PaymentMethodEnum.Visa)
            {
                order.Status = OrderStatusEnum.Approved;

                var carts = await _cartRepository.GetUserCartAsync(order.UserId);
                var orderItems = new List<OrderItem>();
                var productUpdated = new List<(int productId, int quantity)>();

                foreach (var cartItem in carts)
                {
                    var orderItem = new OrderItem
                    {
                        OrderId = orderId,
                        ProductId = cartItem.productId,
                        TotalPrice = cartItem.product.Price * cartItem.count,
                        Count = cartItem.count,
                        Price = cartItem.product.Price,
                    };

                    orderItems.Add(orderItem);
                    productUpdated.Add((cartItem.productId, cartItem.count));
                }

                await _orderItemRepository.AddRangeAsync(orderItems);
                await _cartRepository.ClearCartAsync(order.UserId);
                await _productRepository.DecreaseQuantityAsync(productUpdated);

                subject = "Payment Successful - kashop";
                body = $"<h1>thank you for your payment </h1> " +
                       $"<p>your payment for order {orderId}</p> " +
                       $"<p>total Amount : ${order.TotalAmount}</p>";
            }
            else if (order.PaymentMethod == PaymentMethodEnum.Cash)
            {
                subject = "order placed successfully";
                body = $"<h1>thank you for your order </h1> " +
                       $"<p>your payment for order {orderId}</p> " +
                       $"<p>total Amount : ${order.TotalAmount}</p>";
            }

            await _emailSender.SendEmailAsync(order.User.Email, subject, body);

            return true;
        }




        public async Task<CheckOutResponse> ProcessPaymentAsync(CheckOutRequest request, string UserId, HttpRequest Request)
        {
            var cartItems = await _cartRepository.GetUserCartAsync(UserId);

            if (!cartItems.Any())
            {
                return new CheckOutResponse
                {
                    Success = false,
                    Message = "Cart is empty."
                };
            }

            Order order = new Order
            {
                UserId = UserId,
                PaymentMethod = request.PaymentMethod,
                TotalAmount = cartItems.Sum(ci => ci.product.Price * ci.count)
            };
            await _orderRepository.AddOrderAsync(order);

            if (request.PaymentMethod == PaymentMethodEnum.Cash)
            {
                return new CheckOutResponse
                {
                    Success = true,
                    Message = "Cash."
                };
            }

            if (request.PaymentMethod == PaymentMethodEnum.Visa)
            {
                var options = new SessionCreateOptions
                {
                    PaymentMethodTypes = new List<string> { "card" },
                    LineItems = new List<SessionLineItemOptions>(),
                    Mode = "payment",
                    SuccessUrl = $"{Request.Scheme}://{Request.Host}/api/customer/CheckOuts/Success/{order.Id}",
                    CancelUrl = $"{Request.Scheme}://{Request.Host}/checkout/cancel",
                };

                foreach (var item in cartItems)
                {
                    options.LineItems.Add(new SessionLineItemOptions
                    {
                        PriceData = new SessionLineItemPriceDataOptions
                        {
                            Currency = "usd", // Fixed currency or get from cart item
                            ProductData = new SessionLineItemPriceDataProductDataOptions
                            {
                                Name = item.product.Name, // Use cart item product name
                                Description = item.product.Description, // Use cart item product description
                            },
                            UnitAmount = (long)(item.product.Price * 100), // Convert to cents for Stripe
                        },
                        Quantity = item.count, // Use actual quantity from cart item
                    });
                }

                var service = new SessionService();
                var session = service.Create(options);
                order.PaymentId = session.Id;
                return new CheckOutResponse
                {
                    Success = true,
                    Message = "Payment session created successfully.",
                    PaymentId = session.Id,
                    Url = session.Url
                };
            }

            // Handle case where payment method is not recognized
            return new CheckOutResponse
            {
                Success = false,
                Message = "Unsupported payment method."
            };
        }
    }
}
