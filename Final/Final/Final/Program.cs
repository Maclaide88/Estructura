using System;
using System.Collections;

namespace FINAL
{
    public class Program
    {

        static bool terminado = false;
        public static Stack miPila;
        public static void Main() //Funcion Principal
        {
            do
            {
                MostrarMenu();
                switch (LeerOpcion())
                {
                    case "1": CrearPila(); break;
                    case "2": BorrarPila(); break;
                    case "3": AgregarPatente(); break;
                    case "4": BorrarPatente(); break;
                    case "5": AgendarTurno(); break;
                    case "6": MostrarTurno(); break;
                    case "7": MostrarTurno(); break;
                    case "8": MostrarTurno(); break;
                    case "0": // Salir de la aplicación
                        Console.WriteLine();
                        Console.WriteLine("Saliendo...");
                        Console.WriteLine();
                        terminado = true;
                        break;
                    default:
                        Console.WriteLine();
                        Console.WriteLine("Opción incorrecta!");
                        Console.WriteLine();
                        break;
                }
            } while (!terminado);
        }
        public static void MostrarMenu() //Menú principal
        {
            Console.WriteLine("1- Crear Pila");
            Console.WriteLine("2- Borrar Pila");
            Console.WriteLine("3- Agregar Patente");
            Console.WriteLine("4- Borrar Patente");
            Console.WriteLine("5- Listar todas las Patentes");
            Console.WriteLine("6- Listar ultima Patente");
            Console.WriteLine("7- Listar primera Patente");
            Console.WriteLine("8- Cantidad de Patentes");
            Console.WriteLine("0- Salir");
        }
        public static string LeerOpcion() //ingreso de opción del menú principal
        {
            Console.Write("Escoja una opción: ");
            string opcion = Console.ReadLine();
            Console.WriteLine();
            return opcion;
        }
        public static void CrearPila()
        {
            Console.WriteLine("Crando Pila...");
            Stack miPila = new Stack();
        }
        public static void BorrarPila(ref Stack miPila)
        {
            Console.WriteLine("Crando Pila...");
            miPila.Clear();
        }
        public static void AgregarPatente(ref Stack miPila)
        {
            string patente = Console.ReadLine();
            miPila.Push(patente);
            Console.WriteLine("{0}", miPila);
        }
    }
}
