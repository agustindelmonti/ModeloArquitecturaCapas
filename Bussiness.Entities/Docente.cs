using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class Docente : BusinessEntity
    {
        public int IdCurso { get; set; }
        public int IdDocente { get; set; }
        public TipoCargo Cargo { get; set; }

        public enum TipoCargo
        {
            Titular, Auxiliar, Ayudante
        }
    }
}
