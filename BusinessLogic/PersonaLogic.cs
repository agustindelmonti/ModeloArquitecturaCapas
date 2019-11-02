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
        public IPersonaRepository PersonaRepository { get; set; }
        private readonly ContextUnit Context;

        public PersonaLogic()
        {
            Context = ContextUnit.Unit;
            PersonaRepository = Context.PersonaRepository;
        }

        //CRUD
        public IEnumerable<Persona> GetAll() => PersonaRepository.GetAll();

        public Persona Find(int? id) => PersonaRepository.GetById(id);

        public void Add(Persona persona) => PersonaRepository.Add(persona);

        public void Update(Persona persona) => PersonaRepository.Update(persona);

        public void Delete(int id) => PersonaRepository.Delete(id);
    }
}
