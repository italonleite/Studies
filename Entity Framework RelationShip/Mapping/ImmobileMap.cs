using Entity_Framework_RelationShip.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity_Framework_RelationShip.Mapping
{
    class ImmobileMap : IEntityTypeConfiguration<Immobile>
    {
        public void Configure(EntityTypeBuilder<Immobile> builder)
        {
            builder.ToTable("Imobiles");
            builder.HasKey(i => i.ImmobileId);
            builder.Property(i => i.EType);
            builder.HasOne(i => i.Address)
                   .WithOne()
                   .HasForeignKey<Immobile>(a => a.AddressId);
        }

    }
}
