using Data;
using Data.Persistance;
using Data.Repositories;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLogic
{
    public class PlanLogic
    {
        public IPlanRepository PlanRepository { get; set; }
        private readonly ContextUnit Context;

        public PlanLogic()
        {
            Context = ContextUnit.Unit;
            PlanRepository = Context.PlanRepository;
        }

        //CRUD
        public IEnumerable<Plan> GetAll() => PlanRepository.GetAll();

        public void Delete(int id) => PlanRepository.Delete(id);

        public Plan Find(int? id) => PlanRepository.GetById(id);

        public void Update(Plan plan) => PlanRepository.Update(plan);

        public IEnumerable<Plan> FilterByDescripcion(IEnumerable<Plan> planes, string descripcion) {
            return planes.Where(p => p.Descripcion.ToLower().Contains(descripcion.ToLower()));
        }

        public void Add(Plan plan) => PlanRepository.Add(plan);

        public void DeleteRange(List<Plan> planes) => PlanRepository.DeleteRange(planes);

        public List<Plan> GetAllByEspecialidad(Especialidad especialidad) => PlanRepository.GetAllByEspecialidad(especialidad);
    }
}
