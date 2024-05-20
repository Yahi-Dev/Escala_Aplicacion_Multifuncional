using Practica3.Moldels_Usuer;
using Practica3.Verificacion_de_carpeta_Json_y_Txt;
using static Practica3.Verificacion_de_carpeta_Json_y_Txt.saveJasonData;

namespace Practica3.Inicio_de_sesion
{
    public class InicioDeSesion
    {
        private List<UsuarioInformacion> usuariosRegistrados = new List<UsuarioInformacion>();
        public bool inicio(string UserName, string password)
        {
            usuariosRegistrados = saveJasonData.DeserializeJsonFile();

            foreach (var usuario in usuariosRegistrados)
            {
                if (usuario.userName == UserName && usuario.password == password)
                {
                    Console.WriteLine("entro");
                    return true;
                }
            }
            Console.WriteLine("Datos incorrectos, favor comuniquese con la terminal 829-340-8864");
            return false;

        }
    }
}
