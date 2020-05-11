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
                "Cambiar contraseña",
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

                string chosen = InputOutput.ShowOptions(new List<string>() { "Registrarse", "Log in", "Opciones Usuario", "Salir" });
                switch (chosen)
                {
                    case "Registrarse":
                        Console.Clear();
                        server.Registrarse();
                        break;
                    case "Log in":
                        Console.Clear();

                        server.LogIn();
                        if (server.LogIn() == null)
                        {
                            Console.Write("Interfaz Spotflix ");

                            string opcion = null;
                            while (opcion != "5")
                            {
                                Console.WriteLine("1- Reproductor");
                                Console.WriteLine("2- Buscar");
                                Console.WriteLine("3- Biblioteca");
                                Console.WriteLine("4- Mi perfil");
                                Console.WriteLine("5- Salir");
                                int a =Convert.ToInt32(Console.ReadLine());
                                if (a == 1)
                                {
                                    Console.WriteLine("Reproductor");
                                }
                                else if(a==2)
                                {
                                    Console.WriteLine("Buscar");
                                }

                                else if (a == 2)
                                {
                                    Console.WriteLine("Biblioteca");
                                }
                                else if (a == 2)
                                {
                                    Console.WriteLine("Mi perfil");
                                }
                                else if (a == 2)
                                {
                                    Console.WriteLine("Salir");
                                }

                                else
                                {
                                    Console.WriteLine("Ingrese una opcion valida");
                                }

                            }
                        }
                        else
                        {

                            Console.WriteLine("[!] ERROR: Usuario o contrasena incorrecta\n");
                            
                        }

                        break;
                   
                    case "Opciones Usuario":
                        Console.Clear();
                        user.OpcionesUsuario();
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
