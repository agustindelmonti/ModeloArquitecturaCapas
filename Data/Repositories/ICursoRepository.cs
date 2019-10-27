using System;
using System.Collections.Generic;
using Entities;

namespace Data.Repositories
{
    interface ICursoRepository : IRepository<Curso>
    {
        IEnumerable<Curso> GetAll();
    }
}
