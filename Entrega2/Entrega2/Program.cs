using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMPLib;


namespace Entrega2
{
    class Program
    {
        static void Main(string[] args)
        {
            Reproductor reproductor = new Reproductor();
            Finder finder = new Finder();
            //string path1 = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "../../../../Biblioteca/Tove Lo - Habits (Stay High).mp3");
            //string path2 = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "../../../../Biblioteca/Moves Like Jagger Ft. Christina Aguilera.mp3");
            //string path3 = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "../../../../Biblioteca/The Weeknd - Blinding Lights.mp3");

            //Console.Write(path1);
            //Console.Write(path3);


            //Cancion c1 = new Cancion(path1);
            //Console.WriteLine(c1.Show_info(c1));

            //Cancion c1 = new Cancion(path1);
            //Console.WriteLine(c1.Show_info(c1));


            //Cancion c2 = new Cancion(path2);
            //Console.WriteLine(c2.Show_info(c2));
            Console.WriteLine("------------------------");

            
            
            List<Cancion> todasLasCanciones= reproductor.Library();
            List<Cancion> rating=reproductor.ratingReproducciones(todasLasCanciones);
            Playlist ratingplaylist = new Playlist("rating", rating, null);
            ratingplaylist.mostrarCanciones();

            

            WindowsMediaPlayer sonido = new WindowsMediaPlayer();

            /*
                        Cancion cancion1 = new Cancion(path1);
                        Cancion cancion2 = new Cancion(path2);
                        Cancion cancion3 = new Cancion(path3);

                        List<Cancion> todasLasCanciones = new List<Cancion>();
                        todasLasCanciones.Add(cancion1);
                        todasLasCanciones.Add(cancion2);
                        todasLasCanciones.Add(cancion3);
                        InputOutput inputOutput = new InputOutput();

                        Playlist todas = new Playlist("Todas", todasLasCanciones, null);

                        Console.WriteLine("BIENVENIDO A SPOTFLIX");

                        string opcion = null;
                        while (opcion != "7")
                        {
                            Console.WriteLine("1- Crear Usuario");
                            Console.WriteLine("2- Reproductor");
                            Console.WriteLine("3- Listas");
                            Console.WriteLine("4- Buscador");
                            Console.WriteLine("7- Salir");
                            opcion = Console.ReadLine();
                            switch (opcion)
                            {
                                case "1":
                                    break;
                                case "2":
                                    break;
                                case "3":
                                    break;
                                case "4":
                                    break;
                                case "7":
                                    break;
                                default:
                                    Console.WriteLine("Ingree una opcion valida" );
                                    break;
                            }
                        }


                        Console.WriteLine();
                        todas.mostrarCanciones();
                        Playlist playlist1=inputOutput.crearListaCanciones(todas);
                        playlist1.mostrarCanciones();

                        Console.ReadLine();

                        //List<Cancion> Ranking_Canciones = new List<Cancion>();
                        //Ranking_Canciones.Add(cancion1);
                        //Ranking_Canciones.Add(cancion2);
                        //Ranking_Canciones.Add(cancion3);


                        // List<Video> Ranking_Videos = new List<Video>();
                        //Ranking_Videos.Add(video1);
                        //Ranking_Videos.Add(video2);
                        //Ranking_Videos.Add(video3);

                        //sonido.URL = path;
                        //sonido.openPlayer(path);

                        //Cancion song = new Cancion(path);
                        //Caratula nueva = new Caratula();
                        //nueva.Show_carat(song);
                        //Console.WriteLine(song.Show_info(song));
                        //reproductor.reproducirCancion(sonido,song);
                        //Console.ReadLine();
                        */

            /*WindowsMediaPlayer sonido;


            try
            {
                sonido = new WindowsMediaPlayer();



                sonido.URL = @"C:\Users\corre\OneDrive\Escritorio\P.O.O. 20-01\Safaera-BadBunny.mp3";
                sonido.controls.play();

                string n = null;
                while (n != "5")
                {
                    Console.WriteLine("1-pausa 2-contiuar 5-salir");
                    n = Console.ReadLine();
                    if (n == "1")
                    {
                        sonido.controls.pause();

                    }
                    if (n == "2")
                    {
                        double tiempo = sonido.controls.currentPosition;
                        sonido.controls.currentPosition = tiempo;
                        sonido.controls.play();
                    }

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error. " + ex.Message);
            }*/


            RegistroUsuarios database = new RegistroUsuarios();
            Server server = new Server(database);
            EnvioMail mailSender = new EnvioMail();
            EnvioSMS smsSender = new EnvioSMS();
            Usuario user = new Usuario();


            
            server.Registered += mailSender.OnRegistered;
            
            server.PasswordChanged += mailSender.OnPasswordChanged;
           
            server.PasswordChanged += smsSender.OnPasswordChanged;
            
            mailSender.EmailSent += user.OnEmailSent;
            
            user.EmailVerified += server.OnEmailVerified;
           
            bool exec = true;
            while (exec)
            {
                
                string chosen = ShowOptions(new List<string>() { "Registrarse", "Cambiar contrasena", "Salir" });
                switch (chosen)
                {
                    case "Registrarse":
                        Console.Clear();
                        server.Registrarse();
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
        private static string ShowOptions(List<string> options)
        {
            int i = 0;
            Console.WriteLine("\n\nSelecciona una opcion:");
            foreach (string option in options)
            {
                Console.WriteLine(Convert.ToString(i) + ". " + option);
                i += 1;
            }
            return options[Convert.ToInt16(Console.ReadLine())];
        }
    }
    
}
