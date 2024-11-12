using System;

class Libro
{
    private string titulo;
    private string autor;
    private int isbn;
    private int numeroDePaginas;
    private int añoDePublicacion;
    private bool disponibilidad;

    // Propiedad Título con validación en set
    public string Titulo
    {
        get { return titulo; }
        set
        {
            if (!string.IsNullOrEmpty(value))
            {
                titulo = value;
            }
            else
            {
                Console.WriteLine("El título no puede estar vacío.");
            }
        }
    }

    // Propiedad Autor con validación en set
    public string Autor
    {
        get { return autor; }
        set
        {
            if (!string.IsNullOrEmpty(value))
            {
                autor = value;
            }
            else
            {
                Console.WriteLine("El autor no puede estar vacío.");
            }
        }
    }

    // Propiedad ISBN con validación en set
    public int ISBN
    {
        get { return isbn; }
        set
        {
            if (value > 0)
            {
                isbn = value;
            }
            else
            {
                Console.WriteLine("El ISBN debe ser un número positivo y único.");
            }
        }
    }

    // Propiedad Número de Páginas con validación en set
    public int NumeroDePaginas
    {
        get { return numeroDePaginas; }
        set
        {
            if (value > 0)
            {
                numeroDePaginas = value;
            }
            else
            {
                Console.WriteLine("El número de páginas debe ser positivo.");
            }
        }
    }

    // Propiedad Año de Publicación con validación en set
    public int AñoDePublicacion
    {
        get { return añoDePublicacion; }
        set
        {
            if (value >= 1450 && value <= DateTime.Now.Year)
            {
                añoDePublicacion = value;
            }
            else
            {
                Console.WriteLine($"El año de publicación debe estar entre 1450 y {DateTime.Now.Year}.");
            }
        }
    }

    // Propiedad Disponibilidad sin validación adicional (es booleano)
    public bool Disponibilidad
    {
        get { return disponibilidad; }
        set { disponibilidad = value; }
    }

    // Constructor de la clase Libro
    public Libro(string titulo, string autor, int isbn, int numeroDePaginas, int añoDePublicacion, bool disponibilidad)
    {
        Titulo = titulo;
        Autor = autor;
        ISBN = isbn;
        NumeroDePaginas = numeroDePaginas;
        AñoDePublicacion = añoDePublicacion;
        Disponibilidad = disponibilidad;
    }

    // Método para mostrar la información del libro
    public void MostrarInformacion()
    {
        Console.WriteLine($"Título: {Titulo}");
        Console.WriteLine($"Autor: {Autor}");
        Console.WriteLine($"ISBN: {ISBN}");
        Console.WriteLine($"Número de Páginas: {NumeroDePaginas}");
        Console.WriteLine($"Año de Publicación: {AñoDePublicacion}");
        Console.WriteLine($"Disponibilidad: {(Disponibilidad ? "Disponible" : "No disponible")}");
    }
}

// Ejemplo de uso de la clase Libro
class Program
{
    static void Main()
    {
        // Crear un nuevo libro
        Libro libro = new Libro("Cien Años de Soledad", "Gabriel García Márquez", 123456789, 417, 1967, true);
        
        // Mostrar información del libro
        libro.MostrarInformacion();
    }
}