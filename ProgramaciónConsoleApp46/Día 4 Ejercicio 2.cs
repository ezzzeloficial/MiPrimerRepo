using System;

class Program
{
    static void Main(string[] args)
    {
       // Declaramos la lista de palabras
       string[] palabras = { "manzana", "banana", "uva", "pera" };

       // Solicitar al usuario la palabra que desea buscar
       Console.WriteLine("Ingrese la palabra que desea buscar:");
       
       // Leer la palabra buscada
       string palabraBuscada = Console.ReadLine();

       // Buscar si la palabra está en la lista
       bool encontrada = false;

       // Utilizamos foreach para recorrer la lista
       foreach (string palabra in palabras)
       {
           // Añadimos la condición para verificar si la palabra coincide con "palabraBuscada"
           if (palabra.Equals(palabraBuscada, StringComparison.OrdinalIgnoreCase))
           {
               encontrada = true;
               break;
           }
       }
       
       // Mostrar el resultado
       if (encontrada)
       {
           Console.WriteLine("La palabra '" + palabraBuscada + "' está presente en la lista.");
       }
       else 
       {
           Console.WriteLine("La palabra '" + palabraBuscada + "' no está en la lista.");
       }
    }
}
