using Entities;
using System.Collections.Generic;

namespace Data.Repositories
{
    interface IModuloRepository : IRepository<Modulo>
    {
        IEnumerable<Modulo> GetAll();
    }
}