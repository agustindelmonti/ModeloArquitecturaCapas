﻿using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    interface IMateriaRepository : IRepository<Materia>
    {
        IEnumerable<Materia> GetAll();
    }
}