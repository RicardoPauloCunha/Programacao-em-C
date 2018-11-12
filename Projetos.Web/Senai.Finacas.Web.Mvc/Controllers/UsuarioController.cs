using System;
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
    }
}