using InfraMiggration;
using Microsoft.EntityFrameworkCore;
using Repository.Utilities.CrossCutting.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Repository.Utilities.CrossCutting
{
    public class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class
    {
        protected readonly MicroserviceCredentiaContext Db;
        protected readonly DbSet<TEntity> DBSet;

        private readonly string _strConexao;

        public RepositoryBase(MicroserviceCredentiaContext db)
        {
            Db = db;
            if (db == null)
                throw new ArgumentNullException(nameof(db));

            DBSet = Db.Set<TEntity>();
            _strConexao = Db.Database.GetDbConnection().ConnectionString;

        }

        public void Dispose()
        {
            Db.Dispose();
            GC.SuppressFinalize(this);
        }

        private void AlterarBanco()
        {
            Db.SaveChanges();
        }

        public virtual IQueryable<TEntity> GetAllRecords()
        {
            var registros = DBSet.AsNoTracking().AsQueryable();
            return registros;
        }

        public virtual bool InsertRecord(TEntity obj)
        {
            var inseridoSucesso = false;

            try
            {                
                DBSet.Add(obj);
                AlterarBanco();

                inseridoSucesso = true;

            }
            catch (DbUpdateException /* ex */)
            {
                inseridoSucesso = false;
            }

            return inseridoSucesso;
        }

        public virtual bool UpdateRecord(TEntity obj)
        {
            var updateSucesso = false;

            try
            {
                DBSet.Update(obj);
                AlterarBanco();

                updateSucesso = true;
            }
            catch (DbUpdateException /* ex */)
            {
                updateSucesso = false;
            }



            return updateSucesso;
        }

        public virtual bool RemoveRecord(TEntity obj)
        {

            var removidoSucesso = false;

            try
            {
                DBSet.Remove(obj);
                AlterarBanco();

                removidoSucesso = true;
            }
            catch (DbUpdateException /* ex */)
            {
                removidoSucesso = false;
            }

            return removidoSucesso;
        }

        public virtual TEntity GetRecordById(int id)
        {
            var registro = DBSet.Find(id);

            return registro;
        }
    }
}
