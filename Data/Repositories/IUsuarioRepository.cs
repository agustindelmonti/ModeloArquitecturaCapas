using Entities;
using System.Collections.Generic;

namespace Data.Repositories
{
    interface IUsuarioRepository : IRepository<Usuario>
    {
        IEnumerable<Usuario> GetAll();
    }
}