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
            InputOutput.ConsoleWelcome();
            
            RegistroUsuarios database = new RegistroUsuarios();
            server server = new server(database);
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

                        string server1=server.LogIn();
                        if (server1 == null)
                        {
                            Console.Write("Interfaz Spotflix ");

                            int a = 0;
                            while (a != 5)
                            {
                                InputOutput.Main_menu();
                                a =Convert.ToInt32(Console.ReadLine());
                                if (a == 1)
                                {
                                    Console.WriteLine("Reproductor");
                                }
                                else if(a==2)
                                {
                                    Console.WriteLine("Buscar");
                                }

                                else if (a == 3)
                                {
                                    Console.WriteLine("Biblioteca");
                                }
                                else if (a == 4)
                                {
                                    Console.WriteLine("Mi perfil");
                                }
                                else if (a == 5)
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

                            Console.WriteLine("[!] ERROR: "+ server1 +"\n");
                            
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
