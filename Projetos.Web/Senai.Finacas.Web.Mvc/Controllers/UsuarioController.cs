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
            usuario.Nome = form["nome"];
            usuario.Email = form["email"];
            usuario.Senha = form["senha"];
            usuario.DataNascimento = DateTime.Parse(form["dataNascimento"]);
            
            using (StreamWriter sw = new StreamWriter("usuarios.csv", true)) {
                sw.WriteLine($"{usuario.Nome};{usuario.Email};{usuario.Senha};{usuario.DataNascimento}");
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
                    string[] linhas = sr.ReadLine().Split(";");

                    if (linhas[1] == usuario.Email && linhas[2] == usuario.Senha) {
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

            foreach (var item in linhas)
            {
                string[] linha = item.Split(";");
                usuario = new UsuarioModel();
                usuario.Nome = linha[0];
                usuario.Email = linha[1];
                usuario.Senha = linha[2];
                usuario.DataNascimento = DateTime.Parse(linha[3]);
                
                lsUsuarios.Add(usuario);
            }

            ViewData["Usuarios"] = lsUsuarios;
            return View();
        }
    }
}