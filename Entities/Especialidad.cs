using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities {
    public class Especialidad : BusinessEntity {
        // Attributes
        public int EspecialidadID { get; set; }
        public string Descripcion { get; set; }
        public string Alias { get; set; }

        // Navegation Properties
        public virtual ICollection<Materia> Materias { get; set; }
    }
}
