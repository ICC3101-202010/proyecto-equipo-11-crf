using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using WMPLib;
using System.Security.Cryptography.X509Certificates;
using System.Linq;
using TagLib.Gif;

namespace Entrega2
{
    class Reproductor
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
        
        public virtual void reproducirCancion(WindowsMediaPlayer sonido,Cancion cancion)
        {
            try
            {
                sonido.URL = cancion.Path;
                sonido.controls.play();
                string n = null;
                while (n != "3")
                {
                    Console.WriteLine("1-pausa 2-contiuar 3-salir");
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
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("Error: "+ex.Message);
            }
        }

        public void reproducirLista(WindowsMediaPlayer sonido,Playlist playlist)
        {
            Console.WriteLine("1-Reproduccion Oredenada");
            Console.WriteLine("Reproduccion Aleatoria");
            string opcion1 = Console.ReadLine();
            switch (opcion1)
            {
                case "1":
                    {
                        int i = 0;
                        reproducirCancion(sonido, playlist.Canciones[i]);
                    }
                    
                    
                    
                    
                    break;
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
            Playlist nuevaPlaylist = new Playlist(nombreLista, nuevaLista, null);
            return nuevaPlaylist;

        }

        public bool Check_if_premium(Usuario usuario) 
        {
            if (usuario.Member == false)
            {
                return false;
            }
            else 
            {
                return true;
            }
        }
        public List<Cancion> ratingReproducciones(List<Cancion> todasLasCanciones)
        {
            Console.WriteLine("1.Todas las canciones");
            Console.WriteLine("2. 5 primeras");
            int opt = System.Convert.ToInt32(Console.ReadLine());
            if (opt == 1)
            {
                List<Cancion> lista = (from canciones in todasLasCanciones orderby canciones.Reproducciones descending select canciones).ToList();
                return lista;
            }
            else
            {
                List<Cancion> lista = (from canciones in todasLasCanciones orderby canciones.Reproducciones descending select canciones).Take(5).ToList();
                return lista;
            }

           

        }
        public List<Cancion> ordenarPorNota(List<Cancion> canciones)
        {
            Console.WriteLine("1.Todas las canciones");
            Console.WriteLine("2. 5 primeras");
            int opt = System.Convert.ToInt32(Console.ReadLine());
            if (opt == 1)
            {
                List<Cancion> lista = (from can in canciones orderby can.Rating descending select can).ToList();
                return lista;

            }
            else
            {
                List<Cancion> lista = (from can in canciones orderby can.Rating descending select can).Take(5).ToList();
                return lista;
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

        public void AddPictureT() 
        { 
        
        }
    }
}
