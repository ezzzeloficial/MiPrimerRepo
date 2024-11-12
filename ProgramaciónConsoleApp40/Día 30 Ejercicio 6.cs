using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Introduce un número:");
        int numero = Convert.ToInt32(Console.ReadLine());
        bool esPrimo = true;

        if (numero <= 1)
        {
            esPrimo = false;
        }
        else 
        { 
            for (int i = 2; i < numero; i++)
            {
                if (numero % i == 0)
                {
                    esPrimo = false;
                    break;
                }
            }
        }

        if (esPrimo)
        {
            Console.WriteLine($"{numero} es un número primo.");
        }
        else
        {
            Console.WriteLine($"{numero} no es un número primo.");
        }
    }
}