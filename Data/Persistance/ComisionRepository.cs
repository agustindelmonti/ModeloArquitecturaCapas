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
    public class ComisionRepository : Repository<Comision>, IComisionRepository
    {
        private AcademiaContext db;

        public ComisionRepository(AcademiaContext context) : base(context) {
            db = context;
        }

        public IEnumerable<Comision> GetAll()
        {
            return db.Comisiones.Include(c => c.Plan).ToList();
        }

        public List<Comision> GetAllByPlan(Plan plan)
        {
            return db.Comisiones.Where(c => c.Plan.PlanID == plan.PlanID).ToList();
        }
    }
}
