using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities {
    public class AlumnoInscripcion : BusinessEntity {
        // Attributes
        public int AlumnoInscripcionID { get; set; }
        public string Condicion { get; set; }
        public int Nota { get; set; }

        // Foreign Keys
        public int AlumnoID { get; set; }
        public int CursoID { get; set; }

        // Navegation Properties
        public virtual Persona Alumno { get; set; }
        public virtual Curso Curso { get; set; }
    }
}
