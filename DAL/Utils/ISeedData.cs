using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_A_L.Utils
{
    public interface ISeedData
    {
        public Task DataSeedingAsync();
        public Task IdentityDataSeedingAsync();
    }
}
