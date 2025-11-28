using D_A_L.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_A_L.Models
{
    public class Category : BaseModel
    {
        public string name { get; set; }
        public List<Product> Products { get; set; } = new List<Product>();
    }
}
