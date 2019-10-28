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
    public class EspecialidadRepository : Repository<Especialidad>, IEspecialidadRepository
    {
        private AcademiaContext db;

        public EspecialidadRepository(AcademiaContext context) : base(context) {
            db = context;
        }

        public IEnumerable<Especialidad> GetAll()
        {
            return db.Especialidades.ToList();
        }
    }
}
