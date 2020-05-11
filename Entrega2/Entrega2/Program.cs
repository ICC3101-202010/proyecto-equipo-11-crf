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

            //Reproductor reproductor = new Reproductor();
            //Finder finder = new Finder();

            Reproductor reproductor = new Reproductor();
            Finder finder = new Finder();

            //string path1 = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "../../../../Biblioteca/Left Alone.mp3");
            //string pat2 = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "../../../../narnia.mp4");
            //string pat3 = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "../../../../avengers-infinity.mov");
            //string path2 = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "../../../../Biblioteca/Moves Like Jagger Ft. Christina Aguilera.mp3");
            //string path3 = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "../../../../Biblioteca/The Weeknd - Blinding Lights.mp3");

            //Console.Write(path1);
            //Console.Write(path3);

            //Video v1 = new Video(pat2);
            //Video v2 = new Video(pat3);
            //Cancion c1 = new Cancion(path1);
            //Console.WriteLine(c1.Show_info(c1));

            //Cancion c1 = new Cancion(path1);
            //Console.WriteLine(c1.Show_info(c1));


            //Cancion c2 = new Cancion(path2);
            //Console.WriteLine(c2.Show_info(c2));
            Console.WriteLine("------------------------");



            //List<Cancion> todasLasCanciones = reproductor.Library();
            //List<Cancion> rating = reproductor.ratingReproducciones(todasLasCanciones);
            //Playlist ratingplaylist = new Playlist("rating", rating, null,null);
            //ratingplaylist.mostrarCanciones();

            //Caratula caratula1 = new Caratula(c1);

            //WindowsMediaPlayer sonido = new WindowsMediaPlayer();

            LAUNCHER_Spotlix spotlix = new LAUNCHER_Spotlix();
            

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





            int a = 0;

            
            spotlix.Spotlix();
            while (a != 4)
            {
                Console.WriteLine("Desea 1 -crear nueva persona");
                Console.WriteLine("      2 -cargar personas existentes");
                Console.WriteLine("      3 -para mostrar lista de personas");
                Console.WriteLine("      4 -Salir");
                a = Convert.ToInt32(Console.ReadLine());

                if (a == 1)
                {
                    Person person = new Person();
                    Console.WriteLine("Introduzca Nombre");
                    string Nombre = Console.ReadLine();
                    person.Nombre = Nombre;
                    Console.WriteLine("Introduzca Apellido");
                    string Apellido = Console.ReadLine();
                    person.Apellido = Apellido;
                    Console.WriteLine("Introduzca Edad");
                    int Edad = Convert.ToInt32(Console.ReadLine());
                    person.Edad = Edad;
                    usuarios.Add(person);
                    IFormatter formatter = new BinaryFormatter();
                    Stream stream = new FileStream("MyFile.bin", FileMode.Create, FileAccess.Write, FileShare.None);
                    formatter.Serialize(stream, person);
                    stream.Close();


                }
                if (a == 2)
                {
                    IFormatter formatter = new BinaryFormatter();
                    Stream stream = new FileStream("MyFile.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
                    Person person = (Person)formatter.Deserialize(stream);
                    stream.Close();

                    // Here's the proof.  
                    Console.WriteLine("Nombre: {0}", person.Nombre);
                    Console.WriteLine("Apellido: {0}", person.Apellido);
                    Console.WriteLine("Edas: {0}", person.Edad);
                }
                if (a == 3)
                {
                    foreach (var item in personas)
                    {
                        Console.WriteLine(item.Info_Personas());
                    }
                }


            }

        }
    } 
}
