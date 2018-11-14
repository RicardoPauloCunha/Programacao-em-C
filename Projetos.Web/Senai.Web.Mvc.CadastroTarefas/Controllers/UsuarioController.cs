using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Senai.Web.Mvc.CadastroTarefas.Models;

namespace Senai.Web.Mvc.CadastroTarefas.Controllers
{
    public class UsuarioController : Controller
    { 
        [HttpGet]
        public IActionResult Cadastrar(){
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(IFormCollection form){
            UsuarioModel usuario = new UsuarioModel(); 
            int contador = 0;           
            
            usuario.Id = contador;
            usuario.Nome = form["nome"];
            usuario.Email = form["email"];
            usuario.Senha = form["senha"];
            usuario.Tipo = form["tipo"];
            usuario.DataCriacao = DateTime.Now;

            using (StreamWriter sw = new StreamWriter("usuario.csv", true)) {
            sw.WriteLine($"{usuario.Id};{usuario.Nome};{usuario.Email};{usuario.Senha};{usuario.Tipo};{usuario.DataCriacao}");
            }

            ViewBag.Mensagem = "Usuário Cadastrado com Sucesso";
            contador++;
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

            using (StreamReader sr = new StreamReader("usuario.csv")) {
                while (!sr.EndOfStream)
                {
                    string[] linha = sr.ReadLine().Split(";");

                    if (usuario.Email == linha[2] && usuario.Senha == linha[3])
                    {
                        HttpContext.Session.SetInt32("id", usuario.Id);
                        return RedirectToAction("Cadastrar", "Tarefa");
                    }
                }
            }
            ViewBag.Mensagem = "Usuario Inválido";
            return View();
        }
    }
}