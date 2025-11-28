using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_L_L.Services.Interfaces
{
    public interface IFileService 
    {
        Task<string> UploadAsync(IFormFile file);
        Task<List<string>> UploadManyAsync(List<IFormFile> files);
    }
}
