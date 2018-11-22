using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Senai.Finacas.Web.Mvc.Models;
using Senai.Finacas.Web.Mvc.Repositorios;

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

            UsuarioRepositorio usuarioRep = new UsuarioRepositorio();
            usuarioRep.Cadastrar(usuario);
            ViewBag.Mensagem = "Usuário Cadastrado";

            return View();
        }

        [HttpGet]
        public IActionResult Login() {
            return View();
        }

        [HttpPost]
        public IActionResult Login(IFormCollection form) {
            UsuarioRepositorio usuarioRep = new UsuarioRepositorio();
            UsuarioModel usuario = usuarioRep.Login(form["email"], form["senha"]);

            if (usuario != null)
            {
                HttpContext.Session.SetString("idUsuario", usuario.Id.ToString());
                return RedirectToAction("Cadastrar", "Transacao");
            }
            ViewBag.Mensagem = "Ususario Inválido";

            return View();
        }

        [HttpGet]
        public IActionResult Listar() {
            UsuarioRepositorio usuarioRep = new UsuarioRepositorio();

            ViewData["Usuarios"] = usuarioRep.Listar();
            return View();
        }

        [HttpGet]
        public IActionResult Excluir(int id) {
            UsuarioRepositorio usuarioRep = new UsuarioRepositorio();
            usuarioRep.Excluir(id);

            TempData["Mensagem"] = "Usuário excluido";
            return RedirectToAction("Listar");
        }
    
        [HttpGet]
        public IActionResult Editar(int id) {

            if (id == 0)
            {
                TempData["Mensagem"] = "Informe um usuario para editar";
                return RedirectToAction("Listar");
            }
            
            UsuarioRepositorio usuarioRep = new UsuarioRepositorio();
            UsuarioModel usuario = usuarioRep.BuscarPorId(id);

            if (usuario != null)
            {
                TempData["Mensagem"] = "Informe um usuario para editar";
                return RedirectToAction("Editar");
            }
            
            return View();
        }
    
        [HttpPost]
        public IActionResult Editar(IFormCollection form){
            UsuarioModel usuario = new UsuarioModel{
                Id = int.Parse(form["id"]),
                Nome = form["nome"],
                Email = form["email"],
                Senha = form["senha"],
                DataNascimento = DateTime.Parse(form["dataNascimento"])
            };

            UsuarioRepositorio usuarioRep = new UsuarioRepositorio();
            usuarioRep.Editar(usuario);
            
            TempData["Mensagem"] = "Usuário editado";
            return RedirectToAction("Listar");
        }
    }
}