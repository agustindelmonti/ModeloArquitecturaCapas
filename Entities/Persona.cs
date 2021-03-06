﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities {
    public class Persona  {   
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
        [DataType(DataType.Date), Display(Name = "Fecha de Nacimiento"),DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime FechaNacimiento { get; set; }
        public int Legajo { get; set; }
        [Required, EnumDataType(typeof(Rol))]
        public Rol TipoPersona { get; set; }
        [Required, Validations.RolRange, Display(Name = "Rol")]
        public string Role { get; set; }

        public string NombreApellido { get => Nombre + " " + Apellido; }

        // Foreign Key
        public int ? PlanID { get; set; }           // Nullable to avoid circular cascade


        // Navegation Properties
        public virtual Plan Plan { get; set; }
        public virtual Usuario Usuario { get; set; }
        public virtual ICollection<AlumnoInscripcion> AlumnoInscripciones { get; set; }
        public virtual ICollection<DocenteCurso> CursosDelDocente { get; set; }

        public enum Rol {
            Alumno, Docente, No_Docente
        }

        //Roles de acceso 
        public static string[] Roles =
        {
            "Alumno", "Docente", "No Docente"
        };
    }
}
