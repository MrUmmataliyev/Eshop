using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Orders.Application.Abstarctions;
using Orders.Infrastructure.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orders.Infrastructure
{
    public static class OrderInfrastructureDependencyInjection
    {
        public static IServiceCollection AddOrderInfrastructureDependencyInJection(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<IOrderDbContext, OrderDbContext>(options =>
            {
                options.UseNpgsql(configuration.GetConnectionString("DefaultConnection"));
            });
            return services;
        }
    }
}
