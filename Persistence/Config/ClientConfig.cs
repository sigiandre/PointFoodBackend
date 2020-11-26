using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PointFood.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PointFood.Persistence.Config
{
    public class ClientConfig
    {
        public ClientConfig(EntityTypeBuilder<Client> entityBuilder)
        {
            entityBuilder.Property(x => x.Name).IsRequired().HasMaxLength(50);
            entityBuilder.Property(x => x.Email).IsRequired().HasMaxLength(30);
            entityBuilder.Property(x => x.PhoneNumber).IsRequired().HasMaxLength(9);
            entityBuilder.Property(x => x.SignedUpAt).IsRequired();
            entityBuilder.Property(x => x.Username).IsRequired().HasMaxLength(30);
            entityBuilder.Property(x => x.Password).IsRequired().HasMaxLength(30);
        }
    }
}
