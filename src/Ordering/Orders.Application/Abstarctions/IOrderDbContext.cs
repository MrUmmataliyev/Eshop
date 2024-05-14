using Microsoft.EntityFrameworkCore;
using Orders.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orders.Application.Abstarctions
{
    public interface IOrderDbContext
    {
       public DbSet<OrderModel> orderModels { get; set; }

       public Task<int> SaveChangesAsync(CancellationToken cancellation);


    }
}
