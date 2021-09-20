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
            Console.WriteLine("El producto del primer numero y el segundo da por resultado: {0}", a * b);
        }
    }
}
