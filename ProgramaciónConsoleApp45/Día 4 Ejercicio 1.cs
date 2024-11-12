using System;

class Program
{
    static void Main(string[] args)
    {
        //Solicitamos al usuario que ingrese un número
        Console.WriteLine("Ingrese un número positivo");
        int n = Convert.ToInt32(Console.ReadLine());

        int contadorPares = 0;

        for (int i = 1; i <= n; i++)
        {
           if ( i % 2 == 0 )
           {

            contadorPares++;

           }
        }

        //Muestra el resultado
        Console.WriteLine("Hay" + contadorPares + "números pares entre 1 y " + n);

    }
}