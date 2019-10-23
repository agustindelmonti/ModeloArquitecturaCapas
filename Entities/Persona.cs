using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities {
    public class Persona : BusinessEntity {   
        // Atribute
        public int PersonaID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int Legajo { get; set; }
        public Rol TipoPersona { get; set; }


        // Foreign Key
        public int ? PlanID { get; set; }           // Nullable to avoid circular cascade


        // Navegation Properties
        public virtual Plan Plan { get; set; }
        public virtual ICollection<AlumnoInscripcion> AlumnoInscripciones { get; set; }
        public virtual ICollection<DocenteCurso> CursosDelDocente { get; set; }
        
     
        public enum Rol {
            Alumno, Docente, No_Docente
        }
    }
}
