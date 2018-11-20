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

            int cont = 0;
            StreamReader sr = new StreamReader("tarefa.csv");
            while (!sr.EndOfStream)
            {
                string[] coluna = sr.ReadLine().Split(";");
                int colunaId = Convert.ToInt16(coluna[0]);

                if (colunaId == cont)
                {
                    cont++;
                }
            }
            tarefa.Id = cont;
            sr.Close();

            tarefa.Nome = form["nome"];
            tarefa.Descricao = form["descricao"];
            tarefa.Tipo = form["tipo"];
            tarefa.IdUsuario = usuario.Id;
            tarefa.DataCriacao = DateTime.Parse(form["data"]);
            

            using (StreamWriter sw = new StreamWriter("tarefa.csv", true)) {
                sw.WriteLine($"{tarefa.Id};{tarefa.Nome};{tarefa.Descricao};{tarefa.Tipo};{tarefa.IdUsuario};{tarefa.DataCriacao}");
            }

            ViewBag.Mensagem = "Tarefa Cadastrada com Sucesso";
            return View();
        }

        [HttpGet]
        public IActionResult ListarTarefas() {
            return View();
        }

        [HttpPost]
        public IActionResult ListarTarefas(IFormCollection form) {
            UsuarioModel usuario = new UsuarioModel();
            TarefaModel tarefa = new TarefaModel();
            using (StreamReader sr = new StreamReader("tarefa.csv")) {
                string[] linha = sr.ReadLine().Split(";");
                while (!sr.EndOfStream)
                {
                    if (usuario.Id == tarefa.IdUsuario)
                    {
                        
                    }
                }
            }
            return View();
        }
    }
}