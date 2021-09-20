using System;

namespace Tarea13
{
    public class Program
    {
        public static void Main()
        {
            int a;
         
            Console.WriteLine("Ingrese un numero del 1 al 5");
            a = Convert.ToChar(Console.ReadLine());
            switch (a)
            {
                case '1': 
                    Console.Write("Usted ingreso uno");
                    break;
                case '2':
                    Console.Write("Usted ingreso dos");
                    break;
                case '3':
                    Console.Write("Usted ingreso tres");
                    break;
                case '4':
                    Console.Write("Usted ingreso cuatro");
                    break;
                case '5':
                    Console.Write("Usted ingreso cinco");
                    break;
                default:
                    Console.Write("Error: Ingreso un numero distiro del 1 al 5");
                    break;
            }
        }
    }
}
