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
                new Persona { Nombre = "Lucas", Apellido = "Randisi", Direccion = "Valle 1234", Email = "lucasrandisi@gmail.com", Telefono = "34144444", FechaNacimiento = DateTime.ParseExact("09-10-1997", "dd-MM-yyyy",System.Globalization.CultureInfo.InvariantCulture), Legajo = 44464, TipoPersona = Persona.Rol.Alumno },
                new Persona { Nombre = "Juan", Apellido = "Alberto", Direccion = "Mendoza 5590", Email = "juanalberto@gmail.com", Telefono = "1617486", FechaNacimiento = DateTime.ParseExact("28-02-1998", "dd-MM-yyyy",System.Globalization.CultureInfo.InvariantCulture), Legajo = 45895, TipoPersona = Persona.Rol.Alumno },
                new Persona { Nombre = "Maria", Apellido = "Del Carmen", Direccion = "Zeballos 220", Email = "mari_nob_78@gmail.com", Telefono = "6262256", FechaNacimiento = DateTime.ParseExact("15-07-1997", "dd-MM-yyyy",System.Globalization.CultureInfo.InvariantCulture), Legajo = 44236, TipoPersona = Persona.Rol.Alumno },
                new Persona { Nombre = "Julia", Apellido = "Pellegrini", Direccion = "Crespo 2000", Email = "medicenjuli@gmail.com", Telefono = "3365652", FechaNacimiento = DateTime.ParseExact("12-12-1963", "dd-MM-yyyy",System.Globalization.CultureInfo.InvariantCulture), Legajo = 45895, TipoPersona = Persona.Rol.Docente },
                new Persona { Nombre = "Roman", Apellido = "Castillo", Direccion = "Pte Roca 411", Email = "llegoRomanElPrece@gmail.com", Telefono = "4684961", FechaNacimiento = DateTime.ParseExact("07-09-1971", "dd-MM-yyyy",System.Globalization.CultureInfo.InvariantCulture), Legajo = 45895, TipoPersona = Persona.Rol.Docente },
                new Persona { Nombre = "Matt", Apellido = "Enme P. Orfavor", Direccion = "Av Siempre Viva 222", Email = "Matt.enme@gmail.com", Telefono = "4684961", FechaNacimiento = DateTime.ParseExact("01-01-1970", "dd-MM-yyyy",System.Globalization.CultureInfo.InvariantCulture), Legajo = 45222, TipoPersona = Persona.Rol.No_Docente }
            };

            personas.ForEach(p => context.Personas.Add(p));
            context.SaveChanges();

            var usuarios = new List<Usuario> {
                new Usuario {NombreUsuario = "lucas144", Clave = "1234", Habilitado = true, CambioClave = false, PersonaID = 1},
                new Usuario {NombreUsuario = "juanAlb", Clave = "soyalbert", Habilitado = true, CambioClave = false, PersonaID = 2},
                new Usuario {NombreUsuario = "maridelc", Clave = "ninombre", Habilitado = true, CambioClave = false, PersonaID = 3},
                new Usuario {NombreUsuario = "juliapell", Clave = "laseñora", Habilitado = true, CambioClave = false, PersonaID = 4},
                new Usuario {NombreUsuario = "preceroman", Clave = "central", Habilitado = true, CambioClave = false, PersonaID = 5},
                new Usuario {NombreUsuario = "matt_enme", Clave = "porfavor", Habilitado = true, CambioClave = false, PersonaID = 6}
            };

            usuarios.ForEach(u => context.Usuarios.Add(u));
            context.SaveChanges();


        }
    }
}