using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities {
    public class Curso  {
        // Attributes
        public int CursoID { get; set; }
        public int AnioCalendario { get; set; }
        public int Cupo { get; set; }

        // Foreign Keys
        public int MateriaID { get; set; }

        // Navegation Properties
        public virtual Materia Materia { get; set; }
        public virtual ICollection<DocenteCurso> DocentesDelCurso { get; set; }
        public virtual ICollection<AlumnoInscripcion> AlumnosInscripciones { get; set; }

    }
}
