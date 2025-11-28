using DAL.DTO.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace D_A_L.DTO.Responses
{
    public class ProductResponse
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        [JsonIgnore]
        public string MainImage { get; set; }
        public string MainImageUrl { get; set; }
        public List<string> SubImagesUrls { get; set; } = new List<string>();
        public List<ReviewResponse> Reviews { get; set; } = new List<ReviewResponse>();
    }
}
