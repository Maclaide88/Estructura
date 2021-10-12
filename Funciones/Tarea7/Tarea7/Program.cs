using System;

namespace Tarea7
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Ingrese una letra");
            string l = Console.ReadLine();
            Console.WriteLine("Ingrese una numero");
            int a = Convert.ToInt32(Console.ReadLine());
            for (int i = a; i >= 0; i--)
            {
                for (int b = 0; b < i; b++)
                {
                    Console.Write("{0}", l);
                }
                Console.WriteLine();
            }
        }
    }
}
