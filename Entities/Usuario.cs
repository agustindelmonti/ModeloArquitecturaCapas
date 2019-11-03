using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities {
    public class Usuario {
        // Attributes
        public int UsuarioID { get; set; }
        [Required, StringLength(20)]
        public string NombreUsuario { get; set; }
        [Required, StringLength(20), DataType(DataType.Password)]
        public string Clave { get; set; }
        [Required]
        public bool Habilitado { get; set; }
        [Required]
        public bool CambioClave { get; set; }

        // Foreign Keys
        public int PersonaID { get; set; }


        // Navegation Propierties
        public virtual Persona Persona { get; set; }

    }
}
