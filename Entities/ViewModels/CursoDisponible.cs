using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.ViewModels {
    public class CursoDisponible {
        public Curso Curso { get; set; }
        public string NombreMateria { get; set; }
        public string NroComision { get; set; }
        public string Titular { get; set; }
        public string Auxiliar { get; set; }
        public string Ayudante { get; set; }
    }
}
