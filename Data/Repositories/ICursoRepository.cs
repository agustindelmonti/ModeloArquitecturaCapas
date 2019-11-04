using System;
using System.Collections.Generic;
using Entities;

namespace Data.Repositories
{
    public interface ICursoRepository : IRepository<Curso>
    {
        IEnumerable<Curso> GetAll();

        IEnumerable<Persona> GetDocentesCurso(Curso curso);

        IEnumerable<Persona> GetAlumnosInscriptosCurso(Curso curso);

        IEnumerable<Curso> FindCursosActualesByPersonaID(int personaID);

        IEnumerable<Curso> FindCursosInscriptosByPersonaID(int personaID);

        IEnumerable<Curso> FindCursosFromPlanByPersonaID(int personaID);

        IEnumerable<Curso> FindCursosActualesDocenteByPersonaID(int personaID);

        IEnumerable<Curso> FindCursosActualesAlumnoByPersonaID(int personaID);
        
    }
}
