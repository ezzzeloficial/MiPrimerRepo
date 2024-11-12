using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese un número:");
        int num = Convert.ToInt32(Console.ReadLine());
         
        bool numero = num >=  10 && num <= 20;
        Console.WriteLine("¿El número está entre 10 y 20?" + numero);
    }
}