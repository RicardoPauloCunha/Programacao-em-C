using System;

namespace Pizzaria.ViewModels
{
    public class UsuarioViewModel : BaseViewModel
    {
        public string Email { get; set; }
        public string Senha { get; set; }

        public UsuarioViewModel(string nome, string email, string senha)
        {
            Nome = nome;
            Email = email;
            Senha = senha;
            DataCriacao = DateTime.Now;
        }
    }
}