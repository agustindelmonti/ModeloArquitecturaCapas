using Entities;
using System.Collections.Generic;

namespace Data.Repositories
{
    interface IModuloUsuarioRepository : IRepository<ModuloUsuario>
    {
        IEnumerable<ModuloUsuario> GetAll();
    }
}