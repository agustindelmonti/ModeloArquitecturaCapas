using Entities;
using System.Collections.Generic;

namespace Data.Repositories
{
    public interface IDocenteCursoRepository : IRepository<DocenteCurso>
    {
        IEnumerable<DocenteCurso> GetAll();
    }
}