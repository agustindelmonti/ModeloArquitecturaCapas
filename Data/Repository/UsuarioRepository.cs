using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository {
    public class UsuarioRepository {
        private AcademiaContext db = new AcademiaContext();

        public Usuario FindByUsernameAndPassword(string username, string password) {
            
            Usuario user = db.Usuarios
                            .Where(u => u.NombreUsuario == username && u.Clave == password)
                            .FirstOrDefault<Usuario>();

            return user;                 
        }


    }
}
