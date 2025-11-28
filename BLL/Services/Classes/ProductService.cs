using B_L_L.Services.Interfaces;
using D_A_L.DTO.Requests;
using D_A_L.DTO.Responses;
using D_A_L.Models;
using D_A_L.Repositories.Interfaces;
using DAL.DTO.Responses;
using DAL.Models;
using Mapster;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_L_L.Services.Classes
{
    public class ProductService : GenericService<ProductRequest, ProductResponse, Product>, IProductService
    {
        private readonly IProductRepository _repository;
        private readonly IFileService _fileService;

        public ProductService(IProductRepository repository, IFileService fileService) : base(repository)
        {
            _repository = repository;
            _fileService = fileService;
        }

        public async Task<int> CreateProduct(ProductRequest request)
        {
            var entity = request.Adapt<Product>();
            entity.createAt = DateTime.UtcNow;

            if (request.MainImage != null)
            {
                var imagePath = await _fileService.UploadAsync(request.MainImage);
                entity.MainImage = imagePath;
            }
            if (request.SubImages != null)
            {
                var subImagesPaths = await _fileService.UploadManyAsync(request.SubImages);
                entity.SubImages = subImagesPaths.Select(img => new ProductImage { ImageName = img }).ToList();
            }

            return _repository.Add(entity);
        }

        public async Task<List<ProductResponse>> GetAllProducts(HttpRequest request, int pageNumber = 1, int pageSize = 1, bool onlyActive = false)
        {
            var products = _repository.GetAllProductsWithImage();
            if (onlyActive)
            {
                products = products.Where(p => p.status == Status.active).ToList();
            }

            var pagedProducts = products.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();
            return pagedProducts.Select(p => new ProductResponse
            {
                Name = p.Name,
                Quantity = p.Quantity,
                MainImageUrl = $"{request.Scheme}://{request.Host}/Images/{p.MainImage}",
                SubImagesUrls = p.SubImages.Select(img => $"{request.Scheme}://{request.Host}/Images/{img.ImageName}").ToList(),
                Reviews = p.Reviews.Select(r => new ReviewResponse
                {
                    Id = r.Id,
                    Rate = r.Rate,
                    Comment = r.Comment,
                    FullName = r.User.FullName
                }).ToList()
            }).ToList();
        }
    }
}
