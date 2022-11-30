using ProjectD.Contracts;
using ProjectD.Data.Common;
using ProjectD.Services;

namespace ProjectD.Extensions
{
    public static class ProjectDServiceCollectionExtension
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection  services)
        {
            services.AddScoped<IRepository, Repository>();
            services.AddScoped<IMapService, MapService>();

            return services;
        }
    }
}
