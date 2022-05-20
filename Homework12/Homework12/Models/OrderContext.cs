﻿using Microsoft.EntityFrameworkCore;

namespace Homework12.Models
{
    public class OrderContext : DbContext
    {
        public OrderContext(DbContextOptions<OrderContext> options)
            : base(options)
        {
            this.Database.EnsureCreated(); //自动建库建表
        }

        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }
        public DbSet<Good> GoodItems { get; set; }
        public DbSet<Client> Client { get; set; }
    }
}