using AutoMapper;
using ProjectD.Contracts;
using ProjectD.Data.Common;
using ProjectD.Services;

namespace ProjectD.Extensions
{
    public static class ProjectDServiceCollectionExtension
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            AutoMapperConfig(services);

            services.AddScoped<IRepository, Repository>();
            services.AddScoped<IMapService, MapService>();
            return services;
        }

        public static void AutoMapperConfig(IServiceCollection services)
        {
            MapperConfiguration mapperConfiguration = new MapperConfiguration(mc => mc.AddProfile(new ApplicationMappingProfile()));
            services.AddSingleton(mapperConfiguration.CreateMapper());
        }
    }
}
