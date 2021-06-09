using System;
using System.Collections.Generic;

namespace ProjetoProdutos.Classes
{
    public class Usuario
    {
        private int Codigo { get; set; }
        private string Email { get; set; }
        private string Nome { get; set; }
        private string Senha { get; set; }
        private DateTime DataCadastro { get; set; }
        //List<Usuario> listaUsuarios = new List<Usuario>();

        //public Usuario()
        //{}
        //public Usuario(string _email, string _nome, string _senha)
        //{   
            //this.Codigo = 1;
            //this.Email = _email;
            //this.Senha = _senha;
            //this.Nome = _nome;
           // this.DataCadastro = DateTime.Now;
        //}

        //public string Cadastrar(Usuario usuario)
        //{
           // listaUsuarios.Add(usuario);
        //    return "Usuario cadastrado com sucesso!";
        //}

        //public string Deletar(Usuario usuario)
       // {
            //listaUsuarios.Remove(usuario);
            //return ("Usuario deletado com sucesso!");
        //}
    }
}