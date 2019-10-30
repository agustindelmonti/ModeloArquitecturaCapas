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
        public ModuloRepository ModuloRepository { get; set; }
        private readonly AcademiaContext Context;

        public ModuloLogic()
        {
            Context = new AcademiaContext();
            ModuloRepository= new ModuloRepository(Context);
        }

        //CRUD
        public IEnumerable<Modulo> GetAll() => ModuloRepository.GetAll();

        public void Delete(int id) => ModuloRepository.Delete(id);

        public Modulo Find(int? id) => ModuloRepository.GetById(id);

        public void Update(Modulo Modulo) => ModuloRepository.Update(Modulo);

        public void Add(Modulo Modulo) => ModuloRepository.Add(Modulo);
    }
}
