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
    }
}
