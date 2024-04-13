using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaAlumnos
{
    class InformacionEstudiante
    {
        static void Main(string[] args)
        {
            List<Estudiante> listaEstudiantes = new List<Estudiante>();

            Console.WriteLine("-----------------------------BIENVENIDO AL PROGRAMA DE LISTA DE ALUMNOS-------------------------------\n");

            while (true)
            {
                Console.WriteLine("Ingrese el nombre del estudiante: (presione Enter para Finalizar)");
                string nombre = Console.ReadLine();

                if (nombre.Equals(""))
                    break;  

                Console.WriteLine("Ingrese la Edad del estudiante:");
                int edad = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese el Carnet del estudiante:");
                string carnet = Console.ReadLine();

                Console.WriteLine("¿El estudiante está solvente? :");
                string solvente = Console.ReadLine();
                if(solvente.Equals("si") || solvente.Equals("SI"))
                {
                    solvente = "SI";
                }else if (solvente.Equals("no") || solvente.Equals("NO"))
                {
                    solvente="NO";
                }

                Estudiante nuevoEstudiante = new Estudiante(nombre, edad, carnet, solvente);
                listaEstudiantes.Add(nuevoEstudiante);
            }

            Console.WriteLine("\nLista de Estudiantes:");
            foreach (var estudiante in listaEstudiantes)
            {
                estudiante.ImprimirDatos();
            }
            Console.Read();
        }
    }
    class Estudiante
    {
        private string Nombre { get; set; }
        private int Edad { get; set; }
        private string Carnet { get; set; }
        private string Solvente { get; set; }

        public Estudiante(string nombre, int edad, string carnet, string solvente)
        {
            Nombre = nombre;
            Edad = edad;
            Carnet = carnet;
            Solvente = solvente;
        }

        public void ImprimirDatos()
        {
            Console.WriteLine("Nombre: {0}, Edad: {1}, Carnet: {2}, Solvente: {3}", Nombre, Edad, Carnet, Solvente);
        }
    }

}


