using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities {
    public class Plan  {
        // Attributes
        public int PlanID { get; set; }
        [Required, StringLength(20), Display(Name = "Plan")]
        public string Descripcion { get; set; }
        
        // Foreign Keys
        public int EspecialidadID { get; set; }

        // Navegation Properties
        public virtual ICollection<Comision> Comisiones { get; set; }
        public virtual ICollection<Persona> Personas { get; set; }
        public virtual Especialidad Especialidad { get; set; }
        public virtual ICollection<Materia> Materias { get; set; }

    }
}
