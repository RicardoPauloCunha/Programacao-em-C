using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaFinancas.Interfaces;
using SistemaFinancas.Models;
using SistemaFinancas.Repositorios;

namespace SistemaFinancas.Controllers
{
    public class TransacaoController : Controller
    {
        private readonly ITransacaoRepositorio _transacaoRepositorio;

        public TransacaoController()
        {
            _transacaoRepositorio = new TransacaoRepositorio();
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            if(string.IsNullOrEmpty(HttpContext.Session.GetString("idUsuario")))
                return RedirectToAction("Login", "Usuario");

            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(IFormCollection form)
        {
            TransacaoModel transacao = new TransacaoModel(
                form["descricao"],
                decimal.Parse(form["valor"]),
                form["tipo"],
                DateTime.Parse(form["data"]));

            _transacaoRepositorio.Cadastrar(transacao);

            ViewBag.Mensagem = "Transação cadastrada";
            return View();
        }
    }
}