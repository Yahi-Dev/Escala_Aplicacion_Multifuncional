namespace Practica3.Archivo_Txt
{
        public class VerLog
        {
            private readonly string logFilePath;

            public VerLog(string logFilePath)
            {
                this.logFilePath = logFilePath;
            }

            public void DesplegarLog()
            {
                try
                {
                    string[] logLines = File.ReadAllLines(logFilePath);
                    Console.WriteLine("Registro de Operaciones: \n \n ");
                    foreach (var line in logLines)
                    {
                        Console.WriteLine(line);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error al leer el archivo de log: {ex.Message}");
                }
            }
        }
    
}
