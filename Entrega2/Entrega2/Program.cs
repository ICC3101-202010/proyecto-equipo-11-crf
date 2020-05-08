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
            
            string path1 = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "../../../../Tove Lo - Habits (Stay High).mp3");
            string path2 = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "../../../../../Los Bunkers - Bailando Solo.mp33");
            string path3 = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "../../../../The Weeknd - Blinding Lights.mp3");
            //Console.Write(path1);
            //Console.Write(path3);

            Cancion c1 = new Cancion(path1);
            Console.WriteLine(c1.Show_info(c1));

            /*
            Reproductor reproductor = new Reproductor();
            WindowsMediaPlayer sonido = new WindowsMediaPlayer();

            string path1 = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "../../../../Dalex - Cuaderno.mp3"");
            string path2 = @"C:\Users\corre\OneDrive\Escritorio\P.O.O. 20-01\proyecto-equipo-11-crf\Dalex - Cuaderno.mp3";
            string path3= @"C:\Users\corre\OneDrive\Escritorio\P.O.O. 20-01\proyecto-equipo-11-crf\The Weeknd - Blinding Lights.mp3";

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

        }
    }
}
