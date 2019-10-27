using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Entities;


namespace Data {
    public class AcademiaInitializer : DropCreateDatabaseAlways<AcademiaContext> {

        protected override void Seed(AcademiaContext context) {

            //Creacion de datos en BD 
            var especialidades = new List<Especialidad>
            {
                new Especialidad{ Alias="ISI", Descripcion="Ingenieria en Sistemas de Informacion"}, 
                new Especialidad{ Alias="IQ" , Descripcion="Ingenieria Quimica"},
                new Especialidad{ Alias="IC" , Descripcion="Ingenieria Civil"},
                new Especialidad{ Alias="IM" , Descripcion="Ingenieria Mecanica"},
                new Especialidad{ Alias="IE" , Descripcion="Ingenieria Electrica"},
            };
            especialidades.ForEach(p => context.Especialidades.Add(p));
            context.SaveChanges();

            var planes = new List<Plan>
            {
                new Plan{Descripcion="2008"},
                new Plan{Descripcion="2016"}
            };
            planes.ForEach(p => context.Planes.Add(p));
            context.SaveChanges();

            List<Especialidad> isi = (List<Especialidad>) especialidades.FindAll(e => e.Alias == "ISI");
            var materias = new List<Materia>
            {
                new Materia{Alias= "AM1", Descripcion="Analisis Matematico 1", Electiva=false, Planes= planes, HsSemanales= 5, AnioCursado=1, Especialidades=especialidades},
                new Materia{Alias= "AED", Descripcion="Algoritmos y Estructura de Datos", Electiva=false, Planes= planes, HsSemanales= 5, AnioCursado=1, Especialidades = isi},
                new Materia{Alias= "FIS1", Descripcion="Fisica 1", Electiva=false, Planes= planes, HsSemanales= 5, AnioCursado=1, Especialidades=especialidades},
                new Materia{Alias= "DS", Descripcion="Diseño Sistemas", Electiva=false, Planes= planes, HsSemanales= 6, AnioCursado=3,  Especialidades = isi},
                new Materia{Alias= "PE", Descripcion="Probabilidades y Estadistica", Electiva=false, Planes= planes, HsSemanales= 3, AnioCursado=3, Especialidades=especialidades},
                new Materia{Alias= "NET", Descripcion="Tecnologías de desarrollo de software IDE", Electiva=true, Planes= planes, HsSemanales= 4, AnioCursado=3, Especialidades = isi},
                new Materia{Alias= "JAVA", Descripcion="Lenguaje de Programación JAVA", Electiva=true, Planes= planes, HsSemanales= 4, AnioCursado=3, Especialidades = isi},
                new Materia{Alias= "SO", Descripcion="Sistemas Operativos", Electiva=false, Planes= planes, HsSemanales= 8, AnioCursado=2,  Especialidades = isi},
            };
            materias.ForEach(p => context.Materias.Add(p));
            context.SaveChanges();

            var comisiones = new List<Comision>
            {
                new Comision{Descripcion = "101", Especialidad = especialidades[0], Plan = planes[0]},
                new Comision{Descripcion = "102", Especialidad = especialidades[0], Plan = planes[0]}
            };
            comisiones.ForEach(p => context.Comisiones.Add(p));
            context.SaveChanges();

            var bloques = new List<BloqueCursado> {
                new BloqueCursado(new TimeSpan(9,0,0), 2,DayOfWeek.Friday, BloqueCursado.Tipo.Practica),
                new BloqueCursado(new TimeSpan(12,0,0), 2,DayOfWeek.Friday, BloqueCursado.Tipo.Teoria)
            };
            bloques.ForEach(u => context.BloquesCursado.Add(u));
            context.SaveChanges();

            var personas = new List<Persona> {
                new Persona { Nombre = "Lucas", Apellido = "Randisi", FechaNacimiento = DateTime.Now, Email = "lucasrandisi@gmail.com", Telefono = "34144444", TipoPersona = Persona.Rol.Alumno },
                new Persona { Nombre = "Alberto", Apellido = "Fernandez", FechaNacimiento = DateTime.Now, Email = "ff@gmail.com", Telefono = "31322323", TipoPersona = Persona.Rol.Docente },
                 new Persona { Nombre = "Elba", Apellido = "Lazo", FechaNacimiento = DateTime.Now, Email = "el-balazo@gmail.com", Telefono = "31322323", TipoPersona = Persona.Rol.Docente }
            };
            personas.ForEach(p => context.Personas.Add(p));

            var usuarios = new List<Usuario> {
                new Usuario {NombreUsuario = "lucas144", Clave = "1234", Habilitado = true, CambioClave = false,  Persona = personas[0]},
                new Usuario {NombreUsuario = "agusdelm", Clave = "elchicorubio", Habilitado = true, CambioClave = false, Persona = personas[1]},
                new Usuario {NombreUsuario = "tinchopereyra", Clave = "central", Habilitado = true, CambioClave = false,  Persona = personas[2]},
            };
            usuarios.ForEach(u => context.Usuarios.Add(u));
            context.SaveChanges();

            var cursos = new List<Curso>
            {
                new Curso{AnioCalendario = 2019, Cupo = 30, Comision = comisiones[0], BloquesHorarios = bloques, Materia = materias[0] }
            };
            cursos.ForEach(p => context.Cursos.Add(p));
            context.SaveChanges();

            var docentesCursos = new List<DocenteCurso>
            {
                new DocenteCurso{Curso = cursos[0], Docente = personas[2]}
            };
            docentesCursos.ForEach(u => context.DocenteCursos.Add(u));

            var alumnosInscripciones = new List<AlumnoInscripcion>
            {
                new AlumnoInscripcion{Curso = cursos[0], Alumno= personas[0]}
            };
            alumnosInscripciones.ForEach(u => context.AlumnoInscripciones.Add(u));
            context.SaveChanges();
        }
    }
}