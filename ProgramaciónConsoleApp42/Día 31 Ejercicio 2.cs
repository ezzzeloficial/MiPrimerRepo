using System;

class Program
{
    static void Main(string[] args)
    {
        for (int numero = 1; numero < 30; numero++)
        {
            bool MultiploDeTres = (numero % 3 == 0);

            if (MultiploDeTres)
            {
                Console.WriteLine($"{numero} - Es múltiplo de tres");
            }
            else
            {
                Console.WriteLine($"{numero} - No es múltiplo de tres");
            }
        }
    }
}
