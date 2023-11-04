using Microsoft.EntityFrameworkCore;
using ProjectPractice.Application.Services.Public;
using ProjectPractice.Domain.Entities.Public;
using ProjectPractice.Domain.Interfaces.Repositories.Public;
using ProjectPractice.Domain.Interfaces.Services.Public;
using ProjectPractice.Infrastructure.Repositories.Public;

namespace ProjectPractice.API
{
    public static class DependencyInjectionSystem
    {
        public static IServiceCollection AddServices(this IServiceCollection services, IConfiguration configuration)
        {
            //ADD REPOSITORYS
            services.AddScoped<IParentRepository, ParentRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IVehicleRepository, VehicleRepository>();
            services.AddScoped<IVehicleStatusRepository, VehicleStatusRepository>();
            services.AddScoped<IBrandRepository, BrandRepository>();

            //ADD SERVICES
            services.AddScoped<IParentService, ParentService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IVehicleService, VehicleService>();
            services.AddScoped<IVehicleStatusService, VehicleStatusService>();
            services.AddScoped<IBrandService, BrandService>();

            //GET CONNECTION
            services.AddDbContext<FirstContext>(opt =>
            {
                opt.UseNpgsql(configuration.GetConnectionString("PostgreSQLConnection"));

            });

            return services;
        }
    }
}
