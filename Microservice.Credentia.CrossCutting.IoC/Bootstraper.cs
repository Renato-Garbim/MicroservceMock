using Microservice.Credentia.CrossCutting.IoC.Modules;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Microservice.Credentia.CrossCutting.IoC
{
    public class Bootstraper
    {
        public static void RegisterServices(IServiceCollection container)
        {

            RepositoryModule.SetModules(container);
            ServiceModule.SetModules(container);

        }
    }
}
