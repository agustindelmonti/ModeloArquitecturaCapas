using Data;
using Data.Repositories;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLogic
{
    public class ComisionLogic
    {
        public IComisionRepository ComisionRepository { get; set; }
        private readonly ContextUnit Context;

        public ComisionLogic()
        {
            Context = ContextUnit.Unit;
            ComisionRepository = Context.ComisionRepository;
        }

        //CRUD
        public IEnumerable<Comision> GetAll() => ComisionRepository.GetAll();


        public IEnumerable<Comision> FilterByNroComision(IEnumerable<Comision> comisiones, string nroComision) {
            return comisiones.Where(c => c.Descripcion.StartsWith(nroComision));
        }

        public Comision Find(int? id) => ComisionRepository.GetById(id);

        public void Add(Comision comision) => ComisionRepository.Add(comision);

        public void Update(Comision comision) => ComisionRepository.Update(comision);

        public void Delete(int id) => ComisionRepository.Delete(id);

        public List<Comision> GetAllByPlan(Plan plan) => ComisionRepository.GetAllByPlan(plan);

        public void DeleteRange(List<Comision> comisiones) => ComisionRepository.DeleteRange(comisiones);

    }
}
