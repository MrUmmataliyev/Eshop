using Microsoft.EntityFrameworkCore;
using Orders.Application.Abstarctions;
using Orders.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orders.Infrastructure.Persistance
{
    public class OrderDbContext : DbContext, IOrderDbContext
    {
        public OrderDbContext(DbContextOptions<OrderDbContext> options)
            : base(options)
        {
            
        }
        public DbSet<OrderModel> orderModels { get; set; }
    }
}
