using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Entities;


namespace Data {
    public class AcademiaInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<AcademiaContext> {
        protected override void Seed(AcademiaContext context) { 
            var personas = new List<Persona> {
                new Persona { Nombre = "Lucas", Apellido = "Randisi", Direccion = "Valle 1234", Email = "lucasrandisi@gmail.com", Telefono = "34144444", FechaNacimiento = DateTime.ParseExact("1997-09-10", "yyyy-MM-dd",System.Globalization.CultureInfo.InvariantCulture), Legajo = 44464, TipoPersona = Persona.Rol.Alumno },
                new Persona { Nombre = "Juan", Apellido = "Alberto", Direccion = "Mendoza 5590", Email = "juanalberto@gmail.com", Telefono = "1617486", FechaNacimiento = DateTime.ParseExact("1997-28-02", "yyyy-MM-dd",System.Globalization.CultureInfo.InvariantCulture), Legajo = 45895, TipoPersona = Persona.Rol.Alumno },
                new Persona { Nombre = "Maria", Apellido = "Del Carmen", Direccion = "Zeballos 220", Email = "mari_nob_78@gmail.com", Telefono = "6262256", FechaNacimiento = DateTime.ParseExact("1997-15-07", "yyyy-MM-dd",System.Globalization.CultureInfo.InvariantCulture), Legajo = 44236, TipoPersona = Persona.Rol.Alumno },
                new Persona { Nombre = "Julia", Apellido = "Pellegrini", Direccion = "Crespo 2000", Email = "medicenjuli@gmail.com", Telefono = "3365652", FechaNacimiento = DateTime.ParseExact("1963-12-12", "yyyy-MM-dd",System.Globalization.CultureInfo.InvariantCulture), Legajo = 45895, TipoPersona = Persona.Rol.Docente },
                new Persona { Nombre = "Roman", Apellido = "Castillo", Direccion = "Pte Roca 411", Email = "llegoRomanElPrece@gmail.com", Telefono = "4684961", FechaNacimiento = DateTime.ParseExact("1971-07-09", "yyyy-MM-dd",System.Globalization.CultureInfo.InvariantCulture), Legajo = 45895, TipoPersona = Persona.Rol.Docente }
            };

            personas.ForEach(p => context.Personas.Add(p));
            context.SaveChanges();

            var usuarios = new List<Usuario> {
                new Usuario {NombreUsuario = "lucas144", Clave = "1234", Habilitado = true, CambioClave = false, PersonaID = 1},
                new Usuario {NombreUsuario = "juanAlb", Clave = "soyalbert", Habilitado = true, CambioClave = false, PersonaID = 2},
                new Usuario {NombreUsuario = "maridelc", Clave = "ninombre", Habilitado = true, CambioClave = false, PersonaID = 3},
                new Usuario {NombreUsuario = "juliapell", Clave = "laseñora", Habilitado = true, CambioClave = false, PersonaID = 4},
                new Usuario {NombreUsuario = "preceroman", Clave = "central", Habilitado = true, CambioClave = false, PersonaID = 5},
            };

            usuarios.ForEach(u => context.Usuarios.Add(u));
            context.SaveChanges();


        }
    }
}