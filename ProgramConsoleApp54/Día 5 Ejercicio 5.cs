using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] numeros = { 1, 2, 3, 2, 1 };
bool esSimetrico = true;

for (int i = 0; i < numeros.Length / 2; i++) {
    if (numeros[i] != numeros[numeros.Length - 1 - i]) {
        esSimetrico = false;
        break;
    }
}
Console.WriteLine("¿El array es simétrico? " + esSimetrico);

    }
}