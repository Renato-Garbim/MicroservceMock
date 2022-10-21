using InfraMiggration;
using Microservice.Credentia.Domain.Entities;
using Microservice.Credentia.Repository.Interface;
using Repository.Utilities.CrossCutting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microservice.Credentia.Repository
{
    public class EntidadeModeloRepository : RepositoryBase<EntidadeModelo>, IEntidadeModeloRepository
    {
        public EntidadeModeloRepository(MicroserviceCredentiaContext db) : base(db)
        {

        }
    }
}
