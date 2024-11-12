using System;
class Program
{
    static void Main()
    {
        //Crear un array de números
        int [] numeros = {20, 35, 42, 65};

        //Declarar la variable de suma
        int suma = 0;

        //Sumamos todos los números
        for (int i = 0; i < numeros.Length; i++)
        {
            suma += numeros[i];
        }
        //Muestra el total de la suma de los valores
        Console.WriteLine("La suma total es: " + suma);
    }
}