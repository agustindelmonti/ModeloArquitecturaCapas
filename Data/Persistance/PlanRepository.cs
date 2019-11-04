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
    public class PlanRepository : Repository<Plan>, IPlanRepository
    {
        private AcademiaContext db;

        public PlanRepository(AcademiaContext context) : base(context) {
            db = context;
        }

        public IEnumerable<Plan> GetAll()
        {
            return db.Planes.Include(p => p.Especialidad).ToList();
        }

        public List<Plan> GetAllByEspecialidad(Especialidad especialidad)
        {
            return db.Planes
                .Where(p => p.Especialidad.EspecialidadID == especialidad.EspecialidadID)
                .Include(p => p.Comisiones)
                .Include(p => p.Materias)
                .ToList();
        }
    }
}
