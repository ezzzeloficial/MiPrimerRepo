using System;

using System;

class Program
{
    static void Main(string[] args)
    {
        for (int numero = 1; numero < 20; numero++)
        {
            bool esPar = numero % 2 == 0;

            if (esPar)
            {
                Console.WriteLine($"{numero} - Es par");
            }
            else
            {
                Console.WriteLine($"{numero} - Es impar");
            }
        }
    }
}
