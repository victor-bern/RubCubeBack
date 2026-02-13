using Microsoft.EntityFrameworkCore;
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
    }
}
