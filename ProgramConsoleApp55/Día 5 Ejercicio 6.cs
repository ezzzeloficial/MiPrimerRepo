using System;

class Program
{
    static void Main()
    {
        // Solicita al usuario que ingrese los números separados por comas
        Console.WriteLine("Introduce los números separados por comas (por ejemplo, 1,2,3,4,5):");
        string input = Console.ReadLine();
        int[] numeros = input.Split(',').Select(int.Parse).ToArray();

        // Calcula la media de todos los números
        double media = numeros.Average();
        Console.WriteLine("La media es: " + media);

        // Filtra los números impares que sean mayores a la media
        int[] numerosFiltrados = numeros.Where(n => n > media && n % 2 != 0).ToArray();

        // Muestra el nuevo array
        Console.WriteLine("Números impares mayores a la media:");
        foreach (var numero in numerosFiltrados)
        {
            Console.WriteLine(numero);
        }
    }
}
