using Microsoft.EntityFrameworkCore;
using Shoppingcarts.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoppingcarts.Application.Abstractions
{
    public interface IShoppungCartDbContext
    {
        public DbSet<ShoppingCartModel> shoppingCarts { get; set; }
        public Task<int> SaveChangesAsync(CancellationToken cancellation);
    }
}
