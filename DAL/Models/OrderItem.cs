using D_A_L.Models;
using DAL.Models.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



// order item
namespace DAL.Models
{
    [PrimaryKey(nameof(OrderId), nameof(ProductId))]
    public class OrderItem
    {
        public int OrderId { get; set; }
        public Order Order { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }

        public decimal TotalPrice { get; set; }

        public int Count { get; set; }
        public decimal Price { get; set; }
    }
}
