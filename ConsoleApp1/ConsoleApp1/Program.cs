using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto prod = new Produto();
            prod.id = 11;
            prod.descricao = "Celular";
            prod.preco = 1500.55;

            Console.WriteLine("Id do produto: " + prod.id);
            Console.WriteLine("Id do produto: " + prod.descricao);
            Console.WriteLine("Id do produto: " + prod.preco);

            prod.aumentaPreco(10);

            Console.WriteLine("Preço aumentado = " + prod.preco);

            Calculadora calc = new Calculadora();
            int resultadoSoma = calc.soma(15, 11);
            Console.WriteLine("Soma 15 + 11 = " + resultadoSoma);

            Console.WriteLine("Multiplicação 5 X 300 = " + calc.multiplicacao(5, 300));

            Console.WriteLine("23 é maior que 4? " + calc.maior(24, 3));

            calc.imprime("Sistemas de Informação");

            Produto prod2 = new Produto();
            prod2.id = 11;
            prod2.descricao = "Celular";
            prod2.preco = 1500.55;

            Console.WriteLine("Produto 2");
            prod2.aumentaPreco(50);

            Console.WriteLine("Id do produto: " + prod2.id);
            Console.WriteLine("Id do produto: " + prod2.descricao);
            Console.WriteLine("Id do produto: " + prod2.preco);

            Console.ReadKey();
        }
    }


}
