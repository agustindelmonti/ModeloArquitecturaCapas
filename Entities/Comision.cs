using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities {
    public class Comision : BusinessEntity {
        // Attributes
        public int ComisionID { get; set; }
        public string Descripcion { get; set; }
        
        // Foreign Keys
        public int PlanID { get; set; }

        // Navegation Properties
        public virtual ICollection<Curso> Cursos { get; set; }
        public virtual Plan Plan { get; set; }
        public Especialidad Especialidad { get; set; }

    }
}
