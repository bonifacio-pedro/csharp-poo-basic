using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_mercado___Exercicio
{
    public class Acougue
    {
        private List<Produtos> produtosAcouge = new List<Produtos>();
        public Produtos ProdutosSet
        {
            set
            {
                if (!produtosAcouge.Contains(value))
                {
                    produtosAcouge.Add(value);
                }
                else
                {
                    return;
                }
            }
        }
        public List<Produtos> ProdutosGet
        {
            get { return produtosAcouge; }
        }
    }

}
