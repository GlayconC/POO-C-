using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Produto
    {
        public int id;
        public string descricao;
        public double preco;

        public void aumentaPreco(double percentual)
        {
            preco = ((preco * percentual) / 100) + preco;
        }
    }
}
