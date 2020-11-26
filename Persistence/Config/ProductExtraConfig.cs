using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PointFood.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PointFood.Persistence.Config
{
    public class ProductExtraConfig
    {
        public ProductExtraConfig(EntityTypeBuilder<ProductExtra> entityBuilder)
        {
            entityBuilder.HasOne(x => x.MenuProduct)
                .WithMany(x => x.Extras)
                .HasForeignKey(x => x.MenuProductId)
                .IsRequired(false);

            entityBuilder.HasOne(x => x.Extra)
                .WithMany()
                .HasForeignKey(x => x.ExtraId);
        }
    }
}
