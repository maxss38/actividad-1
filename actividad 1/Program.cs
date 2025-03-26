using System;

public class Libro
{
    public string Titulo;
    public string Autor;

    public void Leer()
    {
        Console.WriteLine($"Leyendo el libro \"{Titulo}\" de {Autor}.");
    }
}

public class Cuaderno
{
    public string Marca;
    public int Hojas;

    public void Escribir()
    {
        Console.WriteLine($"Escribiendo en un cuaderno {Marca} con {Hojas} hojas.");
    }
}

class Program
{
    static void Main()
    {
        // Crear y usar un libro
        Libro libro1 = new Libro();
        libro1.Titulo = "El Principito";
        libro1.Autor = "Antoine de Saint-Exupéry";
        libro1.Leer();

        // Crear y usar un cuaderno
        Cuaderno cuaderno1 = new Cuaderno();
        cuaderno1.Marca = "Norma";
        cuaderno1.Hojas = 100;
        cuaderno1.Escribir();
    }
}
