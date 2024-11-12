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

        // Calcular el promedio
        double promedio = (double)suma / numeros.Length;

        // Mostrar la suma total y el promedio
        Console.WriteLine($"La suma de todos los números es {suma}");
        Console.WriteLine($"El promedio de los números es {promedio}");

        // Mostrar los elementos en las posiciones pares 
        Console.WriteLine("Elementos en posiciones pares:");
        for (int i = 0; i < numeros.Length; i += 2) //incrementa de 2 en 2
        {
            Console.WriteLine($"Elemento en la posición {i}: {numeros[i]}"); // Mostrar también el índice
        }
    }
}