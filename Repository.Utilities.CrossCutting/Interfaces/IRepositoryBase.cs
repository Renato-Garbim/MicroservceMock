using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Utilities.CrossCutting.Interface
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        IQueryable<TEntity> GetAllRecords();
        bool InsertRecord(TEntity obj);
        bool UpdateRecord(TEntity obj);
        bool RemoveRecord(TEntity obj);
        TEntity GetRecordById(int id);
        //TEntity GetRecordById(Guid id);
    }
}
