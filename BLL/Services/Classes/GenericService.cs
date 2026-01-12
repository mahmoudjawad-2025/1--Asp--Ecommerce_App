using B_L_L.Services.Interfaces;
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
    public class GenericService<TRequest, TResponse, TEntity> : IGenericService<TRequest, TResponse, TEntity>
        where TEntity : BaseModel
    {
        private readonly IGenericRepository<TEntity> _repository;

        public GenericService(IGenericRepository<TEntity> genericRepository)
        {
            _repository = genericRepository;
        }

        public int Create(TRequest request)
        {
            var entity = request.Adapt<TEntity>();
            return _repository.Add(entity);
        }

        public int Delete(int id)
        {
            var entity = _repository.GetById(id);
            if (entity is null) return 0;
            return _repository.Remove(entity);
        }

        public IEnumerable<TResponse> GetAll(bool activeFilter = false)
        {
            var entities = _repository.GetAll();
            if(activeFilter)
                entities = entities.Where(e => e.status == Status.active);
            return entities.Adapt<IEnumerable<TResponse>>();
        }

        public TResponse? GetById(int id)
        {
            var entity = _repository.GetById(id);
            return entity is null ? default : entity.Adapt<TResponse>();
        }

        public bool ToggleStatus(int id)
        {
            var entity = _repository.GetById(id);
            if (entity is null) return false;

            entity.status = entity.status == Status.active ? Status.inActive : Status.active;
            _repository.Update(entity);
            return true;
        }

        public int Update(int id, TRequest request)
        {
            var entity = _repository.GetById(id);
            if (entity is null) return 0;

            var updatedEntity = request.Adapt(entity);
            return _repository.Update(updatedEntity);
        }
    }
}
