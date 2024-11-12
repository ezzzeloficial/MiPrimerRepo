using System;

class Program
{
    static void Main()
    {
        // Solicita al usuario que ingrese los números separados por comas
        Console.WriteLine("Introduce los números separados por comas (por ejemplo, 2,4,6,1,3):");
        string input = Console.ReadLine();
        int[] numeros = input.Split(',').Select(int.Parse).ToArray();

        // Cuenta las veces que los números suben consecutivamente
        int contadorSubidas = ContarSubidasConsecutivas(numeros);

        // Muestra el resultado
        Console.WriteLine("Número de subidas consecutivas: " + contadorSubidas);
    }

    // Método para contar las subidas consecutivas
    static int ContarSubidasConsecutivas(int[] array)
    {
        int contador = 0;

        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] < array[i + 1])
            {
                contador++;
            }
        }

        return contador;
    }
}
