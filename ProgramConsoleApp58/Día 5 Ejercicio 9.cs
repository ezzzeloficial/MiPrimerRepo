using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Solicita al usuario que ingrese los números separados por comas
        Console.WriteLine("Introduce el array de números separados por comas (por ejemplo, 1,3,7,7,2):");
        string input = Console.ReadLine();
        int[] numeros = input.Split(',').Select(int.Parse).ToArray();

        // Obtiene las posiciones de los valores máximos
        int[] posicionesMaximos = ObtenerPosicionesMaximos(numeros);

        // Muestra el resultado
        Console.WriteLine("Posiciones de los valores máximos:");
        Console.WriteLine(string.Join(", ", posicionesMaximos));
    }

    // Método para obtener las posiciones donde aparecen los valores máximos en el array
    static int[] ObtenerPosicionesMaximos(int[] array)
    {
        // Encuentra el valor máximo en el array
        int valorMaximo = array.Max();

        // Busca las posiciones donde el valor máximo aparece y las almacena en una lista
        List<int> posiciones = new List<int>();
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == valorMaximo)
            {
                posiciones.Add(i);
            }
        }

        // Convierte la lista a un array y lo devuelve
        return posiciones.ToArray();
    }
}