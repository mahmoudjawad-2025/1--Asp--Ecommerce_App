using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DTO.Requests
{
    public class ReviewRequest
    {
        public int ProductId { get; set; }
        public string? Comment { get; set; }
        public int Rate { get; set; }
    }
}
