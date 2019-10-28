using Data;
using Data.Persistance;
using Data.Repositories;
using Entities;
using System.Collections.Generic;

namespace BusinessLogic
{
    public class PlanLogic
    {
        public PlanRepository PlanRepository { get; set; }
        private readonly AcademiaContext Context;

        public PlanLogic()
        {
            Context = new AcademiaContext();
            PlanRepository= new PlanRepository(Context);
        }

        //CRUD
        public IEnumerable<Plan> GetAll() => PlanRepository.GetAll();
    }
}
