using Microsoft.EntityFrameworkCore;
using System;

namespace WebApiCore.Models
{
    public class OrderContext :DbContext
    {
        public OrderContext(DbContextOptions<OrderContext> options) : base(options)
        { }

        public DbSet<Order> Order { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>().ToTable("Order");
        }
    }
}
