using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Calculadora
    {
        protected int Serie {  get; set; }
        protected string Marca { get; set; }


        public Calculadora() { }
        public Calculadora(int serie, string marca)
        {
            this.Serie = serie; 
            this.Marca = marca;
        } 

        public void Datos()
        {
            Console.WriteLine("Marca {0} - Serie {1}", this.Marca, this.Serie);
        }
        public double Sumar(double num1, double num2)
        {
            return num1 + num2;
        }
        public double Restar(double num1, double num2)
        {
            return num1 - num2;
        }
        public double Multiplicar(double num1, double num2)
        {
            return num1 * num2;
        }
        public double Dividir(double num1 , double num2)
        {
            try
            {
                return num1 / num2;
            }
            catch
            {
                Console.WriteLine("insertaste un texto o numero invalido");
                return 0;
            }
        }
    }
    
}
