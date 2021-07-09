using System;

namespace SistemaFinancas.Models
{
    public class UsuarioModel
    { 
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public DateTime DataNascimento { get; set; }

        public UsuarioModel(int id, string nome, string email, string senha, DateTime dataNascimento)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Senha = senha;
            DataNascimento = dataNascimento;
        }

        public UsuarioModel(string nome, string email, string senha, DateTime dataNascimento)
        {
            Nome = nome;
            Email = email;
            Senha = senha;
            DataNascimento = dataNascimento;
        }
    }
}