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
    }
}
