using Entities;
using System.Collections.Generic;

namespace Data.Repositories
{
    public interface IModuloUsuarioRepository : IRepository<ModuloUsuario>
    {
        IEnumerable<ModuloUsuario> GetAll();
    }
}