using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Entities;



namespace Data {
    public class AcademiaContext : DbContext {
        // Pasa como parámetro el string connection
        public AcademiaContext() : base("localStringConn") {

            Database.SetInitializer(new AcademiaInitializer());
           
        }

        public DbSet<Persona> Personas { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<ModuloUsuario> ModuloUsuarios { get; set; }
        public DbSet<Modulo> Modulos { get; set; }
        public DbSet<DocenteCurso> DocenteCursos  { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Materia> Materias  { get; set; }
        public DbSet<Plan> Planes  { get; set; }
        public DbSet<Comision> Comisiones  { get; set; }
        public DbSet<Especialidad> Especialidades  { get; set; }
        public DbSet<AlumnoInscripcion> AlumnoInscripciones  { get; set; }
        public DbSet<BloqueCursado> BloquesCursado { get; set; }


        // Creación de tablas con nombres en singular
        protected override void OnModelCreating(DbModelBuilder modelBuilder) {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            // Prevenir borrado circular en cascada
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }
    }
}