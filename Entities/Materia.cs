﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities {
    public class Materia : BusinessEntity {
        // Attributes
        public int MateriaID { get; set; }
        public string Descripcion { get; set; }
        public int HsSemanales { get; set; }
        public int HsTotales { get; set; }

        // Foreign Keys
        public int PlanID { get; set; }

        // Navegation Properties
        public virtual ICollection<Curso> Cursos { get; set; }
        public virtual Plan Plan { get; set; }



    }
}
