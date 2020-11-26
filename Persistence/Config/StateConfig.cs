﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PointFood.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PointFood.Persistence.Config
{
    public class StateConfig
    {
        public StateConfig(EntityTypeBuilder<State> entityBuilder)
        {
            entityBuilder.Property(x => x.Name).IsRequired().HasMaxLength(20);
        }
    }
}
