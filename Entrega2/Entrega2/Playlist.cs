using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Entrega2
{
     class Playlist
     {
        private string nombrePlaylist;
        private List<Cancion> canciones;
        private List<Video> videos;

        public string NombrePlaylist { get => nombrePlaylist; set => nombrePlaylist = value; }
        public List<Cancion> Canciones { get => canciones; set => canciones = value; }
        internal List<Video> Videos { get => videos; set => videos = value; }

        
        public Playlist(string nombrePlaylist, List<Cancion> canciones, List<Video> videos)
        {
            this.nombrePlaylist=nombrePlaylist;
            this.Canciones=canciones;
            this.Videos=videos;

        }
        public void mostrarCanciones()
        {
            for (int i = 0; i < canciones.Count; i++)
            {
                Console.WriteLine("Cancion "+ (i));
                Console.WriteLine("Nombre Cancion: " + canciones[i].Titulo_Cancion);
                Console.WriteLine("Artista :"+ canciones[i].Banda);
                Console.WriteLine( "" );

            }
        }
        public void agregarCancionPlaylist(Cancion cancion)
        {
            
            canciones.Add(cancion);
            Console.WriteLine("Cancion "+ cancion.Titulo_Cancion + " agregada");
            
        }
        public void eliminarCancionPlaylist()
        {
            mostrarCanciones();
            Console.WriteLine("Ingrese el numero de la cancion que desea eliminar");
            int eliminada = Convert.ToInt32(Console.ReadLine());
            Cancion cancionEliminada = canciones[eliminada];
            canciones.Remove(canciones[eliminada]);
            Console.WriteLine("Cancion "+cancionEliminada.Titulo_Cancion+" eliminada");

        }
       
        
    }
}
