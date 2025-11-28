using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_A_L.Models
{
    public class User : IdentityUser
    {
        public string FullName { get; set; }
        public string? City { get; set; }
        public string? Street { get; set; }
        public string? ResetPasswordCode { get; set; }
        public DateTime? ResetPasswordCodeExpiry { get; set; }

    }
}
