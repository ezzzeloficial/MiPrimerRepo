using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese el primer número:");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Introduce el segundo número:");
        int num2 = Convert.ToInt32(Console.ReadLine());

        bool esMayor = num1 > num2; 
        Console.WriteLine("¿El primer número es mayor que el segundo?" + esMayor);
    }
}