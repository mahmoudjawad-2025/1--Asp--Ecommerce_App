using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_L_L.Services.Interfaces
{
    public interface IGenericService<TRequest, TResponse, TEntity>
    {
        int Create(TRequest request);
        IEnumerable<TResponse> GetAll(bool activeFilter = false);
        TResponse? GetById(int id);
        int Update(int id, TRequest request);
        int Delete(int id);
        bool ToggleStatus(int id);
    }
}
