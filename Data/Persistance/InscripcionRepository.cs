using Data.Persistence;
using Data.Repositories;
using Entities;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace Data.Persistance
{
    public class InscripcionRepository : Repository<AlumnoInscripcion>, IInscripcionRepository
    {
        private AcademiaContext db;

        public InscripcionRepository(AcademiaContext context) : base(context)
        {
            db = context;
        }

        public IEnumerable<AlumnoInscripcion> GetInscripcionesWithCursoAndPersona()
        {
            return db.AlumnoInscripciones.Include(a => a.Curso).Include(a => a.Persona).ToList();
        }

        public object GetInscripcionesByPersona(Persona persona) {
            return db.AlumnoInscripciones.Where(i => i.Persona.PersonaID == persona.PersonaID);
                                  
        }
    }
}
