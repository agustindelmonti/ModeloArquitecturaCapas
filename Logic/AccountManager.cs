using Data.Repository;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic {
    public class AccountManager {
        public bool ValidateUser(Usuario usuario) {
            UsuarioRepository userRep = new UsuarioRepository();
            Usuario userResult = userRep.FindByUsernameAndPassword(usuario.NombreUsuario, usuario.Clave);

            return userResult != null;
        }
    }
}
