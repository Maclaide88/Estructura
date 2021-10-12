using System;

namespace Tarea7
{
    class Program
    {
        static void Main()
        {
            int a, b, c;
            a = 5;
            b = a + 2;
            b -= 3;
            c = -3;
            c *= 2;
            ++c;
            a *= b;

            Console.WriteLine("El resultado de a es: {0}, de b es: {1} y de c es: {2}", a, b, c);
        }
    }
}