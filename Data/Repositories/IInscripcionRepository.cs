using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public interface IInscripcionRepository : IRepository<AlumnoInscripcion>
    {
        IEnumerable<AlumnoInscripcion> GetInscripcionesWithCursoAndPersona();
        IEnumerable<AlumnoInscripcion> FindInscripcionesByPersonaID(int personaID);
    }
}
