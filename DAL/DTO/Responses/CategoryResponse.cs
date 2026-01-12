using D_A_L.Models;

namespace D_A_L.DTO.Responses
{
    public class CategoryResponse
    {
        public int id { get; set; }
        public string name { get; set; }
        public Status status { get; set; }
    }
}
