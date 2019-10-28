using Data;
using Data.Persistance;
using Data.Repositories;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class InscripcionLogic
    {
        public InscripcionRepository InscripcionRepository { get; set; }
        private readonly AcademiaContext Context;

        public InscripcionLogic()
        {
            Context = new AcademiaContext();
            InscripcionRepository = new InscripcionRepository(Context);
        }

        public IEnumerable<AlumnoInscripcion> GetInscripcionesWithCursoAndPersona() {
            return InscripcionRepository.GetInscripcionesWithCursoAndPersona();
        }

        public AlumnoInscripcion Find(int? id) => InscripcionRepository.GetById(id);

        public void Add(AlumnoInscripcion inscripcion) => InscripcionRepository.Add(inscripcion);

        public void Update(AlumnoInscripcion inscripcion) => InscripcionRepository.Update(inscripcion);

        public void Remove(int id) => InscripcionRepository.Delete(id);
    }
}
