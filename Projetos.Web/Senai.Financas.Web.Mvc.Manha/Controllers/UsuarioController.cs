using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Senai.Financas.Web.Mvc.Models;
using Senai_Financas_Mvc_Web_master.Interfaces;
using Senai_Financas_Mvc_Web_master.Repositorios;
using Senai_Financas_Web_Mvc_Manha.Repositorios;

namespace Senai.Financas.Web.Mvc.Controllers {
    public class UsuarioController : Controller {

        private IUsuario UsuarioRepositorio{get; set;}

        //Construtor da usuario controller
        public UsuarioController()
        {
            //Polimorfismo
            UsuarioRepositorio = new UsuarioRepositorioSerializado();
        }

        [HttpGet]
        public ActionResult Cadastrar () {
            return View ();
        }

        [HttpPost]
        public ActionResult Cadastrar (IFormCollection form) {
            UsuarioModel usuario = new UsuarioModel (nome: form["nome"], email: form["email"], senha: form["senha"], dataNascimento:DateTime.Parse (form["dataNascimento"]));

            // UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio();
            // UsuarioRepositorioSerializado usuarioRepositorio = new UsuarioRepositorioSerializado();
            UsuarioRepositorio.Cadastrar(usuario);

            ViewBag.Mensagem = "Usuário Cadastrado";

            return RedirectToAction ("Index", "Transacao");
        }

        [HttpGet]
        public IActionResult Login () {
            return View ();
        }

        [HttpPost]
        public IActionResult Login (IFormCollection form) {
            // UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio();
            UsuarioModel usuario = UsuarioRepositorio.Login(form["email"], form["senha"]);

            if(usuario != null){
                HttpContext.Session.SetString("idUsuario", usuario.Id.ToString());
                return RedirectToAction ("Cadastrar", "Transacao");
            }

            ViewBag.Mensagem = "Usuário inválido";
            return View ();
        }

        [HttpGet]
        public IActionResult Listar () {
            // UsuarioRepositorioSerializado usuarioRepositorio = new UsuarioRepositorioSerializado();
            // UsuarioRepositorioSerializado usuarioRepositorio = new UsuarioRepositorioSerializado();

            ViewData["Usuarios"] = UsuarioRepositorio.Listar();

            return View ();
        }

        [HttpGet]
        public IActionResult Excluir (int id) {
            
            // UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio();
            UsuarioRepositorio.Excluir(id);

            TempData["Mensagem"] = "Usuário excluído";

            return RedirectToAction ("Listar");
        }
    
        [HttpGet]
        public IActionResult Editar(int id){

            if(id == 0){
                TempData["Mensagem"] = "Informe um usuário para editar";
                return RedirectToAction("Listar");
            }

            // UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio();
            UsuarioModel usuario = UsuarioRepositorio.BuscarPorId(id);

            if(usuario != null){
                ViewBag.Usuario = usuario;
            } else {
                TempData["Mensagem"] = "Usuário não encontrado";
                return RedirectToAction("Listar");
            }
            
            return View();
        }
    
        [HttpPost]
        public IActionResult Editar(IFormCollection form){
            //Declara um objeto UsuarioModel e atribui os valores do form
            UsuarioModel usuario = new UsuarioModel(
                id: int.Parse(form["id"]),
                nome: form["nome"],
                email: form["email"],
                senha: form["senha"],
                dataNascimento: DateTime.Parse(form["dataNascimento"])
            );

            //Cria um objeto UsuarioRepositorio e edita
            // UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio();
            UsuarioRepositorio.Editar(usuario);

            TempData["Mensagem"] = "Usuário editado";

            return RedirectToAction("Listar");
        }
    }
}