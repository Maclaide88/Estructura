using System;

namespace Tarea4
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.Clear();

            // dibujo de cada linea (bucle externo)
            for (int fila = 1; fila <= 7; fila++)

            {
                //díbuja espacios en blanco (ler bucle interno)
                for (int espacios = 7 - fila; espacios > 0; espacios--)
                    Console.Write(" ");// espai en blanc

                // dibuja estrellas (2* bucle interno)
                for (int conta = 1; conta < (2 * fila); conta++)
                    Console.Write("*");

                Console.WriteLine(" *");
            }
        }
    }
}
