using System;

class Program
{
    static void Main()
    {
        // Solicita al usuario que ingrese los números separados por comas
        Console.WriteLine("Introduce los números separados por comas (por ejemplo, 1,2,3,4,5):");
        string input = Console.ReadLine();
        int[] numeros = input.Split(',').Select(int.Parse).ToArray();

        // Variable para determinar si existen dos números consecutivos iguales
        bool hayConsecutivosIguales = false;

        // Recorre el array para verificar si hay dos números consecutivos iguales
        for (int i = 0; i < numeros.Length - 1; i++)
        {
            if (numeros[i] == numeros[i + 1])
            {
                hayConsecutivosIguales = true;
                break; // Se puede detener la búsqueda al encontrar los primeros consecutivos iguales
            }
        }

        // Muestra el resultado
        Console.WriteLine(hayConsecutivosIguales);
    }
}