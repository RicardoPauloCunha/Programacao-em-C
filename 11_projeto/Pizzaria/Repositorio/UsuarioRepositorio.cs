using System;
using System.Collections.Generic;
using Pizzaria.ViewModels;

namespace Pizzaria.Repositorio
{
    public class UsuarioRepositorio
    {
        readonly List<UsuarioViewModel> usuarios = new List<UsuarioViewModel>();

        public UsuarioViewModel Adicionar(UsuarioViewModel usuario)
        {
            usuario.Id = usuarios.Count + 1;
            usuario.DataCriacao = DateTime.Now;

            usuarios.Add(usuario);
            return usuario;
        }

        public List<UsuarioViewModel> Listar()
        {
            return usuarios;
        }

        public UsuarioViewModel EfetuarLogin(string email, string senha)
        {
            foreach (UsuarioViewModel item in usuarios)
            {
                if (item.Email == email && item.Senha == senha)
                    return item;
            }

            return null;
        }
    }
}