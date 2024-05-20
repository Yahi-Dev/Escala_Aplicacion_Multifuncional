using Practica3.Verificacion_de_carpeta_Json_y_Txt;
namespace Practica3.Archivo_Txt
{
    public sealed class Logger
    {
        
            private static Logger instance;
            // private static readonly object lockObject = new object();
            // private string logFilePath = Program.TxtLog;
            private readonly string logFilePath;

            private Logger(string logFilePath)
            {
                this.logFilePath = logFilePath;
            }

            public static Logger Instance
            {
                get
                {
                    if (instance == null)
                    {
                        string logFilePath = Verificacion.TxtLog;
                        instance = new Logger(logFilePath);
                    }
                    return instance;
                }
            }

            public void Log(string username, string operation, string input, string result)
            {
                string logEntry = $@"
User: {username}
Operation: {operation}
Input: {input}
Resultado: {result} 
Fecha: {DateTime.Now}
///////////////////////////////////////";
                try
                {
                    using (StreamWriter sw = File.AppendText(logFilePath))
                    {
                        sw.WriteLine(logEntry);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error al escribir en el archivo de log: {ex.Message}");
                }
            }
        
    }
}
