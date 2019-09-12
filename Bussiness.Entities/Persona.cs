using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class Persona : BusinessEntity
    {
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public Plan Plan { get; set; }
        public int Legajo { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public Rol TipoPersona { get; set; }

        public enum Rol
        {
            Alumno, Docente, No_Docente
        }
    }
}
