using System;

class Program
{
    static void Main()
    {
        // Crear un array de 5 números
        int[] numeros = {10, 20, 30, 40, 50};

        // Sumar los números
        int suma = 0;
        for (int i = 0; i < numeros.Length; i++)
        {
            suma += numeros[i];
        }
        // Calcular el promedio
        float promedio = (float)suma / numeros.Length;

        // Mostrar la suma y el promedio
        Console.WriteLine("La suma es: " + suma);
        Console.WriteLine("El promedio es: " + promedio);
    }
}