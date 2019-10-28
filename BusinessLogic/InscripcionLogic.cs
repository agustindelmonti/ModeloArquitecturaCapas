using Data;
using Data.Persistance;
using Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class InscripcionLogic
    {
        public InscripcionRepository CursoRepository { get; set; }
        private readonly AcademiaContext Context;

        public InscripcionLogic()
        {
            Context = new AcademiaContext();
            CursoRepository = new InscripcionRepository(Context);
        }
    }
}
