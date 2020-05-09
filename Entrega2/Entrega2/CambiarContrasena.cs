using System;
namespace Entrega2
{
    
        public class CambiarContrasenaEventArgs : EventArgs
        {
            public string Email { get; set; }
            public string Number { get; set; }
            public string Username { get; set; }
        }
    
}
