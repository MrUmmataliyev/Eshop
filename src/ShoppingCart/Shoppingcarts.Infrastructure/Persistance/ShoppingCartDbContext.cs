using Microsoft.EntityFrameworkCore;
using Shoppingcarts.Application.Abstractions;
using Shoppingcarts.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoppingcarts.Infrastructure.Persistance
{
    public class ShoppingCartDbContext : DbContext, IShoppungCartDbContext
    {
        public ShoppingCartDbContext(DbContextOptions<ShoppingCartDbContext> options) 
            : base(options) 
        {
            
        }
        public DbSet<ShoppingCartModel> shoppingCarts { get; set; }
    }
}
