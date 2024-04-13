using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class CalculadoraCientifica : Calculadora
    {
        public CalculadoraCientifica() { }
        public CalculadoraCientifica(int serie, string marca)
        {
            this.Serie = serie;
            this.Marca = marca;
        }
        public double Potencia(int num1, int num2)
        {
            try
            {

                return Math.Pow(num1,num2);
            }
            catch
            {
                Console.WriteLine("insertaste un texto o numero invalido");
                return 0;
            }
        }
        public double Raiz(int num1)
        {
            try
            {
                return Math.Sqrt(num1);
            }
            catch
            {
                Console.WriteLine("insertaste un texto o numero invalido");
                return 0;
            }
        }
        public double modulo(int num1, int num2)
        {
            try
            {
                return num1%num2;
            }
            catch
            {
                Console.WriteLine("insertaste un texto o numero invalido");
                return 0;
            }
        }
        public double Logaritmo(double num1, double num2)
        {
            try
            {
                return Math.Log(num1,num2);
            }
            catch
            {
                Console.WriteLine("insertaste un texto o numero invalido");
                return 0;
            }
        }
    }
}
