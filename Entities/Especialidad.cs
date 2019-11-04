using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities {
    public class Especialidad  {
        // Attributes
        public int EspecialidadID { get; set; }
        [Required, StringLength(20), Display(Name = "Nombre")]
        public string Descripcion { get; set; }

        // Navegation Properties
        public virtual ICollection<Plan> Planes { get; set; }


    }
}
