using Data;
using Data.Persistance;
using Data.Repositories;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;

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

        public IEnumerable<Persona> FilterByLegajo(IEnumerable<Persona> personas, string legajo) {
            return personas.Where(p => p.Legajo.ToString().StartsWith(legajo));
        }

        public IEnumerable<Persona> FilterByRol(IEnumerable<Persona> personas, string rol) {
            return personas.Where(p => p.Rol == rol);
        }

        public void Delete(int id) => PersonaRepository.Delete(id);

        public Persona GetByLegajo(int legajo) => PersonaRepository.GetByLegajo(legajo);

        public void DeleteRange(List<Persona> personas) => PersonaRepository.DeleteRange(personas);
    }
}
