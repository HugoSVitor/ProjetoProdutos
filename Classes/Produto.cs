using System;
using System.Collections.Generic;

namespace ProjetoProdutos.Classes
{
    public class Produto
    {
        private int Codigo { get; set; }

        private string NomeProduto { get; set; }

        private float PrecoProduto { get; set; }

        private DateTime DataCadastro { get; set; }

        private Marca Marca { get; set; }

        private Usuario CadastradoPor { get; set; }
        private List<Produto> ListaDeProdutos { get; set; }

        public Produto()
        {}
        public Produto(string _nomeProduto, float _precoProduto, Marca _marca, Usuario _quemCadastrou)
        {
            this.NomeProduto = _nomeProduto;
            this.PrecoProduto = _precoProduto;
            this.Marca = _marca;
            this.DataCadastro = DateTime.Now;
        }

        public Produto(string _nomeProduto)
        {}

        public string Cadastrar(Produto _produto)
        {
            ListaDeProdutos.Add(_produto);

            return ("Produto cadastrado com sucesso!");
        }

        public string Deletar(Produto _produtoDeletado)
        {
            ListaDeProdutos.Remove(ListaDeProdutos.Find(x => x.NomeProduto == NomeProduto));
            return ("Produto deletado com sucesso!");
        }

        public List<Produto> Listar()
        {
            Console.WriteLine("Lista de Marcas");
            foreach (Produto item in ListaDeProdutos)
            {
                Console.WriteLine($"Nome:{item.NomeProduto} - Data de Cadastro:{item.DataCadastro} - Responsável pelo cadastro:{item.CadastradoPor} - Marca :{item.Marca}");
            }
            return ListaDeProdutos;
        }
    }
}