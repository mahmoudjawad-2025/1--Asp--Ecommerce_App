using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DTO.Responses
{
    public class CheckOutResponse
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public string? Url { get; set; }
        public string? PaymentId { get; set; }
    }
}
