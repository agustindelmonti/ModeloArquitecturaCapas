﻿using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Entities;



namespace Data {
    public class AcademiaContext : DbContext {
        // Pasa como parámetro el string connection
        public AcademiaContext() : base("localStringConn") {
        }

        public DbSet<Persona> Personas { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<DocenteCurso> DocenteCursos  { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Materia> Materias  { get; set; }
        public DbSet<Plan> Planes  { get; set; }
        public DbSet<Comision> Comisiones  { get; set; }
        public DbSet<Especialidad> Especialidades  { get; set; }
        public DbSet<AlumnoInscripcion> AlumnoInscripciones  { get; set; }    


        // Creación de tablas con nombres en singular
        protected override void OnModelCreating(DbModelBuilder modelBuilder) {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }
    }
}