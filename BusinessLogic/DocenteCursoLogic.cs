using Data;
using Data.Persistance;
using Data.Repositories;
using Entities;
using System;
using System.Collections.Generic;

namespace BusinessLogic
{
    public class DocenteCursoLogic
    {
        public IDocenteCursoRepository DocenteCursoRepository { get; set; }
        private readonly ContextUnit Context;

        public DocenteCursoLogic()
        {
            Context = ContextUnit.Unit;
            DocenteCursoRepository = Context.DocenteCursoRepository;
        }

        //CRUD
        public IEnumerable<DocenteCurso> GetAll() => DocenteCursoRepository.GetAll();

        public DocenteCurso Find(int? id) => DocenteCursoRepository.GetById(id);

        public void Add(DocenteCurso docenteCurso) => DocenteCursoRepository.Add(docenteCurso);

        public void Update(DocenteCurso docenteCurso) => DocenteCursoRepository.Update(docenteCurso);

        public void Delete(int id) => DocenteCursoRepository.Delete(id);
    }
}
