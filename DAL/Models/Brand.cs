using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_A_L.Models
{
    public class Brand : BaseModel
    {
        public string name { get; set; }
        //img
        public string MainImage { get; set; }
        public List<Product> Products { get; set; } = new List<Product>();
    }
}
