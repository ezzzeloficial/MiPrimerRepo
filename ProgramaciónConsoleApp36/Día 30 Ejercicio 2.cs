using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese un número:");
        int num = Convert.ToInt32(Console.ReadLine());
         
        bool esPar = (num % 2 == 0); 
        Console.WriteLine("¿El número es par?" + esPar);
    }
}