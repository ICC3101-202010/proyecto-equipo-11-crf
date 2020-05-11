using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entrega2.IO;
using WMPLib;
namespace Entrega2
{
    class LAUNCHER_Spotlix
    {

        public LAUNCHER_Spotlix()
        {

        }
        public List<string> Loginlist { get; set; }

        public void Spotlix()
        {
            InputOutput.ConsoleWelcome();

            Reproductor reproductor = new Reproductor();
            RegistroUsuarios database = new RegistroUsuarios();
            server server = new server(database);
            EnvioMail mailSender = new EnvioMail();
            EnvioSMS smsSender = new EnvioSMS();
            Usuario user = new Usuario();

            WindowsMediaPlayer Player = new WindowsMediaPlayer();


            List<Cancion> todasLasCanciones = new List<Cancion>();
            todasLasCanciones = reproductor.Library();
            List<Video> todosVideos = new List<Video>();
            List<Playlist> todasPlaylists = new List<Playlist>();
            List<Album> todosAlbum = new List<Album>();


            Playlist All_songs = new Playlist("Library", todasLasCanciones, null, null);


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

                string chosen = InputOutput.ShowOptions(new List<string>() { "Registrarse", "Log in", "Log Out" });
                switch (chosen)
                {
                    case "Registrarse":
                        Console.Clear();
                        server.Registrarse();
                        break;
                    case "Log in":
                        Console.Clear();

                        string server1 = server.LogIn();
                        if (server1 == null)
                        {


                            Console.WriteLine("Spotflix ");
                            if (user.Member == "true")
							{
                                int a = 0;
                                while (a != 5)
                                {

                                    InputOutput.Main_menu();
                                    Player.controls.stop();
                                    a = Convert.ToInt32(Console.ReadLine());
                                    if (a == 1)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Home");
                                        All_songs.mostrarCanciones();
                                        Console.WriteLine("Select one");
                                        int option_chosen = Convert.ToInt32(Console.ReadLine());
                                        int count = 0;
                                        foreach (var song in All_songs.Canciones)
                                        {

                                            if (option_chosen == count)
                                            {
                                                reproductor.reproducirCancion(Player, song);
                                                reproductor.reproducirLista(Player, reproductor.Queue(song));
                                                Player.controls.pause();
                                                break;
                                            }
                                            else
                                            {

                                                count++;
                                            }

                                            Console.WriteLine(song.Titulo_Cancion);

                                        }



                                    }
                                    else if (a == 2)
                                    {
                                        List<Cancion> retornoBuscarCancion = new List<Cancion>();
                                        List<Video> retornoBuscarVideo = new List<Video>();

                                        Finder finder = new Finder();
                                        int opcionB = 0;
                                        while (opcionB != 9)
                                        {

                                            retornoBuscarCancion.Clear();
                                            retornoBuscarVideo.Clear();
                                            InputOutput.Menu_finder();
                                            opcionB = System.Convert.ToInt32(Console.ReadLine());
                                            if (opcionB == 1)
                                            {
                                                Console.WriteLine("Ingrese el nombre de la cancion");
                                                string nombreCancion = Console.ReadLine();
                                                retornoBuscarCancion.Add(finder.buscarCancion(nombreCancion, todasLasCanciones));
                                            }
                                            else if (opcionB == 2)
                                            {
                                                Console.WriteLine("Ingrese el nombre del video");
                                                string nombreVideo = Console.ReadLine();
                                                retornoBuscarVideo.Add(finder.buscarVideo(nombreVideo, todosVideos));
                                            }
                                            else if (opcionB == 3)
                                            {
                                                Console.WriteLine("Ingrese nombre playlist");
                                                string nombrePlaylist = Console.ReadLine();
                                                retornoBuscarCancion = finder.buscarPlaylist(nombrePlaylist, todasPlaylists).Canciones;

                                            }
                                            else if (opcionB == 4)
                                            {
                                                Console.WriteLine("Ingrese nombre Actor/Director");
                                                string nombreActorDirector = Console.ReadLine();
                                                retornoBuscarVideo = finder.buscarActorDirector(nombreActorDirector, todosVideos);
                                            }
                                            else if (opcionB == 5)
                                            {
                                                Console.WriteLine("Ingrese nombre banda");
                                                string nombreBanda = Console.ReadLine();
                                                retornoBuscarCancion = finder.buscarArtista(nombreBanda, todasLasCanciones);


                                            }
                                            else if (opcionB == 6)
                                            {
                                                Console.WriteLine("Ingrese nombre Abum");
                                                string nombreAlbum = Console.ReadLine();
                                                retornoBuscarCancion = finder.searchAlbum(nombreAlbum, todosAlbum).Cancion;

                                            }
                                            else if (opcionB == 7)
                                            {
                                                Console.WriteLine("Mas reproducidas");
                                                retornoBuscarCancion = finder.ratingReproducciones(todasLasCanciones);
                                            }
                                            else if (opcionB == 8)
                                            {
                                                Console.WriteLine("Mejor puntuadas");
                                                retornoBuscarCancion = finder.ordenarPorNota(todasLasCanciones);

                                            }
                                            else
                                            {
                                                Console.WriteLine("Salir");
                                            }
                                        }

                                    }

                                    else if (a == 3)
                                    {
                                        Console.WriteLine("Biblioteca");
                                        int opcionC = 0;
                                        while (opcionC != 4)

                                        {
                                            InputOutput.Library_menu();
                                            opcionC = Convert.ToInt32(Console.ReadLine());

                                            if (opcionC == 1)
                                            {
                                                Console.WriteLine("Ms canciones");

                                            }

                                            else if (opcionC == 2)
                                            {
                                                Console.Clear();
                                                Console.WriteLine("Mis playlist");
                                                //MOSTRAR PLAYLISTS 
                                                /*
                                                 * 
                                                 */
                                            }

                                            else if (opcionC == 3)
                                            {
                                                Console.Clear();
                                                Console.Write("Crea tu playlist" + "\n" + "Elige un tipo" + "\n" + "[1] Canciones" + "\n" + "[2]  Video");
                                                int opcion_crear = Convert.ToInt32(Console.ReadLine());
                                                if (opcion_crear == 1)
                                                {
                                                    Console.Clear();

                                                    Playlist All_new_user = new Playlist("Library", todasLasCanciones, null, user.NamePerson);
                                                    reproductor.crearListaCanciones(All_new_user);
                                                }



                                                else if (opcionC == 4)
                                                {

                                                }

                                            }

                                        }

                                    }
                                    else if (a == 4)
                                    {
                                        Console.WriteLine("Mi perfil");
                                        user.OpcionesUsuario();
                                    }
                                    else if (a == 5)
                                    {
                                        Console.WriteLine("Log Out");
                                    }

                                    else
                                    {
                                        Console.WriteLine("Ingrese una opcion valida");
                                    }

<<<<<<< HEAD

                                        
=======
>>>>>>> 3e3004b26986a5e17174bb784747a9e277f3b7ee
                                }
                            }

							else
							{
                                int a = 0;
                                while (a != 3)
                                {

                                    InputOutput.Main_Menu_No_Premium();
                                    Player.controls.stop();
                                    a = Convert.ToInt32(Console.ReadLine());
                                    if (a == 1)
                                    {
<<<<<<< HEAD
<<<<<<< HEAD
                                       
                                        retornoBuscarCancion.Clear();
                                        retornoBuscarVideo.Clear();
                                        InputOutput.Menu_finder();
                                        opcionB = System.Convert.ToInt32(Console.ReadLine());
                                        if (opcionB == 1)
                                        {
                                            Console.WriteLine("Ingrese el nombre de la cancion");
                                            string nombreCancion=Console.ReadLine();
                                            Cancion seleccionada= finder.buscarCancion(nombreCancion, todasLasCanciones);
                                            retornoBuscarCancion.Add(finder.buscarCancion(nombreCancion, todasLasCanciones));
                                            if (seleccionada != null)
                                            {
                                                int opcion = 0;
                                                while (opcion != 4)
                                                {
                                                    Console.WriteLine("1.Agregar cancion a una lista");
                                                    Console.WriteLine("2.Puntuar cancion");
                                                    Console.WriteLine("3.Reproducir");
                                                    Console.WriteLine("4.Salir");
                                                    opcion = System.Convert.ToInt32(Console.ReadLine());
                                                    if (opcion == 1)
                                                    {
                                                        Console.WriteLine("Ingrese nombre lista");
                                                        string lista = Console.ReadLine();

                                                    }
                                                    else if (opcion == 2)
                                                    {
                                                        seleccionada.valorarCancion();
                                                    }
                                                    else if (opcion == 3)
                                                    {
                                                        reproductor.reproducirCancion(Player,seleccionada);
                                                    }
                                                }
                                                
                                            }
                                        }
                                        else if (opcionB == 2)
                                        {
                                            Console.WriteLine("Ingrese el nombre del video");
                                            string nombreVideo = Console.ReadLine();
                                            retornoBuscarVideo.Add(finder.buscarVideo(nombreVideo, todosVideos));
                                        }
                                        else if (opcionB == 3)
                                        {
                                            Console.WriteLine("Ingrese nombre playlist");
                                            string nombrePlaylist = Console.ReadLine();
                                            retornoBuscarCancion=finder.buscarPlaylist(nombrePlaylist, todasPlaylists).Canciones;
                                            
                                        }
                                        else if (opcionB == 4)
                                        {
                                            Console.WriteLine("Ingrese nombre Actor/Director");
                                            string nombreActorDirector = Console.ReadLine();
                                            retornoBuscarVideo=finder.buscarActorDirector(nombreActorDirector, todosVideos);
                                        }
                                        else if (opcionB == 5)
=======
=======
                                        Console.Clear();
>>>>>>> 223f00a821992553edb61d3aa0545983e2705253
                                        Console.WriteLine("Home");
                                        All_songs.mostrarCanciones();
                                        Console.WriteLine("Select one");
                                        int option_chosen = Convert.ToInt32(Console.ReadLine());
                                        int count = 0;
                                        foreach (var song in All_songs.Canciones)
>>>>>>> 3e3004b26986a5e17174bb784747a9e277f3b7ee
                                        {

                                            if (option_chosen == count)
                                            {
                                                reproductor.reproducirCancion(Player, song);
                                                reproductor.reproducirLista(Player, reproductor.Queue(song));
                                                Player.controls.pause();
                                                break;
                                            }
                                            else
                                            {

                                                count++;
                                            }





                                        }

                                    }
                                    else if (a == 2)
                                    {
                                        Console.WriteLine("Mi perfil");
                                        user.OpcionesUsuario();
                                    }
                                    else if (a == 3)
                                    {
                                        Console.WriteLine("Log Out");
                                    }

                                    else
                                    {
                                        Console.WriteLine("Ingrese una opcion valida");
                                    }

                                }
                            }
                        }
                        else
                        {

                            Console.WriteLine("[!] ERROR: " + server1 + "\n");

                        }

                        break;

                    case "Log Out":
                        exec = false;
                        break;


                }

                Console.Clear();
            }

        }




    }
}
