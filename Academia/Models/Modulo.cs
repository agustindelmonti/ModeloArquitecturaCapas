using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia.Models {
    public class Modulo : BusinessEntity {
        // Attributes
        public int ModuloID { get; set; }
        public string Descripcion { get; set; }
        public string Ejecuta { get; set; }

        // Foreign Keys

        // Navegation Properties
        public virtual ICollection<ModuloUsuario> ModuloUsuario { get; set; }


    }
}
