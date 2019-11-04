
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities {
    public class AlumnoInscripcion {
        // Attributes
        public int AlumnoInscripcionID { get; set; }

        [Required, EnumDataType(typeof(Estado))]
        public Estado Condicion { get; set; }

        [Range(1,10)]
        public int Nota { get; set; }

        // Foreign Keys
        public int PersonaID { get; set; }
        public int CursoID { get; set; }

        // Navegation Properties
        [Required]
        public virtual Persona Persona { get; set; }
        [Required]
        public virtual Curso Curso { get; set; }

        public enum Estado {
            Inscrito, Cursando, Regular, Aprobado, Libre
        }
    }
}
