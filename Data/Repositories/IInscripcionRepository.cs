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
        IEnumerable<AlumnoInscripcion> FindInscripcionesByCursoIDAndPersonaID(int cursoID,int personaID);
        IEnumerable<AlumnoInscripcion> FindInscripcionesByCursoID(int cursoID);
        public void AsignarNotas(AlumnoInscripcion inscripcion);
    }
}
