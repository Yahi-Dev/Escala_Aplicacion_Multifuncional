namespace Practica3.Verificacion_de_carpeta_Json_y_Txt
{
    public class Verificacion
    {
        public static string JsonPath = @"Descargas\APIInformacion.json";
        public static string TxtLog = @"Descargas\APIInfo.txt";
        
        public void verificar()
        {
            if (!Directory.Exists("Descargas"))
            {
                Directory.CreateDirectory("Descargas");
            }

            if (!File.Exists(JsonPath))
            {
                using (File.CreateText(JsonPath)) {}
            }

                
            if (!File.Exists(TxtLog))
                File.CreateText(TxtLog);
        }
    }
}
