using Data;
using Data.Repositories;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class EspecialidadLogic
    {
        public IEspecialidadRepository EspecialidadRepository { get; set; }
        private readonly ContextUnit Context;

        public EspecialidadLogic()
        {
            Context = ContextUnit.Unit;
            EspecialidadRepository = Context.EspecialidadRepository;
        }

        //CRUD
        public IEnumerable<Especialidad> GetAll() => EspecialidadRepository.GetAll();

        public Especialidad Find(int? id) => EspecialidadRepository.GetById(id);

        public IEnumerable<Especialidad> FilterByDescripcion(IEnumerable<Especialidad> especialidades, string descripcion) {
            return especialidades.Where(e => e.Descripcion.ToLower().Contains(descripcion.ToLower()));
        }

        public void Add(Especialidad especialidad) => EspecialidadRepository.Add(especialidad);

        public void Update(Especialidad especialidad) => EspecialidadRepository.Update(especialidad);

        public void Remove(int id) => EspecialidadRepository.Delete(id);

        public void DeleteRange(List<Especialidad> especialidades) => EspecialidadRepository.DeleteRange(especialidades);
    }
}
