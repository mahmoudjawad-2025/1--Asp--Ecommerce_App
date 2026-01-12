using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_A_L.DTO.Requests
{
    public class ResetPasswordRequest
    {
        public string newPassword { get; set; }
        public string email { get; set; }
        public string code { get; set; }
    }
}
