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
    public class BrandRepository : GenericRepository<Brand>, IBrandRepository
    {
        public BrandRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
