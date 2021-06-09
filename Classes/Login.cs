using System;
using System.Collections.Generic;

namespace ProjetoProdutos.Classes
{
    public class Login
    {
        private bool Logado { get; set; } = false;
        public bool sair { get; set; } = false;
        Marca listaMarcas = new Marca();
        Produto ListaDeProdutos = new Produto();


        public Login()
        {
            Console.WriteLine("Bem vindo ao sistema!");
            Console.WriteLine("VocÊ não possui uma conta! \n Redirecionando ao cadastro de usuario");

            Console.WriteLine("Insira seu email");
            string email = Console.ReadLine();
            Console.WriteLine("Insira sua senha");
            string senha = Console.ReadLine();
            Console.WriteLine("Insira seu nome");
            string nome = Console.ReadLine();

            Usuario novoUsuario = new Usuario(email, nome, senha);
            novoUsuario.Cadastrar(novoUsuario);
            do
            {
                Console.WriteLine("Login:");
                Console.WriteLine("Insira seu email");
                string testarEmail = Console.ReadLine();
                Console.WriteLine("Insira sua senha");
                string testarSenha = Console.ReadLine();

                if (testarEmail == email)
                {
                    if (testarSenha == senha)
                    {
                        Logar();

                        do
                        {


                            Console.WriteLine(@"
                    
                    __________________________________
                    |                                |
                    |       1- Adicionar produto     |
                    |       2- Remover produto       |
                    |       3- Listar produtos       |
                    |       4- Deslogar              |
                    |________________________________|                    
                    ");
                            int opcao1 = int.Parse(Console.ReadLine());

                            switch (opcao1)
                            {
                                case 1:

                                    Console.WriteLine(@"
                    
                    __________________________________
                    |                                |
                    |       1- Cadastrar Marca       |
                    |       2- Deletar Marca         |
                    |       3- Listar Marca          |
                    |________________________________|                    
                    ");
                                    int opcao2 = int.Parse(Console.ReadLine());
                                    switch (opcao2)
                                    {
                                        case 1:
                                            Console.WriteLine("Insira o código da marca");
                                            int codigoM = int.Parse(Console.ReadLine());
                                            Console.WriteLine("Insira o nome da marca");
                                            string nomeM = Console.ReadLine();
                                            Marca novaMarca = new Marca(codigoM, nomeM, nome);

                                            novaMarca.CadastrarMarca(novaMarca);

                                            Console.WriteLine("Insira o nome do produto");
                                            string nomeP = Console.ReadLine();
                                            Console.WriteLine("Insira o preço do produto");
                                            float precoP = float.Parse(Console.ReadLine());
                                            Produto novoProduto = new Produto(nomeP, precoP, novaMarca, novoUsuario);
                                            novoProduto.Cadastrar(novoProduto);


                                            break;
                                        case 2:
                                            Console.WriteLine("Insira o código da marca que deseja excluir");
                                            codigoM = int.Parse(Console.ReadLine());
                                            Marca marcaDeletada = new Marca(codigoM);
                                            listaMarcas.DeletarMarca(marcaDeletada);
                                            break;
                                        case 3:
                                            listaMarcas.Listar();
                                            break;
                                        default:
                                            break;
                                    }

                                    break;
                                case 2:

                                    Console.WriteLine("Insira o nome do produto que deseja excluir");
                                    string nomeProduto = Console.ReadLine();
                                    Produto produtoDeletado = new Produto(nomeProduto);
                                    ListaDeProdutos.Deletar(produtoDeletado);
                                    break;
                                case 3:
                                    ListaDeProdutos.Listar();
                                    break;
                                case 4:
                                    Deslogar();
                                    sair = true;
                                    Logado = false;
                                    break;
                                default:
                                    break;
                            }
                        } while (sair == false);

                    }
                    else
                    {
                        Console.WriteLine("Senha inválida!");
                        Logado = true;
                    }
                }
                else
                {
                    Console.WriteLine("Email inválido!");
                    Logado = true;
                }
            } while (Logado == true);
        }

        public string Logar()
        {
            Logado = true;
            return ("Logando...");
        }

        public string Deslogar()
        {
            Logado = false;
            return ("Deslogando...");
        }
    }
}