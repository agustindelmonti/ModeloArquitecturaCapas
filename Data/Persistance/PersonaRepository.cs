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
            return db.Personas.Include(p => p.Plan).ToList();
        }

        public Persona GetByLegajo(int legajo)
        {
            return db.Personas.Where(p => p.Legajo == legajo).FirstOrDefault();
        }
    }
}
