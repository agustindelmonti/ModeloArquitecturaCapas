﻿using Data;
using Data.Persistance;
using Data.Repositories;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using Utils.Exceptions;

namespace BusinessLogic
{
    public class UsuarioLogic
    {
        public IUsuarioRepository UsuarioRepository { get; set; }
        private readonly ContextUnit Context;

        public UsuarioLogic()
        {
            Context = ContextUnit.Unit;
            UsuarioRepository = Context.UsuarioRepository;
        }

        public Usuario AuthCredentials(Usuario usuario)
        {
            Usuario usuarioBuscar = UsuarioRepository.FindByUsernameAndPassword(usuario.NombreUsuario, usuario.Clave);
 
            if (usuarioBuscar is null)
            {
                throw new UserAuthenticationException("Usuario y/o contraseña incorrecta");
            }
            if (!usuarioBuscar.Habilitado)
            {
                throw new UserAuthenticationException("Usuario no habilitado");
            }
            if (usuarioBuscar.CambioClave)
            {
                throw new UserAuthenticationException("Usuario ha cambiado de clave y no ha verificado el email.");
            }
            return usuarioBuscar;
         
        }

        public Persona GetPersonaByUserID(int userID)
        {
            return UsuarioRepository.GetPersonaByUserID(userID);
        }

        public IEnumerable<Usuario> FilterByNombreUsuario(IEnumerable<Usuario> usuarios, string nombreUsuario)
        {
            return usuarios.Where(u => u.NombreUsuario.ToLower().Contains(nombreUsuario.ToLower()));
        }

        //CRUD
        public IEnumerable<Usuario> GetAll() => UsuarioRepository.GetAll();

        public Usuario Find(int? id) => UsuarioRepository.GetById(id);

        public void Add(Usuario usuario) => UsuarioRepository.Add(usuario);

        public void Update(Usuario usuario) => UsuarioRepository.Update(usuario);

        public void Delete(int id) => UsuarioRepository.Delete(id);

        public void DeleteRange(List<Usuario> usuarios) => UsuarioRepository.DeleteRange(usuarios);
    }
}
