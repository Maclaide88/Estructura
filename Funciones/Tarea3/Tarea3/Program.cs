using System;

namespace Tarea3
{
    class Program
    {
        static void Main()
        {
            int numero;
            bool resultado;
            Console.WriteLine("Ingrese un numero");
            numero = Convert.ToInt32(Console.ReadLine());
            resultado = EsPrimo(numero);
            if (resultado == true)
            {
                Console.WriteLine("El numero es primo");
            }
            else
            {
                Console.WriteLine("El numero no es primo");
            }
        }

        public static bool EsPrimo(int numero)
        {
            int i;
            bool resultado;
            for (i = 2; i < numero; i++)
            {
                if (numero % i == 0)
                {
                    resultado= true;
                }
            }

        }
    }
}
