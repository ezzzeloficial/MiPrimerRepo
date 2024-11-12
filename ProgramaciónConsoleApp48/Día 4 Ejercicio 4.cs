using System;

class Program
{
    static void Main(string[] args)
    {
        // Solicitar al usuario la cantidad de números que quiere ingresar
        Console.WriteLine("¿Cuántos números deseas ingresar?");
        int cantidad = Convert.ToInt32(Console.ReadLine());

        // Declarar el array con el tamaño especificado por el usuario
        int[] numeros = new int[cantidad];

        // Solicitar al usuario que ingrese los números
        for (int i = 0; i < cantidad; i++)
        {
            Console.WriteLine("Ingresa el número " + (i + 1) + ":");
            numeros[i] = Convert.ToInt32(Console.ReadLine());
        }

        // Calcular el valor mínimo y máximo
        int valorMinimo = numeros.Min(); // Encuentra el valor mínimo en el array
        int valorMaximo = numeros.Max(); // Encuentra el valor máximo en el array

        // Mostrar los resultados
        Console.WriteLine("El valor mínimo en la lista es: " + valorMinimo);
        Console.WriteLine("El valor máximo en la lista es: " + valorMaximo);
    }
}