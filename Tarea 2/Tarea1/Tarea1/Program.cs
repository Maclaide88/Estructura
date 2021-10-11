using System;

namespace Tarea1
{
    public class Program
    {
        static void Main()
        {
            int id;
            int clave;

            Console.WriteLine("Introduzca su Identeficador: ");
            id = Convert.ToInt32(Console.ReadLine());

            while (id != 1234)
            {

                Console.WriteLine("Su identificacion es erronea, vuelva a intentar");
                Console.WriteLine("Introduzca su Identeficador: ");
                id = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("Introduzca su clave: ");
            clave = Convert.ToInt32(Console.ReadLine());

            while (clave != 1111)
            {

                Console.WriteLine("Su clave es erronea, vuelva a intentar");
                Console.WriteLine("Introduzca su clave: ");
                clave = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("EXITO!");
        }
    }
}
