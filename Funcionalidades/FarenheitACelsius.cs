using Microsoft.Extensions.Logging;
using Practica3.Archivo_Txt;

namespace Practica3.Funcionalidades
{
    public class FarenheitACelsius
    {
         public FarenheitACelsius() { }
        public double FarenheitCelsius(string user, double dato)
        {

            double Farenheit = dato;
            double celsius = (Farenheit - 32) * 5 / 9;
            Logger.Instance.Log(user, "Conversion de Farenheit a Celsius", $"({Farenheit} - 32) * 5/9", "C° " + celsius.ToString());
            return celsius;
        }
    }
}
