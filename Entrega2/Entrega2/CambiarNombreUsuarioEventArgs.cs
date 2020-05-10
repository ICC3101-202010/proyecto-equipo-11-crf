using System;
namespace Entrega2
{
    public class CambiarNombreUsuarioEventArgs : EventArgs
    {
        public string Email { get; set; }
        public string Number { get; set; }
        public string Contrasena { get; set; }
    }
}
