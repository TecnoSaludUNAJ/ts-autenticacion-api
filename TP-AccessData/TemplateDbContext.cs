using Microsoft.EntityFrameworkCore;
using TP_Domain.Entities;

namespace TP_AccessData
{
   public class TemplateDbContext : DbContext
    {
        public TemplateDbContext(DbContextOptions<TemplateDbContext> options) : base(options)
        {

        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Rol> Rols { get; set; }

        // role set 
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Rol>().HasData(new Rol() { Id = 1, Nombre = "Administrador" });
            modelBuilder.Entity<Rol>().HasData(new Rol() { Id = 2, Nombre = "Profesional" });
            modelBuilder.Entity<Rol>().HasData(new Rol() { Id = 3, Nombre = "Paciente" });
        }
    }
}
