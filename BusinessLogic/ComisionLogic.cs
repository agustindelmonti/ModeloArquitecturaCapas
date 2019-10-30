﻿using Data;
using Data.Persistance;
using Data.Repositories;
using Entities;
using System;
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

        public Comision Find(int? id) => ComisionRepository.GetById(id);

        public void Add(Comision comision) => ComisionRepository.Add(comision);

        public void Update(Comision comision) => ComisionRepository.Update(comision);

        public void Delete(int id) => ComisionRepository.Delete(id);
    }
}