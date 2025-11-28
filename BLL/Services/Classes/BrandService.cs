using B_L_L.Services.Interfaces;
using D_A_L.DTO.Requests;
using D_A_L.DTO.Responses;
using D_A_L.Models;
using D_A_L.Repositories.Interfaces;
using Mapster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_L_L.Services.Classes
{
    public class BrandService : GenericService<BrandRequest, BrandResponse, Brand>, IBrandService
    {
        private readonly IBrandRepository _repository;
        private readonly IFileService _fileService;

        public BrandService(IBrandRepository repository, IFileService fileService) : base(repository)
        {
            _repository = repository;
            _fileService = fileService;
        }

        public async Task<int> CreateFile(BrandRequest request)
        {
            var entity = request.Adapt<Brand>();
            entity.createAt = DateTime.UtcNow;

            if (request.MainImage != null)
            {
                var imagePath = await _fileService.UploadAsync(request.MainImage);
                entity.MainImage = imagePath;
            }

            return _repository.Add(entity);
        }
    }
}
