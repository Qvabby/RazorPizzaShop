﻿using Microsoft.EntityFrameworkCore;
using RazorPizzaShop.Models;

namespace RazorPizzaShop.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
        public DbSet<PizzaOrder> PizzaOrders { get; set; }
    }
}
