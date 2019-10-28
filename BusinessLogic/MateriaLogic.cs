using Data;
using Data.Persistance;
using Entities;
using System.Collections.Generic;

namespace BusinessLogic
{
    public class MateriaLogic
    {
        public MateriaRepository MateriaRepository { get; set; }
        private readonly AcademiaContext Context;

        public MateriaLogic()
        {
            Context = new AcademiaContext();
            MateriaRepository= new MateriaRepository(Context);
        }

        //CRUD
        public IEnumerable<Materia> GetAll() => MateriaRepository.GetAll();
    }
}
