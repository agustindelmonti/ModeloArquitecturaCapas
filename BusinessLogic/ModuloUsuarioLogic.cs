using Data;
using Data.Persistance;
using Data.Repositories;
using Entities;
using System;
using System.Collections.Generic;

namespace BusinessLogic
{
    public class ModuloUsuarioLogic
    {
        public ModuloUsuarioRepository ModuloUsuarioRepository { get; set; }
        private readonly AcademiaContext Context;

        public ModuloUsuarioLogic()
        {
            Context = new AcademiaContext();
            ModuloUsuarioRepository= new ModuloUsuarioRepository(Context);
        }

        //CRUD
        public IEnumerable<ModuloUsuario> GetAll() => ModuloUsuarioRepository.GetAll();

        public void Delete(int id) => ModuloUsuarioRepository.Delete(id);

        public ModuloUsuario Find(int? id) => ModuloUsuarioRepository.GetById(id);

        public void Update(ModuloUsuario ModuloUsuario) => ModuloUsuarioRepository.Update(ModuloUsuario);

        public void Add(ModuloUsuario ModuloUsuario) => ModuloUsuarioRepository.Add(ModuloUsuario);
    }
}
