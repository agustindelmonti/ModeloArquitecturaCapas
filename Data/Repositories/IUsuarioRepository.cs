using Entities;
using System.Collections.Generic;

namespace Data.Repositories
{
    public interface IUsuarioRepository : IRepository<Usuario>
    {
        IEnumerable<Usuario> GetAll();
        Usuario FindByUsernameAndPassword(string nombreUsuario, string clave);
        Persona GetPersonaByUserID(int userID);
    }
}