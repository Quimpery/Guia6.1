using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia6._1
{
    internal interface IPrueba
    {
        string Procesar(string patente, out string formateada);
    }
}
