using System;

namespace primos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(primoEnPosicion(1000));
        }

        public static bool esPrimo(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= boundary; i += 2)
                if (number % i == 0)
                    return false;

            return true;
        }

        public static int primoEnPosicion(int n)
        {
            int encontrados = 0;
            int i = 1;
            while (encontrados < n)
            {
                if (esPrimo(i))
                {
                    encontrados++;
                    i++;
                }

                else i++;
            }
            return i - 1;
        }
    }
}
