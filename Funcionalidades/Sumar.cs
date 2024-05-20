using Microsoft.Extensions.Logging;
using Practica3.Archivo_Txt;

namespace Practica3.Funcionalidades
{
    public class Sumar
    {
         public Sumar() { }
        public int suma(string user, int a, int b)
        {
            int resultado = a + b;

            Logger.Instance.Log(user, "Suma", $"{a} + {b} ", resultado.ToString());
            return resultado;
        }
    }
}
