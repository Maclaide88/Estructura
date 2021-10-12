using System;

namespace Tarea3
{
    class Program
    {
        public static void Main(string[] args)
        {

            int num;
            Console.WriteLine("Escriba un número: ");
            num = Convert.ToInt32(Console.ReadLine());
            if (EsPrimo(num))
            {
                Console.WriteLine("Numero primo");
            }
            else
            {
                Console.WriteLine("No es numero primo");
            }

        }

        public static bool EsPrimo(int numero)
        {
            for (int i = 2; i < numero; i++)
            {
                if ((numero % i) == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
