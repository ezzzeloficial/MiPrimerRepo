using System;

class Program
{
    static void Main(string[] args)
    {
        int[] listaNumeros = { 1, 3, 5, 7, 9 };
        int numeroABuscar = 5;

        bool Encontrado = false;

        foreach (int numero in listaNumeros)
        {
            if (numero == numeroABuscar)
            {
                Encontrado = true;
                break; // Paramos hasta encontrar el número verdadero
            }
        }

        if (Encontrado)
        {
            Console.WriteLine($"El número {numeroABuscar} fue encontrado en la lista.");
        }
        else
        {
            Console.WriteLine($"El número {numeroABuscar} no fue encontrado en la lista.");
        }
    }
}