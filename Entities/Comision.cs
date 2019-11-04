using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities {
    public class Comision {
        // Attributes
        public int ComisionID { get; set; }
        [Required, Display(Name = "Número de comisión")]
        public string Descripcion { get; set; }
        [Range(1,5), Display(Name = "Año")]
        public int AnioEspecialidad { get; set; }
        
        // Foreign Keys
        public int PlanID { get; set; }

        // Navegation Properties
        public virtual ICollection<Curso> Cursos { get; set; }
        public virtual Plan Plan { get; set; }
        
    }
}
