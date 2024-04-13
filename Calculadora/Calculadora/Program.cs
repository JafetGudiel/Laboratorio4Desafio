using Calculadora;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraHerencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine("                            CALCULADORA                          ");
            Console.WriteLine("--------------------------------------------------------------------------");
            CalculadoraCientifica suma1 = new CalculadoraCientifica(870001,"Casio");
            CalculadoraCientifica Resta1 = new CalculadoraCientifica(86557,"Nokia");
            CalculadoraCientifica Multiplicacion1 = new CalculadoraCientifica(9812704,"Casio");
            CalculadoraCientifica Division1 = new CalculadoraCientifica(5254354,"Helect");
            CalculadoraCientifica Potencia1 = new CalculadoraCientifica(001726,"Hp");
            CalculadoraCientifica Raiz1 = new CalculadoraCientifica(25345,"Casio");
            CalculadoraCientifica Modulo1 = new CalculadoraCientifica(8757,"Hp");
            CalculadoraCientifica Log1 = new CalculadoraCientifica(64254,"Helect");


            suma1.Datos();
            Console.WriteLine("El total de la Suma es de: {0}", suma1.Sumar(8, 12));
            Resta1.Datos();
            Console.WriteLine("El total de la Resta es de: {0}", Resta1.Restar(100,22));
            Multiplicacion1.Datos();
            Console.WriteLine("El total de la Multiplicacion es de: {0}", Multiplicacion1.Multiplicar(8, 7));
            Division1.Datos();
            Console.WriteLine("El total de la Division es de: {0}", Division1.Dividir(49, 7));
            Potencia1.Datos();
            Console.WriteLine("El total de la Potencia es de: {0}", Potencia1.Potencia(3, 5));
            Raiz1.Datos();
            Console.WriteLine("El total de la Raiz cuadrada es de: {0}", Raiz1.Raiz(25));
            Modulo1.Datos();
            Console.WriteLine("El total del modulo es de: {0}", Modulo1.modulo(78, 4));
            Log1.Datos();
            Console.WriteLine("El total del Logaritmo es de: {0}", Log1.Logaritmo(88, 6));
            Console.ReadLine();

        }
    }
}
