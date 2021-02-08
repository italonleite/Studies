using DescriminatorTest.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DescriminatorTest.Context
{
    public class DiscriminatorTet : DbContext
    {
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<RssBlog> RssBlogs { get; set; }
        //  public DbSet<Person> People { get; set; }

       

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DEV_ITALOLEITE\SQLEXPRESS;Database=EFRelatDiscriminator;Trusted_Connection=True;MultipleActiveResultSets=true");
            // optionsBuilder.LogTo(Console.WriteLine);
        }

        protected void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Blog>().HasKey(a => a.BlogId);
             modelBuilder.Entity<Blog>()
            .HasDiscriminator<string>("blog_type")
            .HasValue<Blog>("blog_base")
            .HasValue<RssBlog>("blog_rss");
           


        }
    }

   
}
