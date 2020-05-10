using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Entrega2
{
    public class EnvioSMS
    {
        public void OnPasswordChanged(object source, CambiarContrasenaEventArgs e)
        {
            Thread.Sleep(2000);
            Console.WriteLine($"\nSMS enviado a {e.Number}: \n {e.Username}, te notificamos que la contrasena de tu cuenta Spotflix ha sido cambiada. \n");
            Thread.Sleep(2000);
        }
    }
}
