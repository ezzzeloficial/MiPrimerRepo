using System;

class Program
{
    static void Main()
    {
        // Solicita al usuario que ingrese el primer array de números separados por comas
        Console.WriteLine("Introduce el primer array de números separados por comas (por ejemplo, 1,2,3,4,5):");
        string input1 = Console.ReadLine();
        int[] array1 = input1.Split(',').Select(int.Parse).ToArray();

        // Solicita al usuario que ingrese el segundo array de números separados por comas
        Console.WriteLine("Introduce el segundo array de números separados por comas (por ejemplo, 3,4,5,6,7):");
        string input2 = Console.ReadLine();
        int[] array2 = input2.Split(',').Select(int.Parse).ToArray();

        // Verifica si tienen al menos tres números en común
        bool tienenTresEnComun = TienenTresElementosEnComun(array1, array2);

        // Muestra el resultado
        Console.WriteLine("Tienen al menos tres números en común: " + tienenTresEnComun);
    }

    // Método para verificar si hay al menos tres elementos en común entre dos arrays
    static bool TienenTresElementosEnComun(int[] array1, int[] array2)
    {
        // Usa Intersect para encontrar los elementos comunes y cuenta cuántos hay
        int elementosEnComun = array1.Intersect(array2).Count();
        return elementosEnComun >= 3;
    }
}
