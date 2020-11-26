using Microsoft.EntityFrameworkCore;
using PointFood.Model;
using PointFood.Persistence.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PointFood.Persistence
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Card> Cards { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Extra> Extras { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<MenuProduct> MenuProduct { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetail { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductDetail> ProductDetail { get; set; }
        public DbSet<ProductExtra> ProductExtra { get; set; }
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<RestaurantOwner> RestaurantOwners { get; set; }
        public DbSet<State> States { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            new CardConfig(builder.Entity<Card>());
            new CategoryConfig(builder.Entity<Category>());
            new ClientConfig(builder.Entity<Client>());
            new ExtraConfig(builder.Entity<Extra>());
            new MenuConfig(builder.Entity<Menu>());
            new MenuProductConfig(builder.Entity<MenuProduct>());
            new OrderConfig(builder.Entity<Order>());
            new OrderDetailConfig(builder.Entity<OrderDetail>());
            new ProductConfig(builder.Entity<Product>());
            new ProductDetailConfig(builder.Entity<ProductDetail>());
            new ProductExtraConfig(builder.Entity<ProductExtra>());
            new RestaurantConfig(builder.Entity<Restaurant>());
            new RestaurantOwnerConfig(builder.Entity<RestaurantOwner>());
            new StateConfig(builder.Entity<State>());
        }
    }
}
