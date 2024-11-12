using System;
class Program
{
    static void Main()
    {
        //Crear un array de números
        int [] numeros = {20, 35, 42, 65, 72, 80};

        //Creamos el bucle para recorrer los números en orden inverso
        for (int i = numeros.Length - 1; i >= 0; i--)
        {
            Console.WriteLine (numeros [i]); //Muestra cada número en orden inverso
        }
    }
}