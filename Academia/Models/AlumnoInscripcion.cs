using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia.Models {
    public class AlumnoInscripcion : BusinessEntity {
        // Attributes
        public int AlumnoInscripcionID { get; set; }
        public string Condicion { get; set; }
        public int Nota { get; set; }

        // Foreign Keys
        public int PersonaID { get; set; }
        public int CursoID { get; set; }

        // Navegation Properties
        public virtual Persona Persona { get; set; }
        public virtual Curso Curso { get; set; }
    }
}
