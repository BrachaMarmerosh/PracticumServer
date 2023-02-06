using Common.DTOs;
using Context;
using Microsoft.Extensions.DependencyInjection;
using Repositories;
using Services.Entities;

namespace Services
{
    public static class ServiceCollectionExtention
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddRepositories();
            services.AddScoped<IService<UserDTO>, UserService>();
            services.AddSingleton<Icontext, MyDbContext>();
            services.AddAutoMapper(typeof(MappingProfile));

            return services;
        }
    }
}