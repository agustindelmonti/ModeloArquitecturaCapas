﻿using Data;
using Data.Persistance;
using Entities;
using System;
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

        public Materia Find(int? id) => MateriaRepository.GetById(id);

        public void Add(Materia materia) => MateriaRepository.Add(materia);

        public void Update(Materia materia) => MateriaRepository.Update(materia);

        public void Delete(int id) => MateriaRepository.Delete(id);
    }
}