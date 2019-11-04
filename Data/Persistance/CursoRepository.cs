using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Persistence;
using Entities;
using System;

namespace Data.Repositories
{
    public class CursoRepository : Repository<Curso>, ICursoRepository
    {
        private AcademiaContext db;

        public CursoRepository(AcademiaContext context) : base(context) {
            db = context;
        }

        public IEnumerable<Curso> GetAll()
        {
            return db.Cursos.Include(c => c.Materia).ToList();
        }

        public Curso Find(int? id) => db.Cursos.Find(id);

        public IEnumerable<Persona> GetDocentesCurso(Curso curso)
        {
            return db.Personas.Where(c => c.CursosDelDocente == curso).ToList();
        }

        public IEnumerable<Persona> GetAlumnosInscriptosCurso(Curso curso)
        {
            return db.Personas.Where(c => c.AlumnoInscripciones == curso).ToList();
        }

        public IEnumerable<Curso> FindCursosInscriptosByPersonaID(int personaID) {
            return db.Cursos.Where(c => c.AlumnosInscripciones.Where(a => a.Persona.PersonaID == personaID).FirstOrDefault() != null);
        }

        public IEnumerable<Curso> FindCursosActualesDocenteByPersonaID(int personaID) {
            return db.Cursos.Where(c => c.DocentesDelCurso.Where(d => d.PersonaID == personaID).FirstOrDefault() != null).Include(c => c.Materia).Include(c => c.Comision);
        }

        public IEnumerable<Curso> FindCursosFromPlanByPersonaID(int personaID) {
            return db.Cursos.Where(c => c.Materia.Plan.Personas.Where(p => p.PersonaID == personaID).FirstOrDefault() != null);
        }

        public IEnumerable<Curso> FindCursosActualesAlumnoByPersonaID(int personaID) {
            return db.Cursos.Where(c => c.AlumnosInscripciones.Where(i => i.Persona.PersonaID == personaID && i.Condicion == AlumnoInscripcion.Estado.Cursando).FirstOrDefault() != null).Include(c => c.Materia).Include(c => c.Comision);
        }

        public IEnumerable<Curso> FindCursosActualesByPersonaID(int personaID)
        {
            throw new NotImplementedException();
        }
    }
}
