using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities {
    public class ModuloUsuario : BusinessEntity {
        // Attributes
        public int ModuloUsuarioID { get; set; }
        public bool PermiteBaja { get; set; }
        public bool PermiteModificacion { get; set; }
        public bool PermiteAlta { get; set; }
        public bool PermiteConsulta { get; set; }

        // Foreign Keys
        public int UsuarioID { get; set; }
        public int ModuloID { get; set; }

        // Navegation Properties
        public virtual Usuario Usuario { get; set; }
        public virtual Modulo Modulo { get; set; }

    }
}
