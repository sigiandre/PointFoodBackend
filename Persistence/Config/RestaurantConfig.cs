using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PointFood.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PointFood.Persistence.Config
{
    public class RestaurantConfig
    {
        public RestaurantConfig(EntityTypeBuilder<Restaurant> entityBuilder)
        {
            entityBuilder.Property(x => x.Name).IsRequired().HasMaxLength(30);
            entityBuilder.Property(x => x.Address).IsRequired().HasMaxLength(100);
            entityBuilder.Property(x => x.PhoneNumber).IsRequired().HasMaxLength(9);

            entityBuilder.HasOne(x => x.Category)
                .WithMany(x => x.Restaurants)
                .HasForeignKey(x => x.CategoryId);
        }
    }
}
