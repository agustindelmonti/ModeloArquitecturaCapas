using BusinessLogic.Validations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities {
    public class AlumnoInscripcion : BusinessEntity {
        // Attributes
        public int AlumnoInscripcionID { get; set; }
        [CondicionRange]
        public string Condicion { get; set; }
        [Range(1,10)]
        public int Nota { get; set; }

        // Foreign Keys
        public int PersonaID { get; set; }
        public int CursoID { get; set; }

        // Navegation Properties
        public virtual Persona Persona { get; set; }
        public virtual Curso Curso { get; set; }
    }
}
