using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Orderista.Models
{
    public class AppDbContext : IdentityDbContext<ApplicationUser>
    {
      

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        
        


        public DbSet<Customer> Customers { get; set; }
        public DbSet<Restaurant> Restaurants { get; set; }

        public DbSet<MenuItem> Menu { get; set; }
        public DbSet<Cart> carts { get; set; }

        public DbSet<Order> orders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {





            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Cart>().HasData(
                   new Cart
                   {

                       id = 1


                   }
                   );

            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Order>().HasData(
                   new Order
                   {

                       Id = 1


                   }
                   );






            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<MenuItem>().HasData(
                   new MenuItem
                   {
                      RestaurantRuId=4,
                       MId = 1,
                       Category = "Soup",
                       ItemName = "Hot & Sour Soup",
                       Price = 150
                   },
                   new MenuItem
                   {
                       RestaurantRuId = 4,
                       MId = 2,
                       Category = "Soup",
                       ItemName = "Thai Soup",
                       Price = 150
                   },
                   new MenuItem
                   {
                       RestaurantRuId = 4,
                       MId = 3,
                       Category = "Soup",
                       ItemName = "Chicken Corn Soup",
                       Price = 150
                   },
                   new MenuItem
                   {
                       RestaurantRuId = 4,
                       MId = 4,
                       Category = "Specials",
                       ItemName = "Chicken Chilli Dry",
                       Price = 290
                   },
                    new MenuItem
                    {
                        RestaurantRuId = 4,
                        MId = 5,
                        Category = "Specials",
                        ItemName = "Fish Chilli Dry",
                        Price = 390
                    },
                    new MenuItem
                    {
                        RestaurantRuId = 4,
                        MId = 6,
                        Category = "Specials",
                        ItemName = "Beef Chilli Dry",
                        Price = 390
                    },
                    new MenuItem
                    {
                        RestaurantRuId = 4,
                        MId = 7,
                        Category = "Specials",
                        ItemName = "Crispy Honey Beef",
                        Price = 350
                    },
                    new MenuItem
                    {
                        RestaurantRuId = 4,
                        MId = 8,
                        Category = "Noodles",
                        ItemName = "Chicken Chowmein",
                        Price = 290
                    },
                    new MenuItem
                    {
                        RestaurantRuId = 4,
                        MId = 9,
                        Category = "Noodles",
                        ItemName = "American Choupsuey",
                        Price = 290
                    },
                    new MenuItem
                    {
                        RestaurantRuId = 4,
                        MId = 10,
                        Category = "Starters",
                        ItemName = "Honey Wings",
                        Price = 220
                    },
                    new MenuItem
                    {
                        RestaurantRuId = 4,
                        MId = 11,
                        Category = "Starters",
                        ItemName = "Drum Sticks",
                        Price = 260
                    },
                    new MenuItem
                    {
                        RestaurantRuId = 4,
                        MId = 12,
                        Category = "Starters",
                        ItemName = "Spring Rolls",
                        Price = 190
                    },
                    new MenuItem
                    {
                        RestaurantRuId = 4,
                        MId = 13,
                        Category = "Chicken",
                        ItemName = "Hot Garlic",
                        Price = 290
                    },
                    new MenuItem
                    {
                        RestaurantRuId = 4,
                        MId = 14,
                        Category = "Chicken",
                        ItemName = "Szechuan",
                        Price = 290
                    },
                    new MenuItem
                    {
                        RestaurantRuId = 4,
                        MId = 15,
                        Category = "Chicken",
                        ItemName = "Kung Pao",
                        Price = 290
                    },
                    new MenuItem
                    {
                        RestaurantRuId = 4,
                        MId = 16,
                        Category = "Chicken",
                        ItemName = "Manchurian",
                        Price = 290
                    },
                    new MenuItem
                    {
                        RestaurantRuId = 4,
                        MId = 17,
                        Category = "Chicken",
                        ItemName = "Black Pepper",
                        Price = 290
                    }















                );






            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Restaurant>().HasData(
               new Restaurant
               {
                   RuId = 1,
                   Name = "Jammin Java",



               },
                new Restaurant
                {
                    RuId = 2,
                    Name = "Subway",


                },
                 new Restaurant
                 {
                     RuId = 3,
                     Name = "Zakir Tikka",



                 },
                  new Restaurant
                  {
                      RuId = 4,
                      Name = "Chop Chop",

                     







                      },
                      new Restaurant
                      {
                          RuId = 5,
                          Name = "Bombay Chowpatty",


                      },
                      new Restaurant
                      {
                          RuId = 6,
                          Name = "Juice Zone",


                      }



               ) ;


           

        }

    }
}
