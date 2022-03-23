using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Calculadora
    {
        public int soma(int num1, int num2){
            return num1 + num2;
        
        }

        public double multiplicacao(double num1, double num2)
        {
            double resultado = num1 * num2;
            return resultado;
        }

        public bool maior(int num1, int num2)
        {
            if (num1 > num2)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public void imprime( string texto)
        {
            Console.WriteLine("Texto: " + texto);
        }
    }
}
