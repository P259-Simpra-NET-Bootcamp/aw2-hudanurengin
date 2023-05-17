using Microsoft.EntityFrameworkCore;
using SimpraHafta2Odev.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpraHafta2Odev.Persistence.Contexts
{
    public class SimpraHafta2OdevDbContext : DbContext
    {
        public SimpraHafta2OdevDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Staff> Staffs { get; set; }
    }
}
