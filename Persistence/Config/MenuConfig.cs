using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PointFood.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PointFood.Persistence.Config
{
    public class MenuConfig
    {
        public MenuConfig(EntityTypeBuilder<Menu> entityBuilder)
        {
            entityBuilder.HasOne(x => x.Restaurant)
                .WithMany(x => x.Menus)
                .HasForeignKey(x => x.RestaurantId);

            entityBuilder.Property(x => x.Name).IsRequired().HasMaxLength(20);
        }
    }
}
