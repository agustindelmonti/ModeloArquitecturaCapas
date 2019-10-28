using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Data.Repositories;
using Data.Persistence;
using Entities;
using System;

namespace Data.Repositories
{
    public class ModuloUsuarioRepository : Repository<ModuloUsuario>, IModuloUsuarioRepository
    {
        private AcademiaContext db;

        public ModuloUsuarioRepository(AcademiaContext context) : base(context) {
            db = context;
        }

        public IEnumerable<ModuloUsuario> GetAll()
        {
            return db.ModuloUsuarios.Include(m => m.Modulo).Include(m => m.Usuario).ToList();
        }
    }
}
