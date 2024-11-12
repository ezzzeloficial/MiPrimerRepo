using System;

class Program
{
    static void Main(string[] args)
    {
        // Solicitar al usuario la cantidad de números que quiere ingresar
        Console.WriteLine("¿Cuántos números deseas ingresar?");
        int cantidad = Convert.ToInt32(Console.ReadLine());

        // Declarar el array con el tamaño especificado por el usuario
        double[] numeros = new double[cantidad];

        // Solicitar al usuario que ingrese los números
        for (int i = 0; i < cantidad; i++)
        {
            Console.WriteLine("Ingresa el número " + (i + 1) + ":");
            numeros[i] = double.Parse(Console.ReadLine());
        }

        // Calcular la media
        double suma = numeros.Sum(); // Suma todos los elementos del array
        double media = suma / cantidad;

        // Mostrar el valor promedio
        Console.WriteLine("El valor promedio de los números ingresados es: " + media);
    }
}

