using Data.Persistence;
using Data.Repositories;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Data.Entity;

namespace Data.Persistance
{
    public class MateriaRepository : Repository<Materia>, IMateriaRepository
    {
        private AcademiaContext db;

        public MateriaRepository(AcademiaContext context) : base(context)
        {
            db = context;
        }

        public IEnumerable<Materia> GetAll()
        {
            return db.Materias.Include(m => m.Plan);
        }

    }
}
