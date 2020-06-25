using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjectPWA.Model;

namespace BookListRazor.Model
{
   
   
    
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Employe> Employe { get; set; }
        public DbSet<Campany> Campanies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CampanyEmploye>()
                        .HasKey(t => new { t.CampanyId, t.EmployeId });

            modelBuilder.Entity<CampanyEmploye>()
                .HasOne(pt => pt.Employe)
                .WithMany(p => p.CampanyEmployes)
                .HasForeignKey(pt => pt.EmployeId);

            modelBuilder.Entity<CampanyEmploye>()
                .HasOne(pt => pt.Campany)
                .WithMany(t => t.CampanyEmployes)
                .HasForeignKey(pt => pt.CampanyId);
        }

        internal Task SaveChangesAync()
        {
            throw new NotImplementedException();
        }
    }
}
