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
            Console.WriteLine("Ingrese el segundo numero");
            b = Convert.ToInt32(Console.ReadLine());
            if (a > b)
                Console.WriteLine("El numero {0} es mayor a {1}", a, b);
            else
                Console.WriteLine("El numero {1} es mayor a {0}", a, b);
        }
    }
}