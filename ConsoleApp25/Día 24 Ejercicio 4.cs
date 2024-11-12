using System;
class Program
{
    static void Main()
    {
        //Declaramos un array con algunos números enteros
        int [] numeros = { 10, 20, 30,};

        //Declaramos variable de contador de números pares
        int contadorpares = 0;  

        //Contamos cuántos números son pares 
        for (int i = 0; i < numeros.Length; i++)
        {
            if (numeros[i] % 2 == 0) //El número es par si lo que sobra de la división por 2 es 0
            {
                contadorpares++;
            }
        }
        //Muestra el total de números pares
        Console.WriteLine ("El total de números pares es:" + contadorpares);
    }
}