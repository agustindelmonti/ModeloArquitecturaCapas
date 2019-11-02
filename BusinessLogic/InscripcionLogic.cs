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
        public IInscripcionRepository InscripcionRepository { get; set; }
        private readonly ContextUnit Context;

        public InscripcionLogic()
        {
            Context = ContextUnit.Unit;
            InscripcionRepository = Context.InscripcionRepository;
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
