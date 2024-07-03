using System.ComponentModel.DataAnnotations;
using flowershop.domain.flowershop;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace flowerdatabase
{
    public class flowercontext : DbContext
    {
        public flowercontext(DbContextOptions<flowercontext> options) :
            base(options)
        {
        }
        public DbSet<flowers> flowerss { get; set; }
        public DbSet<customer> customers { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<flowers>()
                .Property(x => x.Name)
                .HasMaxLength(maxLength: 60)
                .IsRequired(required: true);

            modelBuilder.Entity<flowers>()
               .Property(x => x.Color)
               .HasMaxLength(maxLength: 60);

            modelBuilder.Entity<flowers>()
                .Property(x => x.Color)
                .HasColumnType(typeName: "smallInt");

         
        }
    } }


