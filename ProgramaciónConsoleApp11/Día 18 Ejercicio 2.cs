using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Introduce un número entero");
        int num = Convert.ToInt32(Console.ReadLine());

        if (num > 0)
        {
            Console.WriteLine($"El resultado de {num} positivo");
        }
        else if (num < 0)
        {
            Console.WriteLine($"El resultado de {num} es negativo");
        }
        else
        {
            Console.WriteLine($"El resultado de {num} es 0");
        }
    }
}