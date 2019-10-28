using System;
using System.Collections.Generic;
using Entities;

namespace Data.Repositories
{
    interface ICursoRepository : IRepository<Curso>
    {
        IEnumerable<Curso> GetAll();

        IEnumerable<Persona> GetDocentesCurso(Curso curso);

        IEnumerable<Persona> GetAlumnosInscriptosCurso(Curso curso);
    }
}
