using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia.Models {
    public class Plan : BusinessEntity {
        // Attributes
        public int PlanID { get; set; }
        public string Descripcion { get; set; }
        
        // Foreign Keys
        public int EspecialidadID { get; set; }

        // Navegation Properties
        public virtual ICollection<Persona> Personas { get; set; }
        public virtual Especialidad Especialidad { get; set; }
        public virtual ICollection<Materia> Materias { get; set; }

    }
}
