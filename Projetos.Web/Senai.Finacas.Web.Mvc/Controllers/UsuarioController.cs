using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Senai.Finacas.Web.Mvc.Models;

namespace Senai.Finacas.Web.Mvc.Controllers
{
    public class UsuarioController : Controller
    {
        [HttpGet]
        public ActionResult Cadastrar() {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(IFormCollection form) {
            UsuarioModel usuario = new UsuarioModel();

            usuario.Id = System.IO.File.ReadAllLines("usuarios.csv").Length +1;
            usuario.Nome = form["nome"];
            usuario.Email = form["email"];
            usuario.Senha = form["senha"];
            usuario.DataNascimento = DateTime.Parse(form["dataNascimento"]);
            
            using (StreamWriter sw = new StreamWriter("usuarios.csv", true)) {
                sw.WriteLine($"{usuario.Id};{usuario.Nome};{usuario.Email};{usuario.Senha};{usuario.DataNascimento}");
            }

            ViewBag.Mensagem = "Usuário Cadastrado";

            return View();
        }

        [HttpGet]
        public IActionResult Login() {
            return View();
        }

        [HttpPost]
        public IActionResult Login(IFormCollection form) {
            UsuarioModel usuario = new UsuarioModel();
            usuario.Email = form["email"];
            usuario.Senha = form["senha"];
           
            using (StreamReader sr = new StreamReader("usuarios.csv")){
                while (!sr.EndOfStream)
                {
                    var linha = sr.ReadLine();

                    if (string.IsNullOrEmpty(linha))
                    {
                        continue;
                    }

                    string[] linhas = linha.Split(";");

                    if (linhas[2] == usuario.Email && linhas[3] == usuario.Senha) {
                        HttpContext.Session.SetString("emailUsuario", usuario.Email);
                        return RedirectToAction("Cadastrar", "Transacao");
                    }
                }
            }
            ViewBag.Mensagem = "Ususario Inválido";

            return View();
        }

        [HttpGet]
        public IActionResult Listar() {
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

            ViewData["Usuarios"] = lsUsuarios;
            return View();
        }

        [HttpGet]
        public IActionResult Excluir(int id) {
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

            TempData["Mensagem"] = "Usuário excluido";
            return RedirectToAction("Listar");
        }
    }
}