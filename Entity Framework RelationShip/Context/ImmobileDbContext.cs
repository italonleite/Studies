using Entity_Framework_RelationShip.Mapping;
using Entity_Framework_RelationShip.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity_Framework_RelationShip.Data
{
    public class ImmobileDbContext : DbContext
    {
        public DbSet<Immobile> Immobiles { get; set; }
        public DbSet<Address> Addresses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DEV_ITALOLEITE\SQLEXPRESS;Database=EFRelationShip;Trusted_Connection=True;MultipleActiveResultSets=true");
           // optionsBuilder.LogTo(Console.WriteLine);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ImmobileMap());
            modelBuilder.ApplyConfiguration(new AddressMap());
        }
    }
}
