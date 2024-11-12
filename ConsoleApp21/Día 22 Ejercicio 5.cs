using System;

class Program
{
    static void Main()
    {
        //Pedir al usuario un número del mes entre el (1-12)
       Console.WriteLine("Introduzca un número del mes del (1-12):");
       int mes = Convert.ToInt32(Console.ReadLine()); //Leemos el número ingresado por el usuario

       //Variable para almacenar el número de días
       int dias;

       //Determinamos cuántos días tiene el mes
       switch (mes)
       {
        case 1: //Enero
        case 3: //Marzo
        case 5: //Mayo
        case 7: //Julio
        case 8: //Agosto
        case 10: //Octubre
        case 12: //Diciembre
             dias = 31;
             break;

        case 4: //Abril
        case 6: //Junio
        case 9: //Septiembre
        case 11: //Noviembre
            dias = 30;
            break;
            
        case 2: //Febrero
             dias = 28;
             break;

        default:
            Console.WriteLine("Número del mes inválido. Por favor ingrese un número comprendido entre (1-12).");
            return;
       }

       //Mostrar el resultado
       Console.WriteLine($"El mes {mes} tiene {dias} días.");
    }
}