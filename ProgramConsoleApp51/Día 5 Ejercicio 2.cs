using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // Solicita al usuario que ingrese palabras separadas por comas
        Console.WriteLine("Introduce las palabras separadas por comas (por ejemplo, casa,perro,gato):");
        string input = Console.ReadLine();
        string[] palabras = input.Split(',');

        // Solicita al usuario el número n
        Console.WriteLine("Introduce el número n (cantidad mínima de letras):");
        int n = int.Parse(Console.ReadLine());

        // Filtra las palabras que tienen más de n letras
        string[] palabrasFiltradas = palabras.Where(p => p.Length > n).ToArray();

        // Muestra el resultado
        Console.WriteLine("Palabras con más de " + n + " letras:");
        foreach (var palabra in palabrasFiltradas)
        {
            Console.WriteLine(palabra);
        }
    }
}