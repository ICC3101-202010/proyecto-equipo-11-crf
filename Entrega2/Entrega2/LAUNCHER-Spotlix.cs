using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entrega2.IO;

namespace Entrega2
{
    class LAUNCHER_Spotlix
    {
        public LAUNCHER_Spotlix() 
        {
            // LIST OF Loging
            Loginlist = new List<string>()
            {
                "Registarse",
                "Login",
                //"Cambiar contraseña",
                "Salir",

            };

 
        }
        public List<string> Loginlist { get; set; }

        public void Spotlix() 
        {
            RegistroUsuarios database = new RegistroUsuarios();
            Server server = new Server(database);
            EnvioMail mailSender = new EnvioMail();
            EnvioSMS smsSender = new EnvioSMS();
            Usuario user = new Usuario();
            
            server.Registered += mailSender.OnRegistered;

            server.PasswordChanged += mailSender.OnPasswordChanged;

            server.UsernameChanged += mailSender.OnUsernameChanged;

            server.PasswordChanged += smsSender.OnPasswordChanged;

            server.UsernameChanged += smsSender.OnUsernameChanged;

            mailSender.EmailSent += user.OnEmailSent;

            user.EmailVerified += server.OnEmailVerified;

            bool exec = true;
            while (exec)
            {

                string chosen = InputOutput.ShowOptions(new List<string>() { "Registrarse", "Log in", "Cambiar contrasena", "Salir" });
                switch (chosen)
                {
                    case "Registrarse":
                        Console.Clear();
                        server.Registrarse();
                        break;
                    case "Log in":
                        Console.Clear();
                        server.LogIn();
                        break;
                    case "Cambiar contrasena":
                        Console.Clear();
                        server.CambiarContrasena();
                        break;
                    case "Salir":
                        exec = false;
                        break;
                }

                Console.Clear();
            }

        }




    }

}
