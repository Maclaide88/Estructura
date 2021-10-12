namespace Tarea3
{
    internal class ProgramBase
    {

        public static bool EsPrimo(int numero)
        {

            for (int i = 2; i < numero; i++)
            {
                if (numero % i == 0)
                {
                    return true;
                }
            }

        }
    }
}