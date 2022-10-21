
using AutoMapper;
using Repository.Utilities.CrossCutting.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain.Utilities.CrossCutting
{
    public class ServiceBase<TEntity, TEntityDTO> : IServiceBase<TEntity, TEntityDTO> where TEntity : class where TEntityDTO : class
    {
        private readonly IRepositoryBase<TEntity> _repository;
        protected readonly IMapper Mapper;

        public ServiceBase(IRepositoryBase<TEntity> repository, IMapper mapper)
        {
            _repository = repository;
            Mapper = mapper;
        }

        public bool InsertRecord(TEntityDTO objeto)
        {
            var entity = Mapper.Map<TEntity>(objeto);

            return _repository.InsertRecord(entity);            
        }

        public bool UpdateRecord(TEntityDTO objeto)
        {
            var entity = Mapper.Map<TEntity>(objeto);

            return _repository.UpdateRecord(entity);

        }

        public IEnumerable<TEntityDTO> GetAllRecords()
        {
            var baseRegistries = _repository.GetAllRecords();

            return Mapper.Map<IEnumerable<TEntityDTO>>(baseRegistries);

        }

        public TEntityDTO GetRecordById(int id)
        {
            var register = _repository.GetRecordById(id);
            
            return Mapper.Map<TEntityDTO>(register);
        }

        public bool RemoveRecord(TEntityDTO objeto)
        {
            var entity = Mapper.Map<TEntity>(objeto);
            
            return _repository.RemoveRecord(entity);
        }


    }

}
