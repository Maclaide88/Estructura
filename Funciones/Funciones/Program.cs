using System;
namespace EjeFuncGrupo3
{
    public class Funciones
    {
        public static void Main()
        {
            int opcion;
            double cuenta = 500000.00;
            Console.WriteLine("Elija una opcion: ");
            Console.WriteLine("Opcion 1. Depositar Dinero ");
            Console.WriteLine("Opcion 2. Retirar Dinero");
            Console.WriteLine("Opcion 3. Calcular Sueldo Neto");
            Console.WriteLine("Opcion 4. Pedir prestamo");
            Console.WriteLine("Opcion 5. Salir");
            opcion = Convert.ToInt32(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    funcion1(cuenta);
                    break;
                case 2:
                    funcion2();
                    break;
                case 3:
                    funcion3();
                    break;
                case 4:
                    funcion4();
                    break;
                case 5:
                    funcion5();
                    break;
                default:
                    Console.WriteLine("Opción incorecta");
                    break;
            }
        }
        public static void funcion1(double cuenta)
        {
            Console.WriteLine("Ingrese el Dinero a depositar: ");
            int deposito;
            deposito = Convert.ToInt32(Console.ReadLine());
            cuenta = cuenta + deposito;
            Console.WriteLine("Su cuenta actualmente es de: {0} ", cuenta);
            string reset;
            Console.WriteLine("Desea volver a elegir una opcion? si/no");
            reset = Console.ReadLine();
            if (reset == "si")
            {
                Main();
            }
            else
            {
                Console.WriteLine("Muchas Gracias por usar nuestro servicio, Saludos");
                return;
            }
            
          
        }

        public static void funcion2()
        {
            Console.WriteLine("Ingrese el Dinero a depositar: ");
            /*int deposito;
            deposito = Convert.ToInt32(Console.ReadLine());
            cuenta = cuenta + deposito;
            Console.WriteLine("Su cuenta actualmente es de: {0} ", cuenta);
            string reset;
            Console.WriteLine("Desea volver a elegir una opcion? si/no");
            reset = Console.ReadLine();
            if (reset == "si")
            {
                Main();
            }
            else
            {
                Console.WriteLine("Muchas Gracias por usar nuestro servicio, Saludos");
                return;
            }*/
        }

        public static double funcion3(double cuenta)
        {
            Console.WriteLine("Su saldo es: {0}", cuenta);
            return cuenta;
        }

        public static double funcion4(double cuenta)
        {
            Console.WriteLine("Elija una opcion de prestamo: 1. $10.000 2. $20.000");
            int numero;
            numero = Convert.ToInt32(Console.ReadLine());
            if (numero == 1)
            {
                cuenta = cuenta + 10000;
            }
            if (numero == 2)
            {
                cuenta = cuenta + 10000;
            }
            else
            {
            return 
            }

        }

        public static void funcion5()
        {
            return;
        }

    }
}