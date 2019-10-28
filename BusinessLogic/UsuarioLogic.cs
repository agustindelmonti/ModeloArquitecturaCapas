using Data;
using Data.Persistance;
using Data.Repositories;
using Entities;
using System;
using System.Collections.Generic;

namespace BusinessLogic
{
    public class UsuarioLogic
    {
        public UsuarioRepository UsuarioRepository { get; set; }
        private readonly AcademiaContext Context;

        public UsuarioLogic()
        {
            Context = new AcademiaContext();
            UsuarioRepository= new UsuarioRepository(Context);
        }

        //CRUD
        public IEnumerable<Usuario> GetAll() => UsuarioRepository.GetAll();

        public Usuario Find(int? id) => UsuarioRepository.GetById(id);

        public void Add(Usuario usuario) => UsuarioRepository.Add(usuario);

        public void Update(Usuario usuario) => UsuarioRepository.Update(usuario);

        public void Delete(int id) => UsuarioRepository.Delete(id);
    }
}
