using MatLogg.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatLogg.Infrastructure.Data
{
    public class MatLoggDbContext: DbContext
    {
        public DbSet<SaveFood> SaveFoods { get; set; }
        public MatLoggDbContext(DbContextOptions<MatLoggDbContext> options) : base(options) 
        { 
            
        }
    }
}
