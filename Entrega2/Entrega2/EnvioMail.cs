using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Entrega2
{
    public class EnvioMail
    {
        // 1- Define a Delegate
        public delegate void EmailSentEventHandler(object source, EventArgs args);

        // 2- Define an Event based on that Delegate
        public event EmailSentEventHandler EmailSent;

        // 3- Raise the Event
        protected virtual void OnEmailSent()
        {
            if (EmailSent != null)
            {
                EmailSent(this, EventArgs.Empty);
            }
        }


        public void OnRegistered(object source, RegistrarEventArgs e)
        {
            Thread.Sleep(2000);
            Console.WriteLine($"\nCorreo enviado a {e.Email}: \n Gracias por registrarte, {e.Username}!\n Por favor, para poder verificar tu correo, has click en: \n {e.VerificationLink}\n");
            Thread.Sleep(2000);
            OnEmailSent();
        }

        public void OnPasswordChanged(object source, CambiarContrasenaEventArgs e)
        {
            Thread.Sleep(2000);
            Console.WriteLine($"\nCorreo enviado a {e.Email}:  \n {e.Username}, te notificamos que la contrasena de tu cuenta Spotflix ha sido cambiada. \n");
            Thread.Sleep(2000);
        }

    }
}

