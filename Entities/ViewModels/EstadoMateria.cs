using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.ViewModels {
    public class EstadoMateria {
        public int AñoEspecialidad { get; set; }
        public string NombreMateria { get; set; }
        public string Condicion { get; set; }
        public int? Nota { get; set; }
        public string NumeroComision { get; set; }
        public int AñoCalendario { get; set; }
        public string Plan { get; set; }
    }
}
