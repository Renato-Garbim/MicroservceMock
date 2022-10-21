using AutoMapper;
using Domain.Utilities.CrossCutting;
using Microservice.Credentia.Domain.Entities;
using Microservice.Credentia.Domain.Services.Interfaces;
using Microservice.Credentia.DTO;
using Microservice.Credentia.Repository.Interface;
using Repository.Utilities.CrossCutting.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Microservice.Credentia.Domain.Services
{
    public class EntidadeModeloService : ServiceBase<EntidadeModelo, EntidadeModeloDTO>, IEntidadeModeloService
    {
        private readonly IEntidadeModeloRepository _repository;

        public EntidadeModeloService(IEntidadeModeloRepository repository, IMapper mapper) : base(repository, mapper)
        {
            _repository = repository;
        }

        // Aqui fica toda a regra de Negócio referente a Entidade dentro deste Contexto


    }
}
