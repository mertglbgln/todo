﻿using Cil.Todo.Data.Model.Domain;
using System.Data.Entity.ModelConfiguration;

namespace Cil.Todo.Data.Model.Mapping
{
    public partial class CityMap : EntityTypeConfiguration<City>
    {
        public CityMap()
        {
            ToTable("CTD.City");
            Property(p => p.Name).IsRequired().HasMaxLength(50);
            Property(p => p.DisplayOrder).IsRequired();

            HasRequired(c => c.State)
                .WithMany(s => s.Cities)
                .HasForeignKey(c => c.StateId);
        }
    }
}
