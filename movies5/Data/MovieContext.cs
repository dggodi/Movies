using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Movies5.Model;
using Microsoft.Extensions.Configuration;

namespace Movies5.Data
{
    public class MovieContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }

        public MovieContext(DbContextOptions<MovieContext> options): base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>(entity =>
            {
                entity.Property(e => e.Title).IsRequired();
                entity.Property(e => e.ReleaseYear).IsRequired();
            });
        }

        IConfiguration _configuration;
    }
}