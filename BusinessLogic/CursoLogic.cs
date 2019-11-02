using Data.Repositories;
using System;
using System.Collections.Generic;
using Entities;
using Data;

namespace BusinessLogic
{
    public class CursoLogic
    {
        public ICursoRepository CursoRepository { get; set; }
        private readonly ContextUnit Context;

        public CursoLogic()
        {
            Context = ContextUnit.Unit;
            CursoRepository = Context.CursoRepository;
        }
    

        public IEnumerable<Persona> GetDocentesCurso(Curso curso) => CursoRepository.GetDocentesCurso(curso);

        //CRUD
        public IEnumerable<Curso> GetAll() => CursoRepository.GetAll();

        public Curso Find(int? id) => CursoRepository.GetById(id);

        public void Add(Curso curso) => CursoRepository.Add(curso);

        public void Update(Curso curso) => CursoRepository.Update(curso);

        public void Delete(int id) => CursoRepository.Delete(id);
    }
}
