using AutoMapper;
using HeroMicroservice.AutoMapper.Profiles;
using System;
using System.Collections.Generic;
using System.Text;

namespace Microservice.Credentia.AutoMapper
{
    public static class BootstraperAutoMapper
    {
        public static Action<IMapperConfigurationExpression> ConfigAction = new Action<IMapperConfigurationExpression>(
cfg =>
{
    cfg.AllowNullCollections = true;
    cfg.AllowNullDestinationValues = true;


    cfg.AddProfile<CoreEntities>();

});
    }
}
