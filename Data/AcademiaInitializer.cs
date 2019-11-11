using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Entities;


namespace Data {
    public class AcademiaInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<AcademiaContext> {
        protected override void Seed(AcademiaContext context) {

            var especialidades = new List<Especialidad> {
                new Especialidad {Descripcion = "ISI"},
                new Especialidad {Descripcion = "IQ"},
                new Especialidad {Descripcion = "IE"},
                new Especialidad {Descripcion = "IC"},
                new Especialidad {Descripcion = "IM"}
            };

            especialidades.ForEach(e => context.Especialidades.Add(e));
            context.SaveChanges();


            var planes = new List<Plan> {
                new Plan {Descripcion = "2008 ISI", EspecialidadID = 1},
                new Plan {Descripcion = "2008 IQ", EspecialidadID = 2},
                new Plan {Descripcion = "2019 IQ", EspecialidadID = 2},
                new Plan {Descripcion = "2019 ISI", EspecialidadID = 1},
                new Plan {Descripcion = "2008 IM", EspecialidadID = 5},
                new Plan {Descripcion = "2008 IC", EspecialidadID = 4},
            };

            planes.ForEach(p => context.Planes.Add(p));
            context.SaveChanges();


            var personas = new List<Persona> {
                new Persona { Nombre = "Lucas", Apellido = "Randisi", Direccion = "Valle 1234", Email = "lucasrandisi@gmail.com", Telefono = "34144444", FechaNacimiento = DateTime.ParseExact("09-10-1997", "dd-MM-yyyy",System.Globalization.CultureInfo.InvariantCulture), Legajo = 44464, TipoPersona = Persona.Rol.Alumno, Role = "Alumno", PlanID = 1 },
                new Persona { Nombre = "Juan", Apellido = "Alberto", Direccion = "Mendoza 5590", Email = "juanalberto@gmail.com", Telefono = "1617486", FechaNacimiento = DateTime.ParseExact("28-02-1998", "dd-MM-yyyy",System.Globalization.CultureInfo.InvariantCulture), Legajo = 45895,TipoPersona = Persona.Rol.Alumno, Role = "Alumno",PlanID = 1 },
                new Persona { Nombre = "Maria", Apellido = "Del Carmen", Direccion = "Zeballos 220", Email = "mari_nob_78@gmail.com", Telefono = "6262256", FechaNacimiento = DateTime.ParseExact("15-07-1997", "dd-MM-yyyy",System.Globalization.CultureInfo.InvariantCulture), Legajo = 44236,TipoPersona = Persona.Rol.Alumno, Role = "Alumno", PlanID = 1 },
                new Persona { Nombre = "Julia", Apellido = "Pellegrini", Direccion = "Crespo 2000", Email = "medicenjuli@gmail.com", Telefono = "3365652", FechaNacimiento = DateTime.ParseExact("12-12-1963", "dd-MM-yyyy",System.Globalization.CultureInfo.InvariantCulture), Legajo = 45895, TipoPersona = Persona.Rol.Docente,Role = "Docente", PlanID = 1},
                new Persona { Nombre = "Matematico", Apellido = "Flaminetti", Direccion = "Pte Roca 411", Email = "flaminetti-el-de-mat@gmail.com", Telefono = "46564961", FechaNacimiento = DateTime.ParseExact("07-09-1971", "dd-MM-yyyy",System.Globalization.CultureInfo.InvariantCulture), Legajo = 45895,TipoPersona = Persona.Rol.Docente, Role = "Docente"},
                new Persona { Nombre = "Matt", Apellido = "Enme P. Orfavor", Direccion = "Av Siempre Viva 222", Email = "Matt.enme@gmail.com", Telefono = "4684961", FechaNacimiento = DateTime.ParseExact("01-01-1970", "dd-MM-yyyy",System.Globalization.CultureInfo.InvariantCulture), Legajo = 45222,TipoPersona = Persona.Rol.No_Docente, Role = "No Docente"},
                new Persona { Nombre = "Agustin", Apellido = "Delmonti", Direccion = "Algunl Ado", Email = "agus@gmail.com", Telefono = "23344444", FechaNacimiento = DateTime.ParseExact("28-02-1998", "dd-MM-yyyy",System.Globalization.CultureInfo.InvariantCulture), Legajo = 44411, TipoPersona = Persona.Rol.Alumno, Role = "Alumno", PlanID = 1 },
                new Persona { Nombre = "Guido", Apellido = "Lorenzotti", Direccion = "Calle Falsa", Email = "guidoloo@gmail.com", Telefono = "33644444", FechaNacimiento = DateTime.ParseExact("09-11-1999", "dd-MM-yyyy",System.Globalization.CultureInfo.InvariantCulture), Legajo = 45678, TipoPersona = Persona.Rol.Alumno, Role = "Alumno", PlanID = 1 },
                new Persona { Nombre = "Samuel", Apellido = "Metodo Euler", Direccion = "Calle Falsa", Email = "metodoeuler@gmail.com", Telefono = "11221444", FechaNacimiento = DateTime.ParseExact("09-11-1988", "dd-MM-yyyy",System.Globalization.CultureInfo.InvariantCulture), Legajo = 45678, TipoPersona = Persona.Rol.Docente, Role = "Docente", PlanID = 1 },
                new Persona { Nombre = "Roman", Apellido = "Castillo", Direccion = "San Juan 411", Email = "llegoRomanElPrece@gmail.com", Telefono = "4684961", FechaNacimiento = DateTime.ParseExact("07-09-1971", "dd-MM-yyyy",System.Globalization.CultureInfo.InvariantCulture), Legajo = 45895,TipoPersona = Persona.Rol.Docente, Role = "Docente"},
            };

            personas.ForEach(p => context.Personas.Add(p));
            context.SaveChanges();

            var usuarios = new List<Usuario> {
                new Usuario {NombreUsuario = "lucas144", Clave = "1234", Habilitado = true, CambioClave = false, UsuarioID = 1},
                new Usuario {NombreUsuario = "juanAlb", Clave = "soyalbert", Habilitado = true, CambioClave = false, UsuarioID = 2},
                new Usuario {NombreUsuario = "maridelc", Clave = "ninombre", Habilitado = true, CambioClave = false, UsuarioID = 3},
                new Usuario {NombreUsuario = "juliapell", Clave = "laseñora", Habilitado = true, CambioClave = false, UsuarioID = 4},
                new Usuario {NombreUsuario = "flamin", Clave = "go", Habilitado = true, CambioClave = false, UsuarioID = 5},
                new Usuario {NombreUsuario = "matt_enme", Clave = "porfavor", Habilitado = true, CambioClave = false, UsuarioID = 6},
                new Usuario {NombreUsuario = "agus", Clave = "dd", Habilitado = true, CambioClave = false, UsuarioID = 7},
                new Usuario {NombreUsuario = "guidoloo", Clave = "111", Habilitado = true, CambioClave = false, UsuarioID = 8},
                new Usuario {NombreUsuario = "matt_enme", Clave = "porfavor", Habilitado = true, CambioClave = false, UsuarioID = 10}
            };

            usuarios.ForEach(u => context.Usuarios.Add(u));
            context.SaveChanges();



            var materias = new List<Materia> {
                new Materia {Descripcion = "Analisis Mat. I", HsSemanales = 3, HsTotales = 33, PlanID = 1},
                new Materia {Descripcion = "Analisis Mat. II", HsSemanales = 3, HsTotales = 33, PlanID = 1},
                new Materia {Descripcion = "Paradigmas", HsSemanales = 3, HsTotales = 33, PlanID = 1},
                new Materia {Descripcion = "Quimica Organica", HsSemanales = 3, HsTotales = 33, PlanID = 2},
                new Materia {Descripcion = "Analisis Mat. I", HsSemanales = 3, HsTotales = 33, PlanID = 2},
                new Materia {Descripcion = "Mat. Superior", HsSemanales = 4, HsTotales = 44, PlanID = 2},
                new Materia {Descripcion = "Economia", HsSemanales = 3, HsTotales = 33, PlanID = 1},
                new Materia {Descripcion = "Legislacion", HsSemanales = 3, HsTotales = 33, PlanID = 1},
                new Materia {Descripcion = "Mat. Superior", HsSemanales = 3, HsTotales = 33, PlanID = 1},
                new Materia {Descripcion = "Diseño Sistemas", HsSemanales = 3, HsTotales = 33, PlanID = 1}
            };

            materias.ForEach(m => context.Materias.Add(m));
            context.SaveChanges();

            var comisiones = new List<Comision> {
                new Comision {Descripcion = "302", AnioEspecialidad = 3, PlanID = 1},
                new Comision {Descripcion = "404", AnioEspecialidad = 4, PlanID = 2},
                new Comision {Descripcion = "201", AnioEspecialidad = 2, PlanID = 1},
                new Comision {Descripcion = "101", AnioEspecialidad = 1, PlanID = 1},
                new Comision {Descripcion = "301", AnioEspecialidad = 3, PlanID = 1},
                new Comision {Descripcion = "102", AnioEspecialidad = 1, PlanID = 1},
            };

            comisiones.ForEach(c => context.Comisiones.Add(c));
            context.SaveChanges();

            var cursos = new List<Curso> {
                new Curso {AnioCalendario = 2019, Cupo = 10, MateriaID = 1, ComisionID = 4},
                new Curso {AnioCalendario = 2016, Cupo = 50, MateriaID = 2, ComisionID = 3},
                new Curso {AnioCalendario = 2019, Cupo = 10, MateriaID = 3, ComisionID = 3},
                new Curso {AnioCalendario = 2016, Cupo = 50, MateriaID = 4, ComisionID = 2},
                new Curso {AnioCalendario = 2019, Cupo = 10, MateriaID = 5, ComisionID = 2},
                new Curso {AnioCalendario = 2016, Cupo = 50, MateriaID = 6, ComisionID = 1},
                new Curso {AnioCalendario = 2019, Cupo = 10, MateriaID = 7, ComisionID = 1},
                new Curso {AnioCalendario = 2019, Cupo = 10, MateriaID = 3, ComisionID = 1},
                new Curso {AnioCalendario = 2019, Cupo = 10, MateriaID = 1, ComisionID = 2},
                new Curso {AnioCalendario = 2019, Cupo = 10, MateriaID = 8, ComisionID = 1},
                new Curso {AnioCalendario = 2019, Cupo = 10, MateriaID = 9, ComisionID = 1},
                new Curso {AnioCalendario = 2019, Cupo = 10, MateriaID = 10, ComisionID = 1}
            };

            cursos.ForEach(c => context.Cursos.Add(c));
            context.SaveChanges();



            var inscripciones = new List<AlumnoInscripcion> {
                //new AlumnoInscripcion {Condicion = AlumnoInscripcion.Estado.Cursando, PersonaID = 1, CursoID = 1},
                new AlumnoInscripcion {Condicion = AlumnoInscripcion.Estado.Cursando, PersonaID = 1, CursoID = 2},
                //new AlumnoInscripcion {Condicion = AlumnoInscripcion.Estado.Aprobado, PersonaID = 1, CursoID = 3}
            };
            inscripciones.ForEach(a => context.AlumnoInscripciones.Add(a));
            context.SaveChanges();



            var docentesCursos = new List<DocenteCurso> {
                new DocenteCurso { PersonaID = 4, CursoID = 7},
                new DocenteCurso { PersonaID = 4, CursoID = 10},
                new DocenteCurso { PersonaID = 5, CursoID = 1},
                new DocenteCurso { PersonaID = 5, CursoID = 2, Cargo = DocenteCurso.TipoCargo.Ayudante},
                new DocenteCurso { PersonaID = 5, CursoID = 5, Cargo = DocenteCurso.TipoCargo.Auxiliar},
                new DocenteCurso { PersonaID = 5, CursoID = 6},
                new DocenteCurso { PersonaID = 9, CursoID = 1, Cargo = DocenteCurso.TipoCargo.Auxiliar},
                new DocenteCurso { PersonaID = 10, CursoID = 1, Cargo = DocenteCurso.TipoCargo.Ayudante},
                new DocenteCurso { PersonaID = 5, CursoID = 9},
                new DocenteCurso { PersonaID = 10, CursoID = 9, Cargo = DocenteCurso.TipoCargo.Auxiliar}

            };
            docentesCursos.ForEach(d => context.DocenteCursos.Add(d));
            context.SaveChanges();



        }
    }
}