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
    public class ModuloRepository : Repository<Modulo>, IModuloRepository
    {
        private AcademiaContext db;

        public ModuloRepository(AcademiaContext context) : base(context) {
            db = context;
        }

        public IEnumerable<Modulo> GetAll()
        {
            return db.Modulos.ToList();
        }
    }
}
