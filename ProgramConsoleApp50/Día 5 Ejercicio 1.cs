using System;

class Program
{
    static void Main()
    {
        int[] numeros = { 10, 15, 20, 25, 5 };
int limite = 15;
int suma = 0;
int contador = 0;

foreach (int numero in numeros) {
    if (numero > limite) {
        suma += numero;
        contador++;
    }
}
double media = contador > 0 ? (double)suma / contador : 0;
Console.WriteLine("La media de los números mayores que " + limite + " es " + media);
    }
}
