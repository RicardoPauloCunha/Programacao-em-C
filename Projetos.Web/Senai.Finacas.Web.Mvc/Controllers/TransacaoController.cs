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
            if (string.IsNullOrEmpty(HttpContext.Session.GetString("idUsuario"))) {
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

        [HttpGet]
        public IActionResult Excluir(int id) {
            string[] linhas = System.IO.File.ReadAllLines("transacao.csv");

            for (int i = 0; i < linhas.Length; i++)
            {
                string[] coluna = linhas[i].Split(";");

                if (id.ToString() == linhas[0]){
                    linhas[i] = "";
                    break;
                }
            }

            System.IO.File.WriteAllLines("transacao.csv", linhas);
            TempData["Mensagem"] = "Transacao excluido";
            return RedirectToAction("Listar");
        }

        [HttpGet]
        public IActionResult Editar(int id){
            string[] linhas = System.IO.File.ReadAllLines("transacao.csv");

            foreach (var item in linhas)
            {
                string[] coluna = item.Split(";");
                
                if (string.IsNullOrEmpty(item)) {
                    continue;
                }
                 if (id.ToString() == coluna[0])
                 {
                    TransacaoModel transacao = new TransacaoModel();
                    transacao.id = int.Parse(coluna[0]);
                    transacao.Descricao = coluna[1];
                    transacao.Valor = decimal.Parse(coluna[2]);
                    transacao.Tipo = coluna[3];
                    transacao.Data = DateTime.Parse(coluna[4]);

                    ViewBag.Transacao = transacao;
                    break;
                 }
            }


            return View();
        }
    }
}