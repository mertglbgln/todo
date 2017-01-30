﻿using Cil.Todo.Data.Model.Domain;
using System.Data.Entity.ModelConfiguration;

namespace Cil.Todo.Data.Model.Mapping
{
    public partial class StateMap : EntityTypeConfiguration<State>
    {
        public StateMap()
        {
            ToTable("CTD.State");
            Property(p => p.Name).IsRequired().HasMaxLength(50);
            Property(p => p.DisplayOrder).IsRequired();

            HasRequired(s => s.Country)
                .WithMany(c => c.States)
                .HasForeignKey(s => s.CountryId);
        }
    }
}
