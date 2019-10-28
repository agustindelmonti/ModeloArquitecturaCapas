using Data.Repositories;
using System;
using System.Collections.Generic;
using Entities;
using Data;

namespace BusinessLogic
{
    public class CursoLogic
    {
        public CursoRepository CursoRepository { get; set; }
        private readonly AcademiaContext Context;

        public CursoLogic()
        {
            Context = new AcademiaContext();
            CursoRepository = new CursoRepository(Context);
        }

        //CRUD
        public IEnumerable<Curso> GetAll() => CursoRepository.GetAll();

        public Curso Find(int? id) => CursoRepository.Find(id);

        public void Add(Curso curso) => CursoRepository.Add(curso);

        public void Update(Curso curso) => CursoRepository.Update(curso);

        public void Delete(int id) => CursoRepository.Delete(id);
    }
}
