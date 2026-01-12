using D_A_L.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class ProductImage
    {
        public int Id { get; set; }
        public string ImageName { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
