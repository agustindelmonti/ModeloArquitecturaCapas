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
    public class DocenteCursoRepository : Repository<DocenteCurso>, IDocenteCursoRepository
    {
        private AcademiaContext db;

        public DocenteCursoRepository(AcademiaContext context) : base(context) {
            db = context;
        }

        public IEnumerable<DocenteCurso> GetAll()
        {
            return db.DocenteCursos.Include(d => d.Curso).ToList();
        }

        public IEnumerable<DocenteCurso> GetAllCursosByDocente(Persona persona)
        {
            return db.DocenteCursos
                .Where(c => c.PersonaID == persona.PersonaID)
                .Include(c => c.Curso)
                .ToList();
        }
    }
}
