using Microsoft.AspNetCore.Mvc;
using Practica3.Facade;
using Practica3.Moldels_Usuer;
using Practica3.Verificacion_de_carpeta_Json_y_Txt;
using System.Xml.Serialization;

namespace Practica3.Controllers
{
    
    [ApiController]
    [Route("Prac3")]
    public class ApiPrac3Controller : ControllerBase
    {
        private static List<UsuarioInformacion> usuarios = new List<UsuarioInformacion>();
        private readonly Practica3.Facade.Fachada fachada;

        public ApiPrac3Controller()
        {
            fachada = new Practica3.Facade.Fachada();
        }

        [HttpPost]
        [Route("registrar")]
        public IActionResult RegistrarUsuario([FromBody] UsuarioInformacion info)
        {
            if (info == null)
            {
                return BadRequest("datos de usuario no validos");
            }

            //usuarios = saveJasonData.DeserializeJsonFile();
            usuarios.Add(info);

            string nombre = info.name;
            string apellido = info.lastName;
            string usuarionombre = info.userName;
            string email = info.mailAddress;
            string contraseña = info.password;
            string NumberPhone = info.phoneNumber;

           // saveJasonData.GetUsuarioInformacions(info);

            //usuarios = saveJasonData.DeserializeJsonFile();
           saveJasonData.SerializeJsonFile(usuarios);

            return Ok("Registro exitoso perfecto!!!");
        }

        [HttpPost]
        [Route("iniciarsesion")]

        public IActionResult IniciarSesion([FromBody] Credenciales credenciales)
        {
            usuarios = saveJasonData.DeserializeJsonFile();

            var usuarioencontrado = usuarios.Find(u => u.userName == credenciales.userName);

            //if (usuarioencontrado.userName == "juan" && usuarioencontrado.password == "0000")
            //{
            //    Console.WriteLine("Usuario Admin");
            //}

            if (usuarioencontrado != null && usuarioencontrado.password == credenciales.password)
            {
                return Ok("Inicio de sesion exitoso");
            }

            return Unauthorized("Datos incorrectos, favor registrarse");
        }

        [HttpPost]
        [Route("conversionMoneda")]
        public IActionResult conversionDeMonedas([FromBody] CredencialesConversion conversion )
        {
            double result = fachada.ConversionDeMonedas(conversion.user, conversion.dato);
            return Ok(result);
        }

        [HttpPost]
        [Route("conversionTemperatura")]
        public IActionResult conversionDeTemperatura([FromBody] CredencialesConversion conversion)
        {
            double result = fachada.ConvertidorTemperaturas(conversion.user, conversion.dato);
            return Ok(result);
        }

        [HttpPost]
        [Route("suma")]
        public IActionResult suma([FromBody] CredencialesSuma suma)
        {
            int result = fachada.OperacionSuma(suma.nombreUser, suma.numero1, suma.numero2);
            return Ok(result);
        }
    }
}

