using Clase1.Logica.IO;
using Clase1.Logica.Providers;
using Clase1.Logica.Juego;

class Program
{
    static void Main()
    {
        IJuego juego = new Juego(new Pista(), new Consola());
        juego.Jugar();
    }
}
