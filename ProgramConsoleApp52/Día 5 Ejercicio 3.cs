using System;

class Program
{
    static void Main()
    {
        // Solicita al usuario que ingrese los números separados por comas
        Console.WriteLine("Introduce los números separados por comas (por ejemplo, 1,2,3,4,5):");
        string input = Console.ReadLine();
        int[] numeros = input.Split(',').Select(int.Parse).ToArray();

        // Crea un nuevo array con los elementos en posiciones alternadas
        int[] numerosAlternados = numeros.Where((num, index) => index % 2 == 0).ToArray();

        // Muestra el nuevo array
        Console.WriteLine("Array con elementos en posiciones alternadas:");
        foreach (var numero in numerosAlternados)
        {
            Console.WriteLine(numero);
        }
    }
}
