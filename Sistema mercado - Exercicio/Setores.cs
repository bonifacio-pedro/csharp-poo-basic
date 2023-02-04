using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_mercado___Exercicio
{
    public struct Produtos
    {
        public string nome;
        public uint quantidade;
    }

    public enum Setores_e
    {
        PADARIA = 0,
        ACOUGUE = 1,
        LIMPEZA = 2
    }

    public class Sistema
    {
        public static void MostrarProdutosCadastrados(List<Produtos> produtos)
        {
            Console.Clear();
            foreach (Produtos produto in produtos)
            {
                Console.WriteLine("<------------------------------------->");
                Console.WriteLine("> NOME PRODUTO: " + produto.nome);
                Console.WriteLine("> QUANTIDADE PRODUTO: " + produto.quantidade);
                Console.WriteLine("<------------------------------------->");
            }
        }

        public static Produtos CadastraProduto()
        {
            Console.Clear();
            Console.Write("DIGITE O NOME DO PRODUTO: ");
            string nomeTemp = Console.ReadLine();
            Console.Write("DIGITE A QUANTIDADE DO PRODUTO: ");
            uint quantidadeTemp = Convert.ToUInt32(Console.ReadLine());

            Produtos produto;
            produto.nome = nomeTemp;
            produto.quantidade = quantidadeTemp;

            return produto;

        }
        public static Setores_e EscolhaSetor()
        {
            Console.Clear();
            Console.WriteLine("-> SETORES <-");
            Console.WriteLine("(1)  PADARIA");
            Console.WriteLine("(2)  AÇOUGE");
            Console.WriteLine("(3)  LIMPEZA");

            char escolhaTemp = Convert.ToChar(Console.ReadKey(true).KeyChar.ToString().ToLower());

            try
            {
                if (escolhaTemp == '1')
                {
                    return Setores_e.PADARIA;
                }
                else if (escolhaTemp == '2')
                {
                    return Setores_e.ACOUGUE;
                }
                else if (escolhaTemp == '3')
                {
                    return Setores_e.LIMPEZA;
                }
                else
                {
                    throw new Exception("SETOR INEXISTENTE");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("TIVEMOS UMA EXCEÇÃO: " + ex.Message);
                return 0;
            }
        }


        public static void SistemaRodar(ref bool saida, Padaria produtoPadaria, Acougue produtoAcougue, Limpeza produtoLimpeza)
        {

            Console.WriteLine("---> MENU <---");
            Console.WriteLine("(1)  CADASTRAR PRODUTOS");
            Console.WriteLine("(2)  VER PRODUTOS");
            Console.WriteLine("(3)  SAIR");
            Console.WriteLine("---> MENU <---");
            char escolhaTemp = Convert.ToChar(Console.ReadKey(true).KeyChar.ToString().ToLower());

            try
            {
                if (escolhaTemp == '1')
                {
                    if(EscolhaSetor() == Setores_e.PADARIA)
                    {
                        Produtos produto = CadastraProduto();
                        produtoPadaria.ProdutosSet = produto;
                    }
                    else if (EscolhaSetor() == Setores_e.ACOUGUE)
                    {
                        Produtos produto = CadastraProduto();
                        produtoAcougue.ProdutosSet = produto;
                    }
                    else if (EscolhaSetor() == Setores_e.LIMPEZA)
                    {
                        Produtos produto = CadastraProduto();
                        produtoLimpeza.ProdutosSet = produto;
                    }
                }
                else if (escolhaTemp == '2')
                {
                    if(EscolhaSetor() == Setores_e.PADARIA)
                    {
                        MostrarProdutosCadastrados(produtoPadaria.ProdutosGet);
                    }
                    else if(EscolhaSetor() == Setores_e.ACOUGUE)
                    {
                        MostrarProdutosCadastrados(produtoAcougue.ProdutosGet);
                    }
                    else if(EscolhaSetor() == Setores_e.LIMPEZA)
                    {
                        MostrarProdutosCadastrados(produtoLimpeza.ProdutosGet);
                    }
                    else
                    {
                        throw new Exception("ESCOLHA INVÁLIDA");
                    }
                }
                else if (escolhaTemp == '3')
                {
                    saida = true;
                }
                else
                {
                    throw new Exception("ESCOLHA INVÁLIDA");
                }
            } catch (Exception ex)
            {
                Console.WriteLine("TIVEMOS UMA EXCEÇÃO: " + ex.Message);
            }
            
        }
    }
  
}
