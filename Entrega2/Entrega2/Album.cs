using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using TagLib;
using System.Linq;
namespace Entrega2
{
    public class Album
    {
        private string nombre_Album;
        
        private List<Cancion> cancion;
        private Banda banda;

        //Album agregar canciones segun album , como cuando me meto a spotify y veo las canciones segun album

        public string Nombre_Album { get => nombre_Album; }
       

        public List<Cancion> Cancion { get => cancion; }
        public Banda Banda { get => banda; }

        

        public Album(Cancion song)
        {

        }

        public List<Playlist> Playlist_byAlbum(List<Cancion> songs) 
        { 
            List<Playlist> Albums = new List<Playlist>();
            string[] album_names = { };
            int names = 0;
            foreach (var list_song in songs) 
            {
                foreach (var album in Albums)
                {
                    if (album.NombrePlaylist == list_song.Banda)
                    {
                        album.Canciones.Add(list_song);

                    }
                    else
                    {
                        album_names[names] = list_song.Banda;
                        List<Cancion> album_song = new List<Cancion>();
                        Playlist album_playlist = new Playlist(list_song.Banda, album_song,null,null);
                        album_song.Add(list_song);
                        Albums.Add(album_playlist);
                        names++;
                    }

                }
            
            }
            return Albums;

        }

    }

        
}
