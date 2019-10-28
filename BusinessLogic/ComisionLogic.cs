using Data;
using Data.Persistance;
using Data.Repositories;
using Entities;
using System.Collections.Generic;

namespace BusinessLogic
{
    public class ComisionLogic
    {
        public ComisionRepository ComisionRepository { get; set; }
        private readonly AcademiaContext Context;

        public ComisionLogic()
        {
            Context = new AcademiaContext();
            ComisionRepository= new ComisionRepository(Context);
        }

        //CRUD
        public IEnumerable<Comision> GetAll() => ComisionRepository.GetAll();
    }
}
