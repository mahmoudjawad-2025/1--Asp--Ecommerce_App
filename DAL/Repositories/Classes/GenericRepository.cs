using D_A_L.Data_Base;
using D_A_L.Models;
using D_A_L.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_A_L.Repositories.Classes
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseModel
    {
        private readonly ApplicationDbContext _context;
        public GenericRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public int Add(T entity)
        {
            _context.Set<T>().Add(entity);
            return _context.SaveChanges();
        }

        public IEnumerable<T> GetAll(bool withTracking = false)
        {
            if (withTracking)
                return _context.Set<T>().ToList();

            return _context.Set<T>().AsNoTracking().ToList();
        }

        public T? GetById(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public int Remove(T entity)
        {
            _context.Set<T>().Remove(entity);
            return _context.SaveChanges();
        }

        public int Update(T entity)
        {
            _context.Set<T>().Update(entity);
            return _context.SaveChanges();
        }
    }
}
