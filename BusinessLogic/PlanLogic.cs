﻿using Data;
using Data.Persistance;
using Data.Repositories;
using Entities;
using System;
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

        public void Delete(int id) => PlanRepository.Delete(id);

        public Plan Find(int? id) => PlanRepository.GetById(id);

        public void Update(Plan plan) => PlanRepository.Update(plan);

        public void Add(Plan plan) => PlanRepository.Add(plan);
    }
}