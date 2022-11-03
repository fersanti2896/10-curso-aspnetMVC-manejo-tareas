﻿using ManejoTareas.Entities;
using Microsoft.EntityFrameworkCore;

namespace ManejoTareas {
    public class ApplicationDbContext : DbContext {
        public ApplicationDbContext(DbContextOptions options) : base(options) {
        }

        /* API FLuent */
        protected override void OnModelCreating(ModelBuilder modelBuilder) { 
            base.OnModelCreating(modelBuilder);

            /* modelBuilder.Entity<Tarea>().Property(t => t.Titulo)
                                        .HasMaxLength(250)
                                        .IsRequired(); */
        }

        public DbSet<Tarea> Tareas { get; set; }
    }
}
