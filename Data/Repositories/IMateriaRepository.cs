using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public interface IMateriaRepository : IRepository<Materia>
    {
        IEnumerable<Materia> GetAll();
        List<Materia> GetAllByPlan(Plan plan);
    }
}
