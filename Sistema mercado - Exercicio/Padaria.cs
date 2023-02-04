using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_mercado___Exercicio
{
    public class Padaria
    {
        public List<Produtos> produtosPadaria = new List<Produtos>();

        public Produtos ProdutosSet
        {
            set { 
                if (!produtosPadaria.Contains(value))
                {
                    produtosPadaria.Add(value);
                } else
                {
                    return;
                }
            }
        }
        public List<Produtos> ProdutosGet
        {
            get { return produtosPadaria; }
        }


    }
}
