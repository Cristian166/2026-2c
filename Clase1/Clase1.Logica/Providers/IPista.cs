using System;
using System.Collections.Generic;
using System.Text;

namespace Clase1.Logica.Providers;

public interface IPista
{
    string Obtener(int secreto, int intento);
}
