using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PointFood.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PointFood.Persistence.Config
{
    public class MenuProductConfig
    {
        public MenuProductConfig(EntityTypeBuilder<MenuProduct> entityBuilder)
        {
            entityBuilder.HasOne(x => x.Menu)
                .WithMany(x => x.Products)
                .HasForeignKey(x => x.MenuId);

            entityBuilder.HasOne(x => x.Product)
                .WithMany()
                .HasForeignKey(x => x.ProductId);
        }
    }
}
