using Entity_Framework_RelationShip.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity_Framework_RelationShip.Mapping
{
    public class AddressMap : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.ToTable("Addresses");
            builder.HasKey(a => a.AddressId);
            builder.Property(a => a.ZipCode).HasColumnType("varchar(9)");
            builder.Property(a => a.Neighborhood).HasColumnType("varchar(200)");
            builder.Property(a => a.StreetAddress).HasColumnType("varchar(100)");
            builder.Property(a => a.City).HasColumnType("varchar(50)");
            builder.Property(a => a.State).HasColumnType("varchar(2)");
        }
    }
}
