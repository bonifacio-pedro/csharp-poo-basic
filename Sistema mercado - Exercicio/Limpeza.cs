using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_mercado___Exercicio
{
    public class Limpeza
    {
        private List<Produtos> produtosLimpeza = new List<Produtos>();
        public Produtos ProdutosSet
        {
            set
            {
                if (!produtosLimpeza.Contains(value))
                {
                    produtosLimpeza.Add(value);
                }
                else
                {
                    // retorna nulo
                    return;
                }
            }
        }
        public List<Produtos> ProdutosGet
        {
            get { return produtosLimpeza; }
        }
    }
}
