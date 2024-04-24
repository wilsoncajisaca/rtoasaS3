using static System.Runtime.InteropServices.JavaScript.JSType;

namespace rtoasaS2.objetos
{
    public class INPLogin
    {
        public string User { get; set; }
        public string Password { get; set; }
        public INPLogin(string nombre, string contrasena)
        {
            User = nombre;
            Password = contrasena;
        }

    }
}
