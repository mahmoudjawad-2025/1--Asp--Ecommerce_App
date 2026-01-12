using DAL.Models;
using DAL.Models.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Interfaces
{
    public interface IOrderItemRepository
    {
        Task  AddRangeAsync(List<OrderItem> items);
    }
}
