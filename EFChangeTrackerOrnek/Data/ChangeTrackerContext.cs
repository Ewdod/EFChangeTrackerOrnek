using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFChangeTrackerOrnek.Data
{
    public  class ChangeTrackerContext : DbContext
    {
        public DbSet<Ogrenci> Ogrenciler => Set<Ogrenci>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server=(localdb)\MSSQLLocalDB;database=EFChangeTracker2;trusted_connection=true");
        }

    }
}
