using System;
using System.Collections.Generic;

namespace ProjetoProdutos.Classes
{
    public class Marca
    {
        public string QuemCadastrou { get; set; }
        private int CodigoM { get; set; }
        private string NomeM { get; set; }
        private DateTime DataCadastro { get; set; }

        List<Marca> listaMarcas = new List<Marca>();

        public Marca()
        {}
        public Marca(int _codigoM, string _nomeM, string _quemCadastrou)
        {
            this.CodigoM = _codigoM;
            this.NomeM = _nomeM;
            this.DataCadastro = DateTime.Now;
            this.QuemCadastrou = _quemCadastrou;
        }

        public Marca(int codigoDeletar)
        {
            this.CodigoM = codigoDeletar;
        }

        public string CadastrarMarca(Marca _marca)
        {
            listaMarcas.Add(_marca);
            return "Marca cadastrada com sucesso!";
        }

        public string DeletarMarca(Marca _marca)
        {
            listaMarcas.Remove(listaMarcas.Find(x => x.CodigoM == CodigoM));
            return "Marca deletada com sucesso!";
        }

        public List<Marca> Listar()
        {
            Console.WriteLine("Lista de Marcas");
            foreach (Marca item in listaMarcas)
            {
                Console.WriteLine($"Codigo:{item.CodigoM} - Nome:{item.NomeM} - Data de Cadastro:{item.DataCadastro} - Responsável pelo cadastro:{item.QuemCadastrou}");
            }
            return listaMarcas;
        }
    }
}