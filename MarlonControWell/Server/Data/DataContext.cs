using MarlonControWell.Shared;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;
using MarlonControWell.Shared;
using MarlonControWell.Shared;

namespace MarlonControWell.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
        public DbSet<Pozo> Pozos { get; set; }
    }
}
