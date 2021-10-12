using System;

namespace Tarea6
{
    class Program
    {
        static void Main()
        {
            int a, b, c;
            a = 5; 
            b = ++a; 
            c = a++; 
            b = b * 5;
            a = a * 2;

            Console.WriteLine("El resultado de a es: {0}, de b es: {1} y de c es: {2}", a,b,c);
        }
    }
}
