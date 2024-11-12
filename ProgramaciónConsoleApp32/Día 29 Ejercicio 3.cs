using System;

class Program
{
    static void Main(string[] args)
    {
        int[] numeros = { 10, 20, 30, 40, 50 };
        int suma = 0;

        // Sumar todos los números en el array
        foreach (int num in numeros)
        {
            suma += num; // Sumar el número actual
        }

        // Mostrar la suma total
        Console.WriteLine($"La suma de todos los números es {suma}");

        // Mostrar los números en orden inverso
        for (int i = numeros.Length - 1; i >= 0; i--)
        {
            Console.WriteLine($"El número en la posición {i + 1} es igual a {numeros[i]}");
        }
    }
}