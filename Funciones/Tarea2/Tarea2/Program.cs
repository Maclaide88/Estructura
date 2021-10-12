using System;

namespace Tarea2
{
    class Program
    {
        static void Main()
        {
            int numero1, numero2, resultado;
            Console.WriteLine("Ingrese un numero");
            numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese un segundo numero");
            numero2 = Convert.ToInt32(Console.ReadLine());
            resultado = Menor(numero1, numero2);
            if (resultado == 1)
            {
                Console.WriteLine("El primer numero ingresado es menor que el segundo");
            }
            else
            {
                Console.WriteLine("El segundo numero ingresado es menor que el primero");
            }
        }

        public static int Menor(int numero1, int numero2)
        {
            
            if (numero1 < numero2)
            {
                return 1;
            }
            else
            {
                return 0;
            }
            
        }
    }
}
