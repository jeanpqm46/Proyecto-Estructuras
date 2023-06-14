using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppProyecto2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // crear una matriz de 5*5
            int[,] matriz = new int[5, 5];

            // crear una instancia de generador de números aleatorios
            Random rnd = new Random();


            // llenar matriz con números aleatorios
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matriz[i, j] = rnd.Next(1, 201); // Generador número aleatorio entre 1 y 200

                }
            }

            // Imprimir matriz original
            Console.WriteLine("Matriz original: ");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }

            // Sumatoria de las esquinas de la matriz
            int Suma = matriz[0, 0] + matriz[0, 4] + matriz[4, 0] + matriz[4, 4];

            // Imprimir sumatoria de las esquinas de la matriz
            Console.WriteLine("La sumatoria de las esquinas es: " + Suma);

            Console.ReadLine();
        }
    }
}
