﻿using Data.Persistence;
using Data.Repositories;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Persistance
{
    public class InscripcionRepository : Repository<AlumnoInscripcion>, IInscripcionRepository
    {
        private AcademiaContext db;

        public InscripcionRepository(AcademiaContext context) : base(context)
        {
            db = context;
        }
    }
}