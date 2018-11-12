using System;
using System.IO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Senai.Financas.Web.Mvc.CasdTransacao.Models;

namespace Senai.Financas.Web.Mvc.CasdTransacao.Controllers
{
    public class TransacaoController : Controller
    {
        [HttpGet]
        public ActionResult Cadastrar() {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(IFormCollection form) {
            TransacaoModel transacao = new TransacaoModel();
            transacao.Nome = form["nome"];
            transacao.Descricao = form["descricao"];
            transacao.Valor = decimal.Parse(form["valor"]);
            transacao.TipoTransacao = form["tipoTransacao"];
            transacao.DataTransacao = DateTime.Parse(form["dataTransacao"]);
        
            using (StreamWriter sw = new StreamWriter("transacao.csv", true)) {
                sw.WriteLine($"{transacao.Nome};{transacao.Descricao};{transacao.Valor};{transacao.TipoTransacao};{transacao.DataTransacao}");
            }

            return View();
        }
    }
}