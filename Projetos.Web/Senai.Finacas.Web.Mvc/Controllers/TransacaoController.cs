using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Senai.Finacas.Web.Mvc.Models;

namespace Senai.Finacas.Web.Mvc.Controllers
{
    public class TransacaoController : Controller
    {
        [HttpGet]
        public IActionResult Cadastrar() {
            if (string.IsNullOrEmpty(HttpContext.Session.GetString("emailUsuario"))) {
                return RedirectToAction("Login", "Usuario");
            }
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(IFormCollection form) {
            TransacaoModel transacao = new TransacaoModel();
            transacao.id = 1;
            transacao.Descricao = form["descricao"];
            transacao.Valor = decimal.Parse(form["valor"]);
            transacao.Tipo = form["tipo"];
            transacao.Data = DateTime.Parse(form["data"]);

            using (StreamWriter sw = new StreamWriter("transacao.csv", true))
            sw.WriteLine($"{transacao.id};{transacao.Descricao};{transacao.Valor};{transacao.Tipo};{transacao.Data}");

            ViewBag.Mensagem = "Transação Cadastrado";;
            return View();
        }

        [HttpGet]
        public IActionResult Listar() {
            List<TransacaoModel> lsTransacao = new List<TransacaoModel>();
            string[] linhas = System.IO.File.ReadAllLines("transacao.csv");
            TransacaoModel transacao;

            foreach (var item in linhas)
            {
                if (string.IsNullOrEmpty(item))
                {
                    continue;
                }

                string[] linha = item.Split(";");
                transacao = new TransacaoModel();

                transacao.id = int.Parse(linha[0]);
                transacao.Descricao = linha[1];
                transacao.Valor = decimal.Parse(linha[2]);
                transacao.Tipo = linha[3];
                transacao.Data = DateTime.Parse(linha[4]);

                lsTransacao.Add(transacao);
            }

            ViewData["Transacao"] = lsTransacao;
            return View();
        }
    }
}