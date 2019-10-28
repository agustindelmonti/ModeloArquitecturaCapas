using Entities;
using System.Collections.Generic;

namespace Data.Repositories
{
    interface IDocenteCursoRepository : IRepository<DocenteCurso>
    {
        IEnumerable<DocenteCurso> GetAll();
    }
}