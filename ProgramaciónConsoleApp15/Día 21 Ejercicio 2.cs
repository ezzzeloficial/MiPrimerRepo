using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Introduzca su edad");
        int edad = Convert.ToInt32(Console.ReadLine());

        if (edad < 18) 
        {
            Console.WriteLine("Tienes un 10% de descuento");
        }
        else if (edad >= 18 && edad <= 65)
        {
            Console.WriteLine("Tienes un 5% de descuento");
        }
        else
        {
            Console.WriteLine("Tienes un 15% de descuento");
        }
    }
}