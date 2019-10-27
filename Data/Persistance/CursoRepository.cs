using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Persistence;
using Entities;

namespace Data.Repositories
{
    public class CursoRepository : Repository<Curso>, ICursoRepository
    {
        public CursoRepository(AcademiaContext context) : base(context) { }

        public AcademiaContext CursoContext { get; set; }

        public IEnumerable<Curso> GetAll()
        {
            return CursoContext.Cursos.ToList();
        }
    }
}
