using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Academia.Models;


namespace Academia.DAL {
    public class AcademiaInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<AcademiaContext> {
        protected override void Seed(AcademiaContext context) { 
            var usuarios = new List<Usuario> {            
                new Usuario {NombreUsuario = "lucas144", Clave = "1234", Habilitado = true},
                new Usuario {NombreUsuario = "agusdelm", Clave = "elchicorubio", Habilitado = true},
                new Usuario {NombreUsuario = "tinchopereyra", Clave = "central", Habilitado = true},
            };

            usuarios.ForEach(u => context.Usuarios.Add(u));
                context.SaveChanges();
        }
    }
}