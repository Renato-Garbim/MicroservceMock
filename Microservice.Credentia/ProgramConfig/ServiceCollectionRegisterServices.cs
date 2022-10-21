using Microservice.Credentia.AutoMapper;
using Microservice.Credentia.CrossCutting.IoC;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microservice.Credentia.API.ProgramConfig
{
    public static class ServiceCollectionRegisterServices
    {
        public static IServiceCollection StartRegisterServices(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(BootstraperAutoMapper).Assembly);

            // Ioc 
            Bootstraper.RegisterServices(services);

            return services;
        }


    }
}
