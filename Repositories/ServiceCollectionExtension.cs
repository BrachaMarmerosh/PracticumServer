using Microsoft.Extensions.DependencyInjection;
using Repositories.Entities;
using Repositories.Interfaces;
using Repositories.Repositories;

namespace Repositories
{
    public static class ServiceCollectionExtention
    {
        public static void AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IdataRepository<User>,UserRepository>();
        }
    }
}