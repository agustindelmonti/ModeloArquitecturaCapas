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
        public ICursoRepository CursoRepository { get; set; }
        private readonly ContextUnit Context;

        public CursoLogic()
        {
            Context = ContextUnit.Unit;
            CursoRepository = Context.CursoRepository;
        }
    

        public IEnumerable<Persona> GetDocentesCurso(Curso curso) => CursoRepository.GetDocentesCurso(curso);

        public IEnumerable<DocenteCurso> GetAllCursosActualesByProfesor(Persona persona)
        {
            IEnumerable<DocenteCurso> CursosDocente = Context.DocenteCursoRepository.GetAllCursosByDocente(persona);

            return CursosDocente.Where(c => c.Curso.AnioCalendario == DateTime.Now.Year).ToList();
        }

        //CRUD
        public IEnumerable<Curso> GetAll() => CursoRepository.GetAll();

        public Curso Find(int? id) => CursoRepository.GetById(id);

        public IEnumerable<Curso> FilterByAnioCalendario(IEnumerable<Curso> cursos, string año) {
            return cursos.Where(c => c.AnioCalendario.ToString().StartsWith(año));
        }

        public IEnumerable<Curso> FindCursosActualesDocenteByPersonaID(int personaID) {
            return CursoRepository.FindCursosActualesDocenteByPersonaID(personaID);
        }

        public IEnumerable<Curso> FindCursosActualesAlumnoByPersonaID(int personaID)
        {
            return CursoRepository.FindCursosActualesAlumnoByPersonaID(personaID);
        }


        public IEnumerable<Curso> FilterByNombreMateria(IEnumerable<Curso> cursos, string materia) {
            return cursos.Where(c => c.Materia.Descripcion.ToLower().Contains(materia.ToLower()));
        }

        public IEnumerable<Curso> FindCursosActualesByPersonaID(int personaID)
        {
            return CursoRepository.FindCursosActualesByPersonaID(personaID);
        }

        public IEnumerable<Curso> FindCursosHabilitadosByPersonaID(int personaID)
        {

            IEnumerable<Curso> cursosInscriptos = CursoRepository.FindCursosInscriptosByPersonaID(personaID);
            IEnumerable<Curso> cursosPlan = CursoRepository.FindCursosFromPlanByPersonaID(personaID);

            IEnumerable<Curso> cursosNoInscriptos = cursosPlan.Except(cursosInscriptos);

            return cursosNoInscriptos.Where(c => c.AlumnosInscripciones.Count() < c.Cupo).ToList();
        }

        public void Add(Curso curso) => CursoRepository.Add(curso);

        public void Update(Curso curso) => CursoRepository.Update(curso);

        public void Delete(int id) => CursoRepository.Delete(id);

        public void DeleteRange(List<Curso> cursos) => CursoRepository.DeleteRange(cursos);
    }
}
