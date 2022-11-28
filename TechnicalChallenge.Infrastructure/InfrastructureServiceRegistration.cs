using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using TechnicalChallenge.Application.Contracts.Persistence;
using TechnicalChallenge.Infrastructure.Persistence;
using TechnicalChallenge.Infrastructure.Repositories;

namespace TechnicalChallenge.Infrastructure
{
    public static class InfrastructureServiceRegistration
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<NorthwindDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            //services.AddScoped(typeof(IAsyncRepository<>), typeof(RepositoryBase<>));
           services.AddScoped<IOrderRepositoryAsync, OrderRepositoryAsync>();

            return services;
        }
    }
}
