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

        public DbSet<User> Users { get; set; }
    }
}
