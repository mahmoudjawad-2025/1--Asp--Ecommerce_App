using B_L_L.Services.Interfaces;
using D_A_L.DTO.Requests;
using D_A_L.DTO.Responses;
using D_A_L.Models;
using D_A_L.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_L_L.Services.Classes
{
    public class CategoryService : GenericService<CategoryRequest, CategoryResponse, Category>, ICategoryService
    {
        public CategoryService(ICategoryRepository repository) : base(repository) { }
    }
}
