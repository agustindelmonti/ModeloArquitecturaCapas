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
        public IModuloUsuarioRepository ModuloUsuarioRepository { get; set; }
        private readonly ContextUnit Context;

        public ModuloUsuarioLogic()
        {
            Context = ContextUnit.Unit;
            ModuloUsuarioRepository = Context.ModuloUsuarioRepository;
        }

        //CRUD
        public IEnumerable<ModuloUsuario> GetAll() => ModuloUsuarioRepository.GetAll();

        public void Delete(int id) => ModuloUsuarioRepository.Delete(id);

        public ModuloUsuario Find(int? id) => ModuloUsuarioRepository.GetById(id);

        public void Update(ModuloUsuario ModuloUsuario) => ModuloUsuarioRepository.Update(ModuloUsuario);

        public void Add(ModuloUsuario ModuloUsuario) => ModuloUsuarioRepository.Add(ModuloUsuario);
    }
}
