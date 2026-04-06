using Clase1.Logica.IO;
using Clase1.Logica.Providers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Clase1.Logica.Juego
{
    public class Juego : IJuego
    {
        private IPista _pista;
        private IConsola _consola;

        public Juego(IPista pista, IConsola consola)
        {
            _pista = pista;
            _consola = consola;
        }

        public bool Jugar()
        {
            Random rnd = new Random();
            int secreto = rnd.Next(1, 101);
            int intentos = 5;

            _consola.Escribir("Adivina el numero (1-100)");

            while (intentos > 0)
            {
                _consola.Escribir("Intento:");
                int intento = int.Parse(_consola.Leer());

                if (intento == secreto)
                {
                    _consola.Escribir("Ganaste!");
                    return true;
                }

                _consola.Escribir(_pista.Obtener(secreto, intento));
                intentos--;
            }

            _consola.Escribir("Perdiste! El numero era: " + secreto);
            return false;
        }
    }

}
