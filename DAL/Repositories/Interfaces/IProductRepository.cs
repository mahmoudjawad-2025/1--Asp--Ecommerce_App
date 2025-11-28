using D_A_L.Models;
using D_A_L.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_A_L.Repositories.Interfaces
{
    public interface IProductRepository : IGenericRepository<Product>
    {
        public Task DecreaseQuantityAsync(List<(int productId, int quantity)>items);
        List<Product> GetAllProductsWithImage();
    }
}
