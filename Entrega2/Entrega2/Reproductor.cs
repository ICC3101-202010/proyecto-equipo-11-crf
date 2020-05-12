using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using WMPLib;
using System.Security.Cryptography.X509Certificates;
using TagLib.Gif;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
using TagLib;

namespace Entrega2
{
    class Reproductor : Usuario
    {
        public List<Cancion> Library()
        {
            string directory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "../../../../Biblioteca");
            DirectoryInfo Biblioteca_folder = new DirectoryInfo(directory);
            List<Cancion> Library = new List<Cancion>();

            foreach (var mp3_file in Biblioteca_folder.GetFiles())
            {
                Cancion cancion = new Cancion(mp3_file.FullName);
                //Console.WriteLine(cancion.Show_info(cancion));
                Library.Add(cancion);
            }
            return Library;
            //Retorna la lista con todas las canciones
        }
        public List<Video> Video_Library()
        {
            string directory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "../../../../Video");
            DirectoryInfo Video_folder = new DirectoryInfo(directory);
            List<Video> Video_Library = new List<Video>();

            foreach (var video_file in Video_folder.GetFiles())
            {
                Video video = new Video(video_file.FullName);
                //Console.WriteLine(cancion.Show_info(cancion));
                Video_Library.Add(video);
            }
            return Video_Library;
            //Retorna la lista con todas las canciones
        }
        public virtual void reproducirCancion(WindowsMediaPlayer sonido, Cancion cancion)
        {
            try
            {
                sonido.URL = Path.GetFullPath(cancion.Path);
                sonido.controls.play();
                cancion.Reproducciones += 1;


                /*IFormatter formatter2 = new BinaryFormatter();
                Stream stream2 = new FileStream("MyFile.bin", FileMode.Create, FileAccess.Write, FileShare.None);
                formatter2.Serialize(stream2, cancion);
                stream2.Close();

                IFormatter formatter3 = new BinaryFormatter();
                Stream stream3 = new FileStream("MyFile.bin", FileMode.Create, FileAccess.Write, FileShare.None);
                formatter3.Serialize(stream3, cancion.path);
                stream3.Close();*/

                string n = null;
                while (n != "3")
                {
                    Console.Clear();
                    Console.WriteLine(cancion.Titulo_Cancion);
                    Console.WriteLine("1-pausa 2-contiuar 3-Siguiente");
                    n = Console.ReadLine();
                    
                    if (n == "1")
                    {
                        double tiempo = sonido.controls.currentPosition;
                        double tiempo1 = tiempo;
                        sonido.controls.pause();

                        /*IFormatter formatter1 = new BinaryFormatter();
                        Stream stream1 = new FileStream("MyFile.bin", FileMode.Create, FileAccess.Write, FileShare.None);
                        formatter1.Serialize(stream1, tiempo1);
                        stream1.Close();*/


                    }
                    else if (n == "2")
                    {
                        double tiempo = sonido.controls.currentPosition;
                        sonido.controls.currentPosition = tiempo;
                        sonido.controls.play();
                    }
                    else if (n == "3")
                    {
                        sonido.controls.pause();
                        /*double tiempo = sonido.controls.currentPosition;
                        Double tiempo1 = tiempo;
                        IFormatter formatter1 = new BinaryFormatter();
                        Stream stream1 = new FileStream("MyFile.bin", FileMode.Create, FileAccess.Write, FileShare.None);
                        formatter1.Serialize(stream1, tiempo1);
                        stream1.Close();*/
                    }
                    else
                    {
                        Console.WriteLine("Opcion No Valida");
                    }

                }

                sonido.controls.stop();
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }



        public Playlist crearListaCanciones(Playlist todasCanciones)
        {

            string nombreLista;
            List<Cancion> nuevaLista = new List<Cancion>();

            Console.WriteLine("Ingrese el nombre de la nueva lista");
            nombreLista = Console.ReadLine();

            int i = 0;
            while (i != 1)
            {
                todasCanciones.mostrarCanciones();
                Console.WriteLine("Ingrese el numero de la cancion que desea agregar");
                int agregada = Convert.ToInt32(Console.ReadLine());
                nuevaLista.Add(todasCanciones.Canciones[agregada]);
                Console.WriteLine("Ingrese 1 para terminar, otro numero para continuar");
                i = Convert.ToInt32(Console.ReadLine());
            }
            Playlist nuevaPlaylist = new Playlist(nombreLista, nuevaLista, null, username);
            return nuevaPlaylist;

        }

        public bool Check_if_premium(Usuario usuario)
        {
            if (usuario.Member == "false")
            {
                return false;
            }
            else
            {
                return true;
            }
        }


        public List<Cancion> Queue(Cancion song)

        {
            List<Cancion> queue = new List<Cancion>();
            List<Cancion> Allsongs = new List<Cancion>();
            Allsongs = Library();

            Random rand_Num = new Random();
            while (Allsongs.Count > 0)
            {
                int val = rand_Num.Next(0, Allsongs.Count - 1);
                queue.Add(Allsongs[val]);
                Allsongs.RemoveAt(val);
            }

            return queue;
        }
        public void Show_lyrics(Cancion song, WindowsMediaPlayer sonido)
        {
            int total = song.Seconds;

            int largo = 0;
            foreach (var letra in song.Letra)
            {
                largo++;

            }
            int intervalo = total / largo;
            foreach (var letra in song.Letra) 
            {
                Console.Write(letra);
                Thread.Sleep(intervalo + 100);
                if (letra == '\n') 
                {
                    Console.Write("\n");
                }
            
            }
        }


        public virtual void reproducirLista(WindowsMediaPlayer sonido, List<Cancion> songs)
        {
            try
            {
                string n = null;
                foreach (var song in songs)

                {
                    song.Reproducciones += 1;
                    sonido.URL = Path.GetFullPath(song.Path);
                    //sonido.controls.play();
                    while (n != "4")
                    {

                        sonido.controls.play();

                        Console.WriteLine(song.Titulo_Cancion);
                        
                       
                        Console.WriteLine("1-pausa 2-contiuar 3-Siguiente 4-Retroceder");
                        
                        n = Console.ReadLine();
                        this.Show_lyrics(song, sonido);
                        if (n == "1")
                        {
                            
                            sonido.controls.pause();
                            //double tiempo = sonido.controls.currentPosition;
                            //double tiempo1 = tiempo;
                            sonido.controls.pause();
                            Console.Clear();
                            /*IFormatter formatter1 = new BinaryFormatter();
                            Stream stream1 = new FileStream("MyFile.bin", FileMode.Create, FileAccess.Write, FileShare.None);
                            formatter1.Serialize(stream1, tiempo1);
                            stream1.Close();

                            IFormatter formatter2 = new BinaryFormatter();
                            Stream stream2 = new FileStream("MyFile.bin", FileMode.Create, FileAccess.Write, FileShare.None);
                            formatter2.Serialize(stream2, song);
                            stream2.Close();

                            IFormatter formatter3 = new BinaryFormatter();
                            Stream stream3 = new FileStream("MyFile.bin", FileMode.Create, FileAccess.Write, FileShare.None);
                            formatter3.Serialize(stream3, song.path);
                            stream3.Close();*/

                            /*IFormatter formatter4 = new BinaryFormatter();
                            Stream stream4 = new FileStream("MyFile.bin", FileMode.Create, FileAccess.Write, FileShare.None);
                            formatter4.Serialize(stream4, songs);
                            stream4.Close();*/
                        }
                        else if (n == "2")
                        {
                            double tiempo = sonido.controls.currentPosition;
                            sonido.controls.currentPosition = tiempo;
                            sonido.controls.play();
                        }
                        else if (n == "3") 
                        {
                           Console.WriteLine("next...");
                           Console.Clear();
                           break;
                        }
                        else if (n == "4")
                        {
                            sonido.controls.pause();

                            double tiempo = sonido.controls.currentPosition;
                            double tiempo1 = tiempo;

                            //double tiempo = sonido.controls.currentPosition;
                            //double tiempo1 = tiempo;

                            /*IFormatter formatter1 = new BinaryFormatter();
                            Stream stream1 = new FileStream("MyFile.bin", FileMode.Create, FileAccess.Write, FileShare.None);
                            formatter1.Serialize(stream1, tiempo1);
                            stream1.Close();

                            IFormatter formatter2 = new BinaryFormatter();
                            Stream stream2 = new FileStream("MyFile.bin", FileMode.Create, FileAccess.Write, FileShare.None);
                            formatter2.Serialize(stream2, song);
                            stream2.Close();

                            IFormatter formatter3 = new BinaryFormatter();
                            Stream stream3 = new FileStream("MyFile.bin", FileMode.Create, FileAccess.Write, FileShare.None);
                            formatter3.Serialize(stream3, song.path);
                            stream3.Close();

                            IFormatter formatter4 = new BinaryFormatter();
                            Stream stream4 = new FileStream("MyFile.bin", FileMode.Create, FileAccess.Write, FileShare.None);
                            formatter4.Serialize(stream4, songs);
                            stream4.Close();*/
                        }
                        else
                        {
                            Console.WriteLine("Opcion No Valida");
                        }
                        if (sonido.playState == WMPPlayState.wmppsMediaEnded)
                        {
                            break;
                        }

                    }
                    sonido.controls.stop();

                }
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}  

