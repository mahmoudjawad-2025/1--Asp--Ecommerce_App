using D_A_L.DTO.Requests;
using D_A_L.DTO.Responses;
using D_A_L.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_L_L.Services.Interfaces
{
    public interface IBrandService : IGenericService<BrandRequest, BrandResponse, Brand>
    {
        Task<int> CreateFile(BrandRequest request);
    }
}
