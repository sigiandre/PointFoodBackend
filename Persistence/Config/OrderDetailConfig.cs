using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PointFood.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PointFood.Persistence.Config
{
    public class OrderDetailConfig
    {
        public OrderDetailConfig(EntityTypeBuilder<OrderDetail> entityBuilder)
        {
            entityBuilder.HasOne(x => x.Order)
                .WithMany(x => x.Products)
                .HasForeignKey(x => x.OrderId);

            entityBuilder.HasOne(x => x.Product)
                .WithMany()
                .HasForeignKey(x => x.ProductId);

            entityBuilder.Property(x => x.SubTotal).IsRequired().HasColumnType("decimal(5,2)");
        }
    }
}
