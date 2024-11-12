class Program
{
    static void Main(string[] args)
    {
        //Declaramos variables con decimales
        int num1 = 30;
        int num2 = 15;

        //Declaramos las operaciones con double para números "decimales"
        int suma = num1 + num2;
        int resta = num1 - num2;
        int multiplicación = num1 * num2;
        double división = (double) num1 / num2;
        int mod = num1 % num2;

        //Mostrar los resultados
        Console.WriteLine("El resultado de (num1) + (num2) es igual a:" + suma);
        Console.WriteLine("El resultado de (num1) - (num2) es igual a:" + resta);
        Console.WriteLine("El resultado de (num1) * (num2) es igual a:" + multiplicación);
        Console.WriteLine("El resultado de (num1) / (num2) es igual a:" + división);
        Console.WriteLine("El resultado del resto de la división es:" + mod);
    }
}