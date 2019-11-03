using Data.Repositories;
using System;
using System.Collections.Generic;
using Entities;
using Data;
using System.Linq;

namespace BusinessLogic
{
    public class CursoLogic
    {
        public CursoRepository CursoRepository { get; set; }
        private readonly AcademiaContext Context;

        public CursoLogic()
        {
            Context = new AcademiaContext();
            CursoRepository = new CursoRepository(Context);
        }

        public IEnumerable<Persona> GetDocentesCurso(Curso curso) => CursoRepository.GetDocentesCurso(curso);

        //CRUD
        public IEnumerable<Curso> GetAll() => CursoRepository.GetAll();

        public Curso Find(int? id) => CursoRepository.Find(id);

        public IEnumerable<Curso> FilterByAnioCalendario(IEnumerable<Curso> cursos, string año) {
            return cursos.Where(c => c.AnioCalendario.ToString().StartsWith(año));
        }

        public IEnumerable<Curso> FilterByNombreMateria(IEnumerable<Curso> cursos, string materia) {
            return cursos.Where(c => c.Materia.Descripcion.ToLower().Contains(materia.ToLower()));
        }

        public void Add(Curso curso) => CursoRepository.Add(curso);

        public void Update(Curso curso) => CursoRepository.Update(curso);


        public IEnumerable<Curso> FindCursosActualesByPersonaID(int personaID) {
            return CursoRepository.FindCursosActualesByPersonaID(personaID);
        }

        public void Delete(int id) => CursoRepository.Delete(id);

        
        public IEnumerable<Curso> FindCursosHabilitadosByPersonaID(int personaID) {
            
            IEnumerable<Curso> cursosInscriptos = CursoRepository.FindCursosInscriptosByPersonaID(personaID);
            IEnumerable<Curso> cursosPlan = CursoRepository.FindCursosFromPlanByPersonaID(personaID);

            IEnumerable<Curso> cursosNoInscriptos = cursosPlan.Except(cursosInscriptos);

            return cursosNoInscriptos.Where(c => c.AlumnosInscripciones.Count() < c.Cupo);
        }
    }
}
