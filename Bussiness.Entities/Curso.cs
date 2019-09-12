﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class Curso : BusinessEntity
    {
        public int AnioCalendario { get; set; }
        public int Cupo { get; set; }
        public Comision Comision { get; set; }
        public Materia Materia{ get; set; }
        public string Descripcion { get; set; }

    }
}
