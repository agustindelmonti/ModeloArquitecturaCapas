using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public interface IPersonaRepository : IRepository<Persona>
    {
        IEnumerable<Persona> GetAll();
        Persona GetByLegajo(int legajo);
    }
}
