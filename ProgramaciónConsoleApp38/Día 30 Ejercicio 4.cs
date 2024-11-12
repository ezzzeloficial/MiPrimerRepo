using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        bool esTrue = true;
        Console.WriteLine("Valor original:" + esTrue);

        bool esFalse = !esTrue;
        Console.WriteLine("Valor invertido:" + esFalse);
    }
}