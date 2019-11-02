using Data;
using Data.Persistance;
using Data.Repositories;
using Entities;
using System;
using System.Collections.Generic;

namespace BusinessLogic
{
    public class ModuloLogic
    {
        public IModuloRepository ModuloRepository { get; set; }
        private readonly ContextUnit Context;

        public ModuloLogic()
        {
            Context = ContextUnit.Unit;
            ModuloRepository = Context.ModuloRepository;
        }

        //CRUD
        public IEnumerable<Modulo> GetAll() => ModuloRepository.GetAll();

        public void Delete(int id) => ModuloRepository.Delete(id);

        public Modulo Find(int? id) => ModuloRepository.GetById(id);

        public void Update(Modulo Modulo) => ModuloRepository.Update(Modulo);

        public void Add(Modulo Modulo) => ModuloRepository.Add(Modulo);
    }
}
