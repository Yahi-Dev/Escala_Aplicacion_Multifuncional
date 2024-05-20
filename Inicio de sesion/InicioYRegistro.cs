using Practica3.Moldels_Usuer;
using Practica3.Verificacion_de_carpeta_Json_y_Txt;
using static Practica3.Verificacion_de_carpeta_Json_y_Txt.saveJasonData;

namespace Practica3.Inicio_de_sesion
{
    public class InicioYRegistro
    {
        private List<UsuarioInformacion> usuariosRegistrados = new List<UsuarioInformacion>();
        public void InicioRegistro(int opcion)
        {

            switch (opcion)
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Clear();
                    Console.WriteLine("                    ESTOS CAMPOS REQUERIRAN DE LA INFORMACION PUESTA AL REGISTRARSE \n \n");
                    Console.Write("                        DIGITE LA INFORMACION CORRESPONDIENTES A LOS CAMPOS REQUERIDOS \n \n");
                    Console.Write("USERNAME: ");
                    string user = Console.ReadLine()!;
                    Console.Write("\nPassword: ");
                    string password = Console.ReadLine()!;
                    Console.ResetColor();
                    //usuariosRegistrados = saveJasonData.DeserializeJsonFile();
                    InicioDeSesion iniciarSesion = new InicioDeSesion();

                    if (iniciarSesion.inicio(user, password))
                    {
                      
                    }

                    break;

                case 2:
                    Console.Clear();

                    UsuarioInformacion info = new UsuarioInformacion();

                    Console.Write("REGISTRO\n \n");

                    Console.Write("Name: ");
                    info.name = Console.ReadLine()!;

                    Console.Write("\n  last Name: ");
                    info.lastName = Console.ReadLine()!;

                    Console.Write("\n       User Name: ");
                    info.userName = Console.ReadLine()!;

                    Console.Write("\n            EmailAddress: ");
                    info.mailAddress = Console.ReadLine()!;

                    Console.Write("\n                  Password: ");
                    info.password = Console.ReadLine()!;

                    Console.Write("\n                        NumberPhone: ");
                    info.phoneNumber = Console.ReadLine()!;


                   // usuariosRegistrados = saveJasonData.DeserializeJsonFile();
                    usuariosRegistrados.Add(info);

                    Console.Clear();
                    Console.WriteLine("Registro exitoso!!!");
                    Thread.Sleep(2000);
                    Console.Clear();

                    saveJasonData.SerializeJsonFile(usuariosRegistrados);
                    break;

                default:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("!! Elija una opcion entre 1 y 2. XXXX ");
                    Console.ResetColor();
                    break;

            }
        }
    }
}
