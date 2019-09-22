using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia.Models {
    public class DocenteCurso : BusinessEntity {
        // Attributes
        public int DocenteCursoID { get; set; }
        public TipoCargo Cargo { get; set; }


        // Foreign Keys
        public int CursoID { get; set; }
        public int DocenteID { get; set; }


        // Navegation Properties
        public virtual Persona Docente { get; set; }
        public virtual Curso Curso { get; set; }


        public enum TipoCargo {
            Titular, Auxiliar, Ayudante
        }
    }
}
