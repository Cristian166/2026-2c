using System;
using System.Collections.Generic;
using System.Linq;

namespace Clase1.Logica.Providers;

public class Pista : IPista
{

    public string Obtener(int secreto, int intento)
    {
        int diff = Math.Abs(secreto - intento);


        if (diff >= 50)
            return "congelado";
        else if (diff >= 20 && diff < 50)
            return "frio";
        else if (diff >= 5 && diff < 20)
            return "tibio";
        else
            return "caliente";

    }

}
