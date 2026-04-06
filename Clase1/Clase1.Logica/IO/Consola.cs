using System;

namespace Clase1.Logica.IO;

public class Consola : IConsola
{
    public void Escribir(string texto)
    {
        Console.WriteLine(texto);
    }

    public string Leer()
    {
        return Console.ReadLine();
    }
}