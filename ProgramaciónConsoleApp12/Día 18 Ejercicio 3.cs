using System;
class Program
{
    static void Main()
    {
       int nota = 0;
       Console.WriteLine("Elige una nota del 0 al 100");
       nota = Convert.ToInt32(Console.ReadLine());

       if (nota >= 90 && nota <= 100)
       {
        Console. WriteLine("Sobresaliente");
       }
       else if (nota >= 70 && nota <= 89)
       {
        Console.WriteLine("Notable");
       }
       else if (nota >= 50 && nota <= 69)
       {
        Console.WriteLine("Aprobado");
       }
       else
       {
        Console.WriteLine ("Suspenso");
       }
    }
}