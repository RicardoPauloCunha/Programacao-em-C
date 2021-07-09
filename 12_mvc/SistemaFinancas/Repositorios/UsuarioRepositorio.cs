using System;
using System.Collections.Generic;
using System.IO;
using SistemaFinancas.Models;
using SistemaFinancas.Interfaces;

namespace SistemaFinancas.Repositorios
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {
        private readonly List<UsuarioModel> _usuarios;
        private const string NOMEARQUIVO = "usuarios.csv";

        public UsuarioRepositorio()
        {
            if (File.Exists(NOMEARQUIVO))
                _usuarios = Listar();
            else
                _usuarios = new List<UsuarioModel>();
        }

        public UsuarioModel BuscarPorId(int id)
        {
            foreach (var item in _usuarios)
            {
                if (id == item.Id)
                    return item;
            }

            return null;
        }

        public UsuarioModel Cadastrar(UsuarioModel usuario)
        {
            if(File.Exists(NOMEARQUIVO))
                usuario.Id = File.ReadAllLines(NOMEARQUIVO).Length + 1;
            else
                usuario.Id = 1;

            using (StreamWriter sw = new StreamWriter(NOMEARQUIVO, true))
            {
                sw.WriteLine($"{usuario.Id};{usuario.Nome};{usuario.Email};{usuario.Senha};{usuario.DataNascimento}");
            }

            return usuario;
        }

        public UsuarioModel Editar(UsuarioModel usuario)
        {
            string[] linhas = File.ReadAllLines(NOMEARQUIVO);

            for (int i = 0; i < linhas.Length; i++)
            {
                if(string.IsNullOrEmpty(linhas[i]))
                    continue;

                string[] dados = linhas[i].Split(';');

                if (usuario.Id.ToString() == dados[0])
                {
                    linhas[i] = $"{usuario.Id};{usuario.Nome};{usuario.Email};{usuario.Senha};{usuario.DataNascimento}";
                    break;
                }
            }

            File.WriteAllLines(NOMEARQUIVO, linhas);

            return usuario;
        }

        public UsuarioModel Login(string email, string senha)
        {
            using (StreamReader sr = new StreamReader(NOMEARQUIVO))
            {
                while (!sr.EndOfStream)
                {
                    var linha = sr.ReadLine();

                    if (string.IsNullOrEmpty(linha))
                        continue;

                    string[] dados = linha.Split(";");

                    if (dados[2] == email && dados[3] == senha)
                    {
                        UsuarioModel usuario = new UsuarioModel(
                            id: int.Parse(dados[0]),
                            nome: dados[1],
                            email: dados[2],
                            senha: dados[3],
                            dataNascimento: DateTime.Parse(dados[4]));

                        return usuario;
                    }
                }
            }

            return null;
        }

        public List<UsuarioModel> Listar()
        {
            List<UsuarioModel> usuarios = new List<UsuarioModel>();

            string[] linhas = File.ReadAllLines(NOMEARQUIVO);

            foreach (var item in linhas)
            {

                if (string.IsNullOrEmpty(item))
                {
                    continue;
                }

                string[] linha = item.Split(';');

                UsuarioModel usuario = new UsuarioModel(
                    id: int.Parse(linha[0]),
                    nome: linha[1],
                    email: linha[2],
                    senha: linha[3],
                    dataNascimento: DateTime.Parse(linha[4]));

                usuarios.Add(usuario);
            }

            return usuarios;
        }

        public void Excluir(int id)
        {
            string[] linhas = File.ReadAllLines(NOMEARQUIVO);

            for (int i = 0; i < linhas.Length; i++)
            {
                string[] linha = linhas[i].Split(';');

                if (id.ToString() == linha[0])
                {
                    linhas[i] = "";
                    break;
                }
            }

            File.WriteAllLines(NOMEARQUIVO, linhas);
        }
    }
}