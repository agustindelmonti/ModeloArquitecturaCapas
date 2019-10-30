﻿using Data;
using Data.Persistance;
using Data.Repositories;
using Entities;
using System;
using System.Collections.Generic;

namespace BusinessLogic
{
    public class PersonaLogic
    {
        public PersonaRepository PersonaRepository { get; set; }
        private readonly AcademiaContext Context;

        public PersonaLogic()
        {
            Context = new AcademiaContext();
            PersonaRepository= new PersonaRepository(Context);
        }

        //CRUD
        public IEnumerable<Persona> GetAll() => PersonaRepository.GetAll();

        public Persona Find(int? id) => PersonaRepository.GetById(id);

        public void Add(Persona persona) => PersonaRepository.Add(persona);

        public void Update(Persona persona) => PersonaRepository.Update(persona);

        public void Delete(int id) => PersonaRepository.Delete(id);
    }
}