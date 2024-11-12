using System;

class Program
{
    static void Main()
    {
        // Solicitar al usuario dos números enteros
        Console.Write("Ingrese el primer número entero: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingrese el segundo número entero: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        // Calcular la suma
        int suma = num1 + num2;

        // Mostrar el resultado
        Console.WriteLine($"La suma de {num1} y {num2} es: {suma}");
    }
}