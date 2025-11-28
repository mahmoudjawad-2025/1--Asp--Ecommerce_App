using D_A_L.DTO.Requests;
using D_A_L.DTO.Responses;
using D_A_L.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_L_L.Services.Interfaces
{
    public interface IProductService : IGenericService<ProductRequest, ProductResponse, Product>
    {
        Task<int> CreateProduct(ProductRequest request);
        Task<List<ProductResponse>> GetAllProducts(HttpRequest request, int pageNumber = 1, int pageSize = 1, bool onlyActive = false);
    }
}
