using System;
using System.IO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Senai.Web.Mvc.CadastroTarefas.Models;

namespace Senai.Web.Mvc.CadastroTarefas.Controllers
{
    public class TarefaController : Controller
    {
        [HttpGet]
        public IActionResult Cadastrar() {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(IFormCollection form) {
            UsuarioModel usuario = new UsuarioModel();
            TarefaModel tarefa = new TarefaModel();
            int contador = 0;

            tarefa.Id = contador;
            tarefa.Nome = form["nome"];
            tarefa.Descricao = form["descricao"];
            tarefa.Tipo = form["tipo"];
            tarefa.IdUsuario = usuario.Id;
            tarefa.DataCriacao = DateTime.Parse(form["data"]);

            using (StreamWriter sw = new StreamWriter("tarefa.csv")) {
                sw.WriteLine($"{tarefa.Id};{tarefa.Nome};{tarefa.Descricao};{tarefa.Tipo};{tarefa.IdUsuario};{tarefa.DataCriacao}");
            }

            ViewBag.Mensagem = "Tarefa Cadastrada com Sucesso";
            contador++;
            return View();
        }
    }
}