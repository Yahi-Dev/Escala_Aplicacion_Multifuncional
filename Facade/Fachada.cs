using Practica3.Funcionalidades;

namespace Practica3.Facade
{
    public class Fachada
    {
        private DolaresAPeso dolaresApeso;
        private FarenheitACelsius farenheitAcelsius;
        private Sumar sumar;

        public double ConversionDeMonedas(string user, double a)
        {
            DolaresAPeso dolaresApeso = new DolaresAPeso();
            return dolaresApeso.UsdADOp(user, a);
        }

        public double ConvertidorTemperaturas(string user, double a)
        {
            FarenheitACelsius farenheitAcelsius = new FarenheitACelsius();
           return farenheitAcelsius.FarenheitCelsius(user, a);
        }

        public int OperacionSuma(string user, int a, int b)
        {
            Sumar sumar = new Sumar();
           return sumar.suma(user, a, b);
        }
    }
}
