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
    public class PersonaRepository : Repository<Persona>, IPersonaRepository
    {
        private AcademiaContext db;

        public PersonaRepository(AcademiaContext context) : base(context) {
            db = context;
        }

        public IEnumerable<Persona> GetAll()
        {
            return db.Personas.ToList();
        }
    }
}
