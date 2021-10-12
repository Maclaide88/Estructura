using System;

namespace Tarea1
{
    class Program
    {
        static void Main()
        {
            float numero;
            Console.WriteLine("Ingrese un numero real (-1,1,0)");
            numero = (float)Convert.ToDouble(Console.ReadLine());
            Signo(numero);
        }

        public static void Signo(float numero)
        {
            if (numero==-1)
            {
                Console.WriteLine("El numero ingresado es Negativo");
            }
            else if (numero==1)
            {
                Console.WriteLine("El numero ingresado es Positivo");
            }
            else if (numero == 0)
            {
                Console.WriteLine("El numero ingresado es Cero");
            }
        }
    }
}
