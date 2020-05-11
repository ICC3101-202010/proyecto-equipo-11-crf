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
            List<Cancion> todasLasCanciones = new List<Cancion>();
            List<Video> todosVideos = new List<Video>();
            List<Playlist> todasPlaylists = new List<Playlist>();
            
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

                string chosen = InputOutput.ShowOptions(new List<string>() { "Registrarse", "Log in", "Opciones Usuario", "Mostrar Usuarios","Salir" });
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


                            Console.WriteLine("Interfaz Spotflix ");

                            
                            Console.Write("Interfaz Spotflix ");



                            int a = 0;
                            while (a != 5)
                            {
                                InputOutput.Main_menu();
                                a =Convert.ToInt32(Console.ReadLine());
                                if (a == 1)
                                {
                                    Console.WriteLine("Reproductor");
                                    //ALGO
                                    //PRUEBA 
                                }
                                else if(a==2)
                                {
                                    Finder finder = new Finder();
                                    int opcionB = 0;
                                    while (opcionB != 9)
                                    {
                                        Console.WriteLine("Buscar");
                                        Console.WriteLine("1-Cancion");
                                        Console.WriteLine("2-Video");
                                        Console.WriteLine("3-Playlist");
                                        Console.WriteLine("4-Actor");
                                        Console.WriteLine("5-Banda");
                                        Console.WriteLine("6-Album");
                                        Console.WriteLine("7-Mas escuchadas");
                                        Console.WriteLine("8-Mejor puntuadas");
                                        Console.WriteLine("9-Salir");
                                        opcionB = System.Convert.ToInt32(Console.ReadLine());
                                        if (opcionB == 1)
                                        {
                                            Console.WriteLine("Ingrese el nombre de la cancion");
                                            string nombreCancion=Console.ReadLine();
                                            finder.buscarCancion(nombreCancion, todasLasCanciones);
                                        }
                                        else if (opcionB == 2)
                                        {
                                            Console.WriteLine("Ingrese el nombre del video");
                                            string nombreVideo = Console.ReadLine();
                                            finder.buscarVideo(nombreVideo, todosVideos);
                                        }
                                        else if (opcionB == 3)
                                        {
                                            Console.WriteLine("Ingrese nombre playlist");
                                            string nombrePlaylist = Console.ReadLine();
                                            finder.buscarPlaylist(nombrePlaylist, todasPlaylists);
                                        }

                                    }
                                    




                                    
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

                    case "Mostrar Usuarios":
                        Console.Clear();
                        server.MostrarUsuarios();
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
