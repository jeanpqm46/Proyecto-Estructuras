using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app_prueba
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nombre = { 2,1,};
            int busqueda = 1;
            int indice = Array.IndexOf(nombre, busqueda);
            if (indice == -1) {
                Console.WriteLine("El elemento {0} no existe",busqueda);

            }
            else
            {
                Console.WriteLine("El elemento{0} existe en la posicion {1}", busqueda, indice);
            }
        }
    }
}
