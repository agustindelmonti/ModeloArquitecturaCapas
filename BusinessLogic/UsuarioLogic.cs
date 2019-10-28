using Data;
using Data.Persistance;
using Data.Repositories;
using Entities;
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
    }
}
