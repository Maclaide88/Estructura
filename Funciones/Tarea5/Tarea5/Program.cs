using System;

namespace Tarea5
{
    class Program
    {
        public static void Main()
        {
            int opcion,numero1,numero2;
            float resultado;
            Console.WriteLine("Elija una opcion: ");
            Console.WriteLine("Opcion 1. Sumar ");
            Console.WriteLine("Opcion 2. Restar");
            Console.WriteLine("Opcion 3. Multiplicar");
            Console.WriteLine("Opcion 4. Dividir");
            opcion = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese un numero");
            numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese otro numero");
            numero2 = Convert.ToInt32(Console.ReadLine());
            resultado = Calcular(numero1, numero2, opcion);
            Console.WriteLine("El resultado es {0}",resultado);
        }

        public static float Calcular(int numero1,int numero2,int opcion)
        {
            float resul;
            switch (opcion)
            {
                case 1:
                    resul = numero1 + numero2;
                    return resul;
                   
                case 2:
                    resul = numero1 - numero2;
                    return resul;
                   
                case 3:
                    resul = numero1 * numero2;
                    return resul;
                    
                case 4:
                    resul = numero1 / numero2;
                    return resul;

                default:
                    return 0;
                    break;
                   
            }

        }
    }
}
