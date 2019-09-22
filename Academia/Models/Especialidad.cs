using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia.Models {
    public class Especialidad : BusinessEntity {
        // Attributes
        public int EspecialidadID { get; set; }
        public string Descripcion { get; set; }

        // Navegation Properties
        public virtual ICollection<Plan> Planes { get; set; }
    }
}
