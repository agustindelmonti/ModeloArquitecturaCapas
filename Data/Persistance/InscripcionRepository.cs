using Data.Persistence;
using Data.Repositories;
using Entities;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace Data.Persistance {
    public class InscripcionRepository : Repository<AlumnoInscripcion>, IInscripcionRepository {
        private AcademiaContext db;

        public InscripcionRepository(AcademiaContext context) : base(context) {
            db = context;
        }


        public IEnumerable<Materia> GetMateriasNoAptaInscripcion()
        {
            List<AlumnoInscripcion.Estado> estados = new List<AlumnoInscripcion.Estado>()
            {
                AlumnoInscripcion.Estado.Aprobado,
                AlumnoInscripcion.Estado.Regular,
                AlumnoInscripcion.Estado.Cursando
            };
            List<Materia> materias = db.AlumnoInscripciones
                            .Where(i => estados.Contains(i.Condicion))
                            .Select(i => i.Curso.Materia)
                            .ToList();
            return materias;
        }

        public IEnumerable<AlumnoInscripcion> GetInscripcionesWithCursoAndPersona() {
            return db.AlumnoInscripciones.Include(a => a.Curso).Include(a => a.Persona).ToList();
        }

        public IEnumerable<AlumnoInscripcion> GetInscripcionesByPersonaID(int personaID) {
            return db.AlumnoInscripciones.Where(i => i.Persona.PersonaID == personaID).ToList();

        }

        public IEnumerable<AlumnoInscripcion> FindInscripcionesByPersonaID(int personaID) {
            return db.AlumnoInscripciones
                .Where(i => i.PersonaID == personaID)
                .Include(i => i.Curso.Materia)
                .Include(i => i.Curso.Comision.Plan);
        }

        public IEnumerable<AlumnoInscripcion> FindInscripcionesByCursoIDAndPersonaID(int cursoID, int docenteID) {
            return db.AlumnoInscripciones.Where(i => i.CursoID == cursoID && i.Curso.DocentesDelCurso.Where(d => d.PersonaID == docenteID).FirstOrDefault() != null).Include(i => i.Persona);
        }

        public IEnumerable<AlumnoInscripcion> FindInscripcionesByCursoID(int cursoID) {
            return db.AlumnoInscripciones.Where(i => i.CursoID == cursoID).Include(c => c.Persona);
        }

        public void AsignarNotas(AlumnoInscripcion inscripcion) {
            AlumnoInscripcion insc = db.AlumnoInscripciones.Where(i => i.AlumnoInscripcionID == inscripcion.AlumnoInscripcionID).FirstOrDefault();
            insc.Nota = inscripcion.Nota;
            insc.Calificar();
        }
    }
}