using D_A_L.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    [PrimaryKey(nameof(productId), nameof(userId))]
    public class Cart
    {
        public int productId { get; set; }
        public Product product { get; set; }
        public string userId { get; set; }
        public User user { get; set; }
        public int count { get; set; }

    }
}
