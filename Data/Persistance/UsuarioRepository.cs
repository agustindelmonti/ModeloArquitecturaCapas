using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Persistence;
using Entities;
using System;

namespace Data.Repositories
{
    public class UsuarioRepository : Repository<Usuario>, IUsuarioRepository
    {
        private AcademiaContext db;

        public UsuarioRepository(AcademiaContext context) : base(context) {
            db = context;
        }

        public IEnumerable<Usuario> GetAll()
        {
            return db.Usuarios.Include(u => u.Persona).ToList();
        }

        public Usuario FindByUsernameAndPassword(string nombreUsuario, string clave) {
            return db.Usuarios
                        .Where(u => u.NombreUsuario == nombreUsuario && u.Clave == clave)
                        .FirstOrDefault();
        }
    }
}
