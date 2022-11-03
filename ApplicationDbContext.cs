using Microsoft.EntityFrameworkCore;

namespace ManejoTareas {
    public class ApplicationDbContext : DbContext {
        public ApplicationDbContext(DbContextOptions options) : base(options) {
        }
    }
}
