using System;
class Program
{
    static void Main()
    {
        //Solicitar al usuario un número para mostrar la tabla de multiplicar
       Console.WriteLine("Introduzca un número para que muestre su tabla de multiplicar");
       int num = Convert.ToInt32(Console.ReadLine());

       //Mostrar la tabla de multiplicar
       Console.WriteLine($"Tabla de multiplicar del {num}:");
       for (int i = 1; i <= 10; i++)
       {
        int resultado = num * i;
        Console.WriteLine($"{num} x {i} = {resultado}");
       }
    }
}