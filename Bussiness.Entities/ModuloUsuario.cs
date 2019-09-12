﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class ModuloUsuario : BusinessEntity
    {
        public Usuario Usuario { get; set; }
        public Modulo Modulo { get; set; }
        public bool PermiteBaja { get; set; }
        public bool PermiteModificacion { get; set; }
        public bool PermiteAlta { get; set; }
        public bool PermiteConsulta { get; set; }

    }
}
