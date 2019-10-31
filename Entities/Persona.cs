using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities {
    public class Persona : BusinessEntity {   
        // Atribute
        public int PersonaID { get; set; }
        [Required, StringLength(20)]
        public string Nombre { get; set; }
        [Required, StringLength(20)]
        public string Apellido { get; set; }
        [Required, StringLength(20)]
        public string Direccion { get; set; }
        [Required, EmailAddress]
        public string Email { get; set; }
        [Required, StringLength(20)]
        public string Telefono { get; set; }
        [Required, DataType(DataType.Date), Display(Name = "Fecha de Nacimiento")]
        public DateTime FechaNacimiento { get; set; }
        public int Legajo { get; set; }
        [Required, EnumDataType(typeof(Rol))]
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
