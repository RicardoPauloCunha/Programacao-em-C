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
            int cont = 0;
            StreamReader sr = new StreamReader("usuario.csv");
            while (!sr.EndOfStream)
            {
                string[] coluna = sr.ReadLine().Split(";");
                int colunaId = Convert.ToInt16(coluna[0]);

                if (colunaId == cont)
                {
                    cont++;
                }
            }
            usuario.Id = cont;
            sr.Close();
            
            usuario.Nome = form["nome"];
            usuario.Email = form["email"];
            usuario.Senha = form["senha"];
            usuario.Tipo = form["tipo"];
            usuario.DataCriacao = DateTime.Now;
            

            using (StreamWriter sw = new StreamWriter("usuario.csv", true)) {
            sw.WriteLine($"{usuario.Id};{usuario.Nome};{usuario.Email};{usuario.Senha};{usuario.Tipo};{usuario.DataCriacao}");
            }

            ViewBag.Mensagem = "Usuário Cadastrado com Sucesso";            
            return View();
        }

        [HttpGet]
        public IActionResult Login() {
            return View();
        }

        [HttpPost]
        public IActionResult Login(IFormCollection form) {
            UsuarioModel usuario = new UsuarioModel();
            TarefaModel tarefa = new TarefaModel();
            
            usuario.Email = form["email"];
            usuario.Senha = form["senha"];

            using (StreamReader sr = new StreamReader("usuario.csv")) {
                while (!sr.EndOfStream)
                {
                    string[] linha = sr.ReadLine().Split(";");

                    if (usuario.Email == linha[2] && usuario.Senha == linha[3])
                    {
                        HttpContext.Session.SetInt32("id", usuario.Id);
                        tarefa.IdUsuario = usuario.Id;
                        return RedirectToAction("Cadastrar", "Tarefa");
                    }
                }
            }
            ViewBag.Mensagem = "Usuario Inválido";
            return View();
        }
    }
}