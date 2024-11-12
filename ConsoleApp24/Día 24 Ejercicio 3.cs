using System;

class Program
{
    static void Main()
    {
        //Creamos un array de 5 números
        int [] numeros = { 1, 2, 3, 4, 5,};

        int mayor = 0;  //Variable para almacenar número mayor

        //Buscamos el número mayor
        for (int i = 0; i < numeros.Length; i++)
        {
           if (numeros[i] > mayor)
            {
                mayor = numeros[i];
            }
        }
        // Mostrar el número mayor
        Console.WriteLine("El número mayor es: " + mayor);
    }
}