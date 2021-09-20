using System;

namespace Tarea7
{
    public class Program
    {
        public static void Main()
        {
            int a;
            int b;
            Console.WriteLine("Ingrese el primer numero");
            a = Convert.ToInt32(Console.ReadLine());
            if (a % 2 == 0)
                Console.WriteLine("El numero {0} es par", a);
            else
                Console.WriteLine("El numero {0} es impar", a);
        }
    }
}