﻿using Microsoft.EntityFrameworkCore;
using SchoolProjectWeb.Models;

namespace SchoolProjectWeb.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // Agrega tus DbSets aquí
        public DbSet<Estudiante> Estudiantes { get; set; }
        public DbSet<Profesor> Profesores { get; set; }
        public DbSet<Actividad> Actividades { get; set; }
        public DbSet<Inscripcion> Inscripciones { get; set; }
        public DbSet<Evento> Eventos { get; set; }
    }
}