using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities {
    public class DocenteCurso  {
        // Attributes
        public int DocenteCursoID { get; set; }
        [EnumDataType(typeof(TipoCargo))]
        public TipoCargo Cargo { get; set; }


        // Foreign Keys
        public int CursoID { get; set; }
        public int PersonaID { get; set; }


        // Navegation Properties
        public virtual Persona Docente { get; set; }
        public virtual Curso Curso { get; set; }


        public enum TipoCargo {
            Titular, Auxiliar, Ayudante
        }
    }
}
