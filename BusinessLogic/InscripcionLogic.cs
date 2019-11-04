using Data;
using Data.Persistance;
using Data.Repositories;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic {
    public class InscripcionLogic
    {
        public IInscripcionRepository InscripcionRepository { get; set; }
        private readonly ContextUnit Context;

        public InscripcionLogic()
        {
            Context = ContextUnit.Unit;
            InscripcionRepository = Context.InscripcionRepository;
        }

        public IEnumerable<AlumnoInscripcion> GetInscripcionesWithCursoAndPersona() {
            return InscripcionRepository.GetInscripcionesWithCursoAndPersona();
        }

        public AlumnoInscripcion Find(int? id) => InscripcionRepository.GetById(id);

        public void Add(AlumnoInscripcion inscripcion) => InscripcionRepository.Add(inscripcion);

        public void Update(AlumnoInscripcion inscripcion) => InscripcionRepository.Update(inscripcion);

        public IEnumerable<AlumnoInscripcion> FindInscripcionesByCursoIDAndPersonaID(int cursoID, int docenteID) {
            return InscripcionRepository.FindInscripcionesByCursoIDAndPersonaID(cursoID, docenteID);
        }

        public void Remove(int id) => InscripcionRepository.Delete(id);

        public IEnumerable<AlumnoInscripcion> FindInscripcionesByPersonaID(int personaID) {
            return InscripcionRepository.FindInscripcionesByPersonaID(personaID);
        }

        public void InscribirAlumno(int personaID, int cursoID) {
            AlumnoInscripcion alumnoInscripcion = new AlumnoInscripcion();
            alumnoInscripcion.Curso = Context.CursoRepository.GetOne(cursoID);
            alumnoInscripcion.Persona = Context.PersonaRepository.GetById(personaID); 
            alumnoInscripcion.Condicion = AlumnoInscripcion.Estado.Cursando;
            InscripcionRepository.Add(alumnoInscripcion);
        }

        public void AsignarNotas(IEnumerable<AlumnoInscripcion> inscripciones) {
            foreach(AlumnoInscripcion inscripcion in inscripciones) {
                InscripcionRepository.AsignarNotas(inscripcion);
            }
        }

        public IEnumerable<AlumnoInscripcion> FindInscripcionesByCursoID(int cursoID)
        {
            return InscripcionRepository.FindInscripcionesByCursoID(cursoID);
        }
        
    }
}

