﻿using Microsoft.EntityFrameworkCore;
using QuanLyBanHang.WebApi.Model;

namespace QuanLyBanHang.WebApi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<ItemImage> ItemImages { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Guest> Guests { get; set; }
        public DbSet<GuestTable> GuestTables { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Unit> Units { get; set; }
        public DbSet<UnitType> UnitTypes { get; set; }
        public DbSet<Status> Statuses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }

}
