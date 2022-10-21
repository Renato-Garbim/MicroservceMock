using Microservice.Credentia.Domain.Entities;
using Microservice.Credentia.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace HeroMicroservice.AutoMapper.Profiles
{
    public class CoreEntities : global::AutoMapper.Profile
    {
        public CoreEntities()
        {

            CreateMap<EntidadeModelo, EntidadeModeloDTO>();

            CreateMap<EntidadeModeloDTO, EntidadeModelo>()
                .ConstructUsing(x => new EntidadeModelo(x.Id, x.EntidadeDescription));

        }
    }
}
