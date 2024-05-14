using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Shoppingcarts.Application.Abstractions;
using Shoppingcarts.Infrastructure.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoppingcarts.Infrastructure
{
    public static class ShoppingCatrsInfrastructureDependencyInjection
    {
        public static IServiceCollection AddShoppingCartsInfrastructureDependencyInjection(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<IShoppungCartDbContext, ShoppingCartDbContext>(options =>
            {
                options.UseNpgsql(configuration.GetConnectionString("DefaultConnection"));
            });
            return services;
        }
    }
}
