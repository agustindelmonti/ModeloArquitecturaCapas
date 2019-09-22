using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Academia.Models;


namespace Academia.DAL {
    public class AcademiaInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<AcademiaContext> {
        protected override void Seed(AcademiaContext context) { 
            var personas = new List<Persona> {
                new Persona { Nombre = "Lucas", Apellido = "Randisi", Direccion = "Valle 1234", Email = "lucasrandisi@gmail.com", Telefono = "34144444", FechaNacimiento = DateTime.ParseExact("1997-09-10", "yyyy-MM-dd",System.Globalization.CultureInfo.InvariantCulture), Legajo = 4444 } 
            };

            personas.ForEach(p => context.Personas.Add(p));
            context.SaveChanges();

            //var usuarios = new List<Usuario> {            
            //    new Usuario {NombreUsuario = "lucas144", Clave = "1234", Habilitado = true, CambioClave = false, PersonaID = 1},
            //    new Usuario {NombreUsuario = "agusdelm", Clave = "elchicorubio", Habilitado = true, CambioClave = false, PersonaID = 1},
            //    new Usuario {NombreUsuario = "tinchopereyra", Clave = "central", Habilitado = true, CambioClave = false, PersonaID = 1},
            //};

            //usuarios.ForEach(u => context.Usuarios.Add(u));
            //context.SaveChanges();
        }
    }
}