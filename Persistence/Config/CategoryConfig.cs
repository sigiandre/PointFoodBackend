using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PointFood.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PointFood.Persistence.Config
{
    public class CategoryConfig
    {
        public CategoryConfig(EntityTypeBuilder<Category> entityBuilder)
        {
            entityBuilder.Property(x => x.Name).IsRequired().HasMaxLength(20);
        }
    }
}
