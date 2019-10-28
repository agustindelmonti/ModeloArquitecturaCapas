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
        public EspecialidadRepository EspecialidadRepository { get; set; }
        private readonly AcademiaContext Context;

        public EspecialidadLogic()
        {
            Context = new AcademiaContext();
            EspecialidadRepository = new EspecialidadRepository(Context);
        }

        //CRUD
        public object GetAll() => EspecialidadRepository.GetAll();

        public Especialidad Find(int? id) => EspecialidadRepository.GetById(id);

        public void Add(Especialidad especialidad) => EspecialidadRepository.Add(especialidad);

        public void Update(Especialidad especialidad) => EspecialidadRepository.Update(especialidad);

        public void Remove(int id) => EspecialidadRepository.Delete(id);
    }
}
