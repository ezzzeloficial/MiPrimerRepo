using System;

class Coche
{
    private string marca;
    private string modelo;
    private int año;
    private int velocidad;

    // Propiedad Marca con validación en set
    public string Marca
    {
        get { return marca; }
        set
        {
            if (!string.IsNullOrEmpty(value))
            {
                marca = value;
            }
            else
            {
                Console.WriteLine("La marca no puede estar vacía.");
            }
        }
    }

    // Propiedad Modelo con validación en set
    public string Modelo
    {
        get { return modelo; }
        set
        {
            if (!string.IsNullOrEmpty(value))
            {
                modelo = value;
            }
            else
            {
                Console.WriteLine("El modelo no puede estar vacío.");
            }
        }
    }

    // Propiedad Año con validación en set
    public int Año
    {
        get { return año; }
        set
        {
            if (value >= 1886 && value <= DateTime.Now.Year)
            {
                año = value;
            }
            else
            {
                Console.WriteLine("Año inválido. Debe estar entre 1886 y el año actual.");
            }
        }
    }

    // Propiedad Velocidad con validación en set
    public int Velocidad
    {
        get { return velocidad; }
        set
        {
            if (value >= 0)
            {
                velocidad = value;
            }
            else
            {
                Console.WriteLine("La velocidad no puede ser negativa.");
            }
        }
    }
}
