using Academia.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;


namespace Academia.DAL {
    public class AcademiaContext : DbContext {
        // Pasa como parámetro el string connection
        public AcademiaContext() : base("AcademiaContext") {
        }
        public DbSet<Usuario> Usuarios { get; set; }

        // Creación de tablas con nombres en singular
        protected override void OnModelCreating(DbModelBuilder modelBuilder) {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}