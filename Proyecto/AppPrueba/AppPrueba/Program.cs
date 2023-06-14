using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPrueba
{
    internal class Program
    {
        static string[] NomProvedores = new string[] {"Fernando","Oscar","Douglas","Pedro","Julio","Carlos","Andrea","Sofia","Katia","luis"};
        static string[] CuidadP = new string[20] ;
        static int[] ArticulosP = new int[20] ;
        static int opcion = 0;
        static int opcion2 = 0;
        //static string Buscarnombre;
        static string nombre;
        static int i = 0;
        static int  actuarticulo = 0;
        static void Main(string[] args)
        {
            Array.Sort(NomProvedores);
            MostrarMenu();
            Console.WriteLine("Digite cualquier tecla para finalizar ");
            Console.ReadKey();
            Environment.Exit(0);
        }
        static void MostrarMenu()
        {
            string opciones = "Aplicaion Provedores\n";
            opciones += "1. Informar ciudad y articulo de un provedor\n";
            opciones += "2. Actualizar cuidad\n";
            opciones += "3. Actualizar articulos\n";
            opciones += "4. Resgistrar un nuevo provedor\n";
            opciones += "5. Dar de baja a un provedor\n";
            opciones += "6. Salir\n";
            opciones += "Digite una opcion:";
            do
            {
                Console.WriteLine(opciones);
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine(CuidadP[1]);
                        Informar();
                        
                        break;
                    case 2:
                        Actualizarcuidad();
                        break;
                    case 3:
                      
                        Actualizararticulo();   
                        break;
                    case 4:
                        RegistrarNuevo();
                        break;
                    case 5:
                        DarDeBaja();    
                        break;
                    case 6:
                        for (int i = 0; i < NomProvedores.LongLength; i++)
                        {
                            Console.WriteLine(NomProvedores[i]);
                            Console.WriteLine(CuidadP[i]);
                            Console.WriteLine(ArticulosP[i]);

                        }
                        Console.WriteLine("Gracias por utilizar la app");
                        break;


                }
            } while (opcion != 6);

        }
        static void Informar()
        {
           
            Console.WriteLine("Escriba el nombre del provedor");
            nombre = Console.ReadLine();

            for (int i = 0; i < NomProvedores.LongLength; i++)
            {
                if (NomProvedores[i] == nombre)
                {
                    Console.WriteLine("Digite la cuidad del provedor");
                   CuidadP[i]= Console.ReadLine();
                   Console.WriteLine("Digite el numero de articulos");
                    ArticulosP[i] = int.Parse(Console.ReadLine());

                }

            }


        
        }
        static void Actualizarcuidad()
        {
            Console.WriteLine("Escriba el nombre del provedor");
            nombre = Console.ReadLine();

            for (int i = 0; i < NomProvedores.LongLength; i++)
            {
                if (NomProvedores[i] == nombre)
                {
                    Console.WriteLine("Digite la nueva cuidad del provedor");
                    CuidadP[i] = Console.ReadLine();
                   

                }

            }
        }
        static void Actualizararticulo()
        {
            
            Console.WriteLine("Escriba el nombre del provedor");
            nombre = Console.ReadLine();

            for (int i = 0; i < NomProvedores.LongLength; i++)
            {
                if (NomProvedores[i] == nombre)
                {

                    Console.WriteLine("Digite la opcion deseada ");
                    Console.WriteLine("1- Aumentar cantidad de producto");
                    Console.WriteLine("2- Dismunuir cantidad de producto");
                    opcion2 = int.Parse(Console.ReadLine());
                    if (opcion2 == 1) {
                        Console.WriteLine("Digite cuanto aumenta el total de articulos");
                        actuarticulo = int.Parse(Console.ReadLine());

                        ArticulosP[i] = ArticulosP[i] + actuarticulo;
                    }
                    else if (opcion2==2) 
                    {
                        Console.WriteLine("Digite cuanto disminuye el total de articulos");
                        actuarticulo = int.Parse(Console.ReadLine());

                        ArticulosP[i] = ArticulosP[i] - actuarticulo;
                    }
                }

                

            }
        }
        static void RegistrarNuevo()
        {

        }
        static void DarDeBaja()
        {
            Console.WriteLine("Escriba el nombre del provedor que desea dar de baja");
            nombre = Console.ReadLine();

            for (int i = 0; i < NomProvedores.LongLength; i++)
            {
                if (NomProvedores[i] == nombre)
                {
                    NomProvedores[i] = "";
                    CuidadP[i] = "";
                    ArticulosP[i] = 0;


                }

            }
        }
    }
}





