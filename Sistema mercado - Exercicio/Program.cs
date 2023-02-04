using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_mercado___Exercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool saida = false;
            Padaria produtoPadaria = new Padaria();
            Acougue produtoAcouge = new Acougue();
            Limpeza produtoLimpeza = new Limpeza();

            do
            {
                Sistema.SistemaRodar(ref saida, produtoPadaria, produtoAcouge, produtoLimpeza);
            } while (!saida);
            
        }
    }
}
