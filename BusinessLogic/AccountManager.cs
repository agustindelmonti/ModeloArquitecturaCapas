using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Data.Repositories;
using Entities;

namespace BusinessLogic {
    public class AccountManager {
        private IUsuarioRepository usuarioRepository = new UsuarioRepository(new AcademiaContext());

        public bool ValidateUser(Usuario usuario) {
            Usuario usuarioBuscar = usuarioRepository.FindByUsernameAndPassword(usuario.NombreUsuario, usuario.Clave);

            return usuarioBuscar != null;
        }

    }
}
