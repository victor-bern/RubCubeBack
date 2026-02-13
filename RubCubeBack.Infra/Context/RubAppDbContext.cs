using Microsoft.EntityFrameworkCore;
using RubCubeBack.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RubCubeBack.Infra.Context
{
    public class RubAppDbContext : DbContext 
    {
        public RubAppDbContext(DbContextOptions opt) : base(opt)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Name).IsRequired().HasMaxLength(50);
                entity.Property(e => e.Email).IsRequired().HasMaxLength(100);
                entity.Property(e => e.Password).IsRequired();
            });

            modelBuilder.Entity<User>()
                .HasIndex(u => u.Email)
                .IsUnique();    

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<User> Users { get; set; }
    }
}
