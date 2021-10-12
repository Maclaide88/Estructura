using System;

namespace Tarea9
{
    class Program
    {
        static void Main()
        {
            string usuario,pass1,pass2;
            pass2 = "";
            pass1 = "1";
            Console.WriteLine("Introduzca el usuario: ");
            usuario = Console.ReadLine();
            
            while (pass2 != pass1)
            {
                Console.WriteLine("Introduzca la contraseña: ");
                pass1 = Console.ReadLine();
                Console.WriteLine("Introduzca nuevamente la contraseña: ");
                pass2 = Console.ReadLine();
                if (pass2 != pass1)
                {
                    Console.WriteLine("ERROR las contraseñas no coinciden, vuelva a intentarlo");
                }
                else
                {
                    Console.WriteLine("EXITO");
                }
            }
        }
    }
}
