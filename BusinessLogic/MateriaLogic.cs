using Data;
using Data.Persistance;
using Data.Repositories;
using Entities;
using System;
using System.Collections.Generic;

namespace BusinessLogic
{
    public class MateriaLogic
    {
        public IMateriaRepository MateriaRepository { get; set; }
        private readonly ContextUnit Context;

        public MateriaLogic()
        {
            Context = ContextUnit.Unit;
            MateriaRepository = Context.MateriaRepository;
        }

        //CRUD
        public IEnumerable<Materia> GetAll() => MateriaRepository.GetAll();

        public Materia Find(int? id) => MateriaRepository.GetById(id);

        public void Add(Materia materia) => MateriaRepository.Add(materia);

        public void Update(Materia materia) => MateriaRepository.Update(materia);

        public void Delete(int id) => MateriaRepository.Delete(id);
    }
}
