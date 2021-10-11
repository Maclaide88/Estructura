using System;

namespace Tarea3
{
    class Program
    {
        public static void Main(string[] args)
        {
            int number = 9;
            Console.WriteLine("La tabla del 9 es:");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(number + "x" + i + "=" + (i * number));
            }

        }
    }
}

