using D_A_L.Models;
using System.Text.Json.Serialization;

namespace D_A_L.DTO.Responses
{
    public class BrandResponse
    {
        public string name { get; set; }
        [JsonIgnore]
        public string MainImage { get; set; }
        public string MainImageUrl => $"https://localhost:7050/images/{MainImage}";
    }
}
