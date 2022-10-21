using Microservice.Credentia.Domain.Services;
using Microservice.Credentia.Domain.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Microservice.Credentia.CrossCutting.IoC.Modules
{
    public class ServiceModule
    {
        public static void SetModules(IServiceCollection container)
        {
            container.AddScoped<IEntidadeModeloService, EntidadeModeloService>();


        }
    }
}
