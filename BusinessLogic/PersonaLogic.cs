using Data;
using Data.Persistance;
using Data.Repositories;
using Entities;
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
    }
}
