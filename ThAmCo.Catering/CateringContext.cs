using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ThAmCo.Catering.Models;

namespace ThAmCo.Catering
{
    public class CateringContext : DbContext
    {
        public DbSet<FoodItem> FoodItems { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<MenuFoodItem> MenuFoodItems { get; set; }
        public DbSet<FoodBooking> foodBookings { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Catering;");

        protected override void OnModelCreating(ModelBuilder builder) {
            base.OnModelCreating(builder);

            builder.Entity<FoodBooking>().HasOne(b => b.Menu).WithMany().HasForeignKey(b => b.MenuId).OnDelete(DeleteBehavior.SetNull);

            builder.Entity<MenuFoodItem>().HasKey(a => new { a.MenuId, a.FoodItemId});

            builder.Entity<MenuFoodItem>().HasOne(a => a.Menu).WithMany(m => m.MenuFoodItems).HasForeignKey(a => a.MenuId);

            builder.Entity<MenuFoodItem>().HasOne(a => a.FoodItem).WithMany().HasForeignKey(a => a.FoodItemId);

            //seed data

            builder.Entity<FoodItem>().HasData(
                new FoodItem { FoodItemId = 1, Description = "Tomato Soup", UnitPrice = 4f },
                new FoodItem { FoodItemId = 2, Description = "French Onion Soup", UnitPrice = 3.5f },
                new FoodItem { FoodItemId = 3, Description = "Leak & Onion Soup", UnitPrice = 3.75f },
                new FoodItem { FoodItemId = 4, Description = "White bread bun", UnitPrice = .75f },
                new FoodItem { FoodItemId = 5, Description = "Wholemeal bun", UnitPrice = .75f }
            );

            builder.Entity<Menu>().HasData(
                    new Menu { MenuId = 1, MenuName = "French Classic" },
                    new Menu { MenuId = 2, MenuName = "Chef's Soup" }
                );

            builder.Entity<MenuFoodItem>().HasData(
                new MenuFoodItem { MenuId = 1, FoodItemId = 2 },
                new MenuFoodItem { MenuId = 1, FoodItemId = 5 },
                new MenuFoodItem { MenuId = 2, FoodItemId = 1 },
                new MenuFoodItem { MenuId = 2, FoodItemId = 4 }
                );

            builder.Entity<FoodBooking>().HasData(
                new FoodBooking { FoodBookingId = 1, NumberOfGuests = 15, MenuId = 1, ClientReference = 1 },
                new FoodBooking { FoodBookingId = 2, NumberOfGuests = 12, MenuId = 2, ClientReference = 2 }
                );

        }
    }
}
