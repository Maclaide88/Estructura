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
            if (b != 0)
                Console.WriteLine("La division de {0} y {1} es: {2}", a, b, a/b);
            else
                Console.WriteLine("Error: No se puede dividir entre cero");
        }
    }
}