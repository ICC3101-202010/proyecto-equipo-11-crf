using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Entrega2
{
<<<<<<< HEAD
     class Playlist
=======
    class Playlist
>>>>>>> 53e6c6566051308184c08e757ff1d17abcd632d9
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
    }
}
