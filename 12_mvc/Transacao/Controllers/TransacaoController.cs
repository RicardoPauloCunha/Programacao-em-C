using System;
using System.IO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Transacao.Models;

namespace Transacao.Controllers
{
    public class TransacaoController : Controller
    {
        [HttpGet]
        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(IFormCollection form)
        {
            TransacaoModel transacao = new TransacaoModel(
                form["nome"],
                form["descricao"],
                decimal.Parse(form["valor"]),
                form["tipoTransacao"],
                DateTime.Parse(form["dataTransacao"]));

            using (StreamWriter sw = new StreamWriter("transacao.csv", true))
            {
                sw.WriteLine($"{transacao.Nome};{transacao.Descricao};{transacao.Valor};{transacao.TipoTransacao};{transacao.DataTransacao}");
            }

            return View();
        }
    }
}