using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Senai.Financas.Web.Mvc.Models;
using Senai_Financas_Mvc_Web_master.Interfaces;

namespace Senai_Financas_Web_Mvc_Manha.Repositorios
{
    public class UsuarioRepositorioSerializado : IUsuario
    {
        /// <summary>
        /// Lista que será serializada que contem todos os usuários cadastrados
        /// </summary>
        public List<UsuarioModel> usuariosSalvos {get; private set;}

        public UsuarioRepositorioSerializado()
        {
            if (File.Exists("usuarios.dat"))
            {
                usuariosSalvos = Listar();
            }
            else
            {
                usuariosSalvos = new List<UsuarioModel>();    
            }
        }
        public UsuarioModel BuscarPorId(int id)
        {
            //le o arquivo serializado
            List<UsuarioModel> usuarios = Listar();
            foreach (var item in usuarios)
            {
                if (item.Id == id)
                {
                    return item;
                }
            }

            //caso no seja encontrado ninguém retorna null
            return null;
        }

        public int BuscarPosicaoPorId(int id)
        {
            //le o arquivo serializado
            List<UsuarioModel> usuarios = Listar();
            int indice = 0;
            foreach (var item in usuarios)
            {
                if (item.Id == id)
                {
                    return indice;
                }
                indice++; // marca para a próxima posição
            }

            //caso no seja encontrado ninguém retorna null
            return -1;
        }

        public UsuarioModel Cadastrar(UsuarioModel usuario)
        {
            usuario.Id = usuariosSalvos.Count + 1;
            //Adiciona o usuario na lista para ser serializado
            usuariosSalvos.Add(usuario);

            //Serializa a lista novamente pois devemos escrever novamente a lista com usuário removido
            SerializarLista();

            return usuario;
        }

        //Serializa a lista de usuários salvos
        private void SerializarLista()
        {
            //realizando a serialização
            MemoryStream memoria = new MemoryStream();
            BinaryFormatter serializador = new BinaryFormatter();

            //serializa e guarda os dados dentro do MemoryStream
            serializador.Serialize(memoria, usuariosSalvos);

            File.WriteAllBytes("usuarios.dat", memoria.ToArray());
        }

        public UsuarioModel Editar(UsuarioModel usuario)
        {
            throw new System.NotImplementedException();
        }

        public void Excluir(int id)
        {
            //Busca o usuario pelo id
            int posicaoUsuarioBuscado = BuscarPosicaoPorId(id);

            //se encontrou a posição...
            if (posicaoUsuarioBuscado >= 0)
            {
                //remove pela posição encontrada
                usuariosSalvos.RemoveAt(posicaoUsuarioBuscado);
            }
        }



        public List<UsuarioModel> Listar()
        {
            //Trantando caso o arquivo não exista
            if (!File.Exists("usuarios.dat"))
            {
                //Retorna um lista vazia
                return new List<UsuarioModel>();
            }
            //Ler os bytes que estão gravados no usuarios.dat
            byte[] bytesSerializado = File.ReadAllBytes("usuarios.dat");

            //Desserializar com o serializador
            BinaryFormatter serializador = new BinaryFormatter();

            //passa os bytes para memory Stream
            MemoryStream memoria = new MemoryStream(bytesSerializado);
            return (List<UsuarioModel>) serializador.Deserialize(memoria);
        }

        public UsuarioModel Login(string email, string senha)
        {
            throw new System.NotImplementedException();
        }
    }
}