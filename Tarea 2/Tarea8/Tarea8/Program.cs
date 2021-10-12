using System;

namespace Tarea8
{
    class Program
    {
        static void Main()
        {
            string l;
            Console.WriteLine("Introduzca una Letra");
            l = Console.ReadLine();
            if (l=="a" || l=="e" || l == "i" || l == "o" || l == "u")
            {
                Console.WriteLine("La letra es una Vocal");
            }
            else
            {
                Console.WriteLine("La letra NO es una Vocal");
            }
        }
    }
}
