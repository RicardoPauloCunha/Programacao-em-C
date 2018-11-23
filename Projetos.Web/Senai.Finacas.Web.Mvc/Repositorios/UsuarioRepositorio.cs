using System;
using System.Collections.Generic;
using System.IO;
using Senai.Finacas.Web.Mvc.Interfaces;
using Senai.Finacas.Web.Mvc.Models;

namespace Senai.Finacas.Web.Mvc.Repositorios
{
    public class UsuarioRepositorio : IUsuario
    {
        public UsuarioModel BuscarPorId(int id)
        {
            string[] linhas = System.IO.File.ReadAllLines("usuarios.csv");

            foreach (var item in linhas)
            {
                string[] linha = item.Split(";");

                if (id.ToString() == linha[0])
                {
                    UsuarioModel usuario = new UsuarioModel();
                    usuario.Id = int.Parse(linha[0]);
                    usuario.Nome = linha[1];
                    usuario.Email = linha[2];
                    usuario.Senha = linha[3];
                    usuario.DataNascimento = DateTime.Parse(linha[4]);

                    return usuario;
                }
            }
        return null;
        }

        public UsuarioModel Cadastrar(UsuarioModel usuario)
        {
            //Verfica se o arquivo existe
            if (File.Exists("usuarios.csv"))
            {
                //Se arquivo existe pega a quantidade de linhas e incrementa 1
                usuario.Id = File.ReadAllLines("usuarios.csv").Length + 1;
            }
            else {
                //Caso não exista defina o id do usuário como 1 
                usuario.Id = 1;
            }
            using (StreamWriter sw = new StreamWriter("usuarios.csv", true)) {
                sw.WriteLine($"{usuario.Id};{usuario.Nome};{usuario.Email};{usuario.Senha};{usuario.DataNascimento}");
            }
            return usuario;
        }

        public UsuarioModel Editar(UsuarioModel usuario)
        {
            string[] linhas = System.IO.File.ReadAllLines("usuarios.csv");

            for (int i = 0; i < linhas.Length; i++)
            {
                if (string.IsNullOrEmpty(linhas[i]))
                {
                    continue;
                }

                string[] colunas = linhas[i].Split(";");

                //Verifica se o id do formulário é igual ao da linha
                if (usuario.Id.ToString() == colunas[0])
                {
                    //Altera os dados da linha
                    linhas[i] = ($"{usuario.Id}");
                    linhas[i] = ($"{usuario.Id};{usuario.Nome};{usuario.Email};{usuario.Senha};{usuario.DataNascimento}");
                    break;
                }
            }
            //Altera os valores da linha pelos novos dados
            System.IO.File.WriteAllLines("usuarios.csv", linhas);
            return usuario;
        }

        public void Excluir(int id)
        {
            //Pega os dados do arquivo usuario.csv
            string[] linhas = System.IO.File.ReadAllLines("usuarios.csv");
        
            //Pecorre as linhas do arquivo
            for (int i = 0; i < linhas.Length; i++)
            {
                //Separa as colunas da linha
                string[] linha = linhas[i].Split(";");

                //Verifica se o id da linha é o id passado
                if (id.ToString() == linha[0])
                {
                    //Define a linha como vazia
                    linhas[i] = "";
                    break;
                }
            }

            //Armazano no arquivo csv todas as linhas
            System.IO.File.WriteAllLines("usuarios.csv", linhas);
        }

        public List<UsuarioModel> Listar()
        {
            List<UsuarioModel> lsUsuarios = new List<UsuarioModel>();

            string[] linhas = System.IO.File.ReadAllLines("usuarios.csv");

            UsuarioModel usuario;

            //Verifica se a linha é vazia
            foreach (var item in linhas)
            {
                //Retorna para o foreach
                if(string.IsNullOrEmpty(item)) {
                    continue;
                }

                string[] linha = item.Split(";");
                usuario = new UsuarioModel();

                usuario.Id = int.Parse(linha[0]);
                usuario.Nome = linha[1];
                usuario.Email = linha[2];
                usuario.Senha = linha[3];
                usuario.DataNascimento = DateTime.Parse(linha[4]);
                
                lsUsuarios.Add(usuario);
            }
            return lsUsuarios;
        }

        public UsuarioModel Login(string email, string senha)
        {
            using (StreamReader sr = new StreamReader("usuarios.csv")){
                    while (!sr.EndOfStream)
                    {
                        var linha = sr.ReadLine();

                        if (string.IsNullOrEmpty(linha))
                        {
                            continue;
                        }

                        string[] linhas = linha.Split(";");

                        if (linhas[2] == email && linhas[3] == senha) {
                            UsuarioModel usuario = new UsuarioModel();
                            usuario.Id = int.Parse(linhas[0]);
                            usuario.Nome = linhas[1];
                            usuario.Email = linhas[2];
                            usuario.Senha = linhas[3];
                            usuario.DataNascimento = DateTime.Parse(linhas[4]);
                            return usuario;
                        }
                    }
                }
                return null;
        }
    }
}