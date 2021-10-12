using System;

namespace Tarea10
{
    class Program
    {
        static void Main()
        {
            string usuario;
            Console.WriteLine("Ingrese su nombre de Usuario: ");
            usuario=Console.ReadLine();
            if (usuario == "Martin")
            {
                Console.WriteLine("Hola");
            }
            else
            {
                Console.WriteLine("No te conozco");
            }

        }
    }
}
