using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Paso 1: Pedir al usuario que ingrese 10 números
        int[] numeros = new int[10];
        Console.WriteLine("Por favor, ingresa 10 números:");

        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Ingrese el número {i + 1}: ");
            while (true)
            {
                try
                {
                    numeros[i] = Convert.ToInt32(Console.ReadLine());
                    break; // Salir del bucle si la entrada es válida
                }
                catch (FormatException)
                {
                    Console.WriteLine("Por favor, ingresa un número entero válido.");
                }
            }
        }

        // Paso 2: Eliminar duplicados
        List<int> numerosSinDuplicados = new List<int>();
        foreach (int numero in numeros)
        {
            if (!numerosSinDuplicados.Contains(numero))
            {
                numerosSinDuplicados.Add(numero);
            }
        }

        // Paso 3: Mostrar el array sin duplicados
        Console.WriteLine("Array sin duplicados:");
        foreach (int numero in numerosSinDuplicados)
        {
            Console.WriteLine(numero);
        }
    }
}