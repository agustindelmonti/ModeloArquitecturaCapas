using Entities;
using System.Collections.Generic;

namespace Data.Repositories
{
    public interface IModuloRepository : IRepository<Modulo>
    {
        IEnumerable<Modulo> GetAll();
    }
}