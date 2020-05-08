using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using WMPLib;
using System.Security.Cryptography.X509Certificates;

namespace Entrega2
{
    class Reproductor
    {
        
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


    }
}
