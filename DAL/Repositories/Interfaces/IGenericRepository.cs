using D_A_L.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_A_L.Repositories.Interfaces
{
    public interface IGenericRepository<T> where T : BaseModel
    {
        int Add(T entity);
        IEnumerable<T> GetAll(bool withTracking = false);
        T? GetById(int id);
        int Remove(T entity);
        int Update(T entity);
    }
}
