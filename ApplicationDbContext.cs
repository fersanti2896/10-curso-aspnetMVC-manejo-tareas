using ManejoTareas.Entities;
using Microsoft.EntityFrameworkCore;

namespace ManejoTareas {
    public class ApplicationDbContext : DbContext {
        public ApplicationDbContext(DbContextOptions options) : base(options) {
        }

        public DbSet<Tarea> Tareas { get; set; }
    }
}
