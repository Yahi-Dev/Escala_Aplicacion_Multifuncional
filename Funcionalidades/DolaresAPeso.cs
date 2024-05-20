using Microsoft.Extensions.Logging;
using Practica3.Archivo_Txt;

namespace Practica3.Funcionalidades
{
    public class DolaresAPeso
    {
       public DolaresAPeso() { }
        public double UsdADOp(string user, double moneda)
        {
            double tasaDeCambio = 56.50;

            double Dop = moneda * tasaDeCambio;

            Logger.Instance.Log(user, "Conversion de Dolar a Peso Dominicano", $"{moneda} * {tasaDeCambio} ", "DOP$ " + Dop.ToString());

            return Dop;
        }
    }
}
