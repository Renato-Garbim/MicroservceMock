using Microsoft.Extensions.DependencyInjection;
using Microservice.Credentia.Repository;
using Microservice.Credentia.Repository.Interface;

namespace Microservice.Credentia.CrossCutting.IoC.Modules
{
    public class RepositoryModule
    {
        public static void SetModules(IServiceCollection container)
        {
            container.AddScoped<IEntidadeModeloRepository, EntidadeModeloRepository>();

        }
    }
}
