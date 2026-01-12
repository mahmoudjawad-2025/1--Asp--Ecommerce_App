

using D_A_L.Models;
using Microsoft.AspNetCore.Http;

namespace D_A_L.DTO.Requests
{
    public class BrandRequest
    {
        public string name { get; set; }
        //img
        public IFormFile MainImage { get; set; }
    }
}
