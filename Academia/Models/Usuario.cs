using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia.Models {
    public class Usuario : BusinessEntity {
        // Attributes
        public int UsuarioID { get; set; }
        public string NombreUsuario { get; set; }
        public string Clave { get; set; }
        public bool Habilitado { get; set; }
        public bool CambioClave;

        // Foreign Keys
        public int PersonaID { get; set; }


        // Navegation Propierties
        public virtual Persona Persona { get; set; }
        public virtual ICollection<ModuloUsuario> ModuloUsuario { get; set; }

    }
}
