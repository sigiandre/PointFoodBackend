using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PointFood.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PointFood.Persistence.Config
{
    public class ExtraConfig
    {
        public ExtraConfig(EntityTypeBuilder<Extra> entityBuilder)
        {
            entityBuilder.Property(x => x.Name).IsRequired().HasMaxLength(50);
            entityBuilder.Property(x => x.Price).IsRequired().HasColumnType("decimal(5,2)");
        }
    }
}
