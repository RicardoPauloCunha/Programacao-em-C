using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaFinancas.Models;
using SistemaFinancas.Interfaces;
using SistemaFinancas.Repositorios;

namespace SistemaFinancas.Controllers
{
    public class UsuarioController : Controller {

        private readonly IUsuarioRepositorio _usuarioRepositorio;

        public UsuarioController()
        {
            _usuarioRepositorio = new UsuarioRepositorio();
        }

        [HttpGet]
        public ActionResult Cadastrar()
        {
            return View ();
        }

        [HttpPost]
        public ActionResult Cadastrar(IFormCollection form)
        {
            UsuarioModel usuario = new UsuarioModel(
                nome: form["nome"],
                email: form["email"],
                senha: form["senha"],
                dataNascimento:DateTime.Parse (form["dataNascimento"]));

            _usuarioRepositorio.Cadastrar(usuario);

            ViewBag.Mensagem = "Usuário Cadastrado";
            return RedirectToAction("Index", "Transacao");
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(IFormCollection form)
        {
            UsuarioModel usuario = _usuarioRepositorio.Login(form["email"], form["senha"]);

            if (usuario != null)
            {
                HttpContext.Session.SetString("idUsuario", usuario.Id.ToString());
                return RedirectToAction ("Cadastrar", "Transacao");
            }

            ViewBag.Mensagem = "Usuário inválido";
            return View();
        }

        [HttpGet]
        public IActionResult Listar()
        {
            ViewData["Usuarios"] = _usuarioRepositorio.Listar();
            return View();
        }

        [HttpGet]
        public IActionResult Excluir(int id)
        {
            _usuarioRepositorio.Excluir(id);

            TempData["Mensagem"] = "Usuário excluído";
            return RedirectToAction ("Listar");
        }
    
        [HttpGet]
        public IActionResult Editar(int id)
        {
            if (id == 0)
            {
                TempData["Mensagem"] = "Informe um usuário para editar";
                return RedirectToAction("Listar");
            }

            UsuarioModel usuario = _usuarioRepositorio.BuscarPorId(id);

            if (usuario != null)
            {
                ViewBag.Usuario = usuario;
            }
            else
            {
                TempData["Mensagem"] = "Usuário não encontrado";
                return RedirectToAction("Listar");
            }
            
            return View();
        }
    
        [HttpPost]
        public IActionResult Editar(IFormCollection form)
        {
            UsuarioModel usuario = new UsuarioModel(
                id: int.Parse(form["id"]),
                nome: form["nome"],
                email: form["email"],
                senha: form["senha"],
                dataNascimento: DateTime.Parse(form["dataNascimento"]));

            _usuarioRepositorio.Editar(usuario);

            TempData["Mensagem"] = "Usuário editado";
            return RedirectToAction("Listar");
        }
    }
}