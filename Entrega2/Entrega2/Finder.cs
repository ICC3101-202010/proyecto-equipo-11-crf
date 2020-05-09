using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetadataExtractor.Formats.Exif.Makernotes;
using System.Linq;

namespace Entrega2
{
    class Finder
    {
        public Cancion buscarCancion(string song_name, List<Cancion> songs)
        {//busca una determinada cancion en una determinada lista
            List<Cancion> final_search = new List<Cancion>();
            foreach (var song in songs)
            {
                if (song.Titulo_Cancion.Contains(song_name) == true)
                {
                    final_search.Add(song);
                }
            }
            Console.WriteLine("Select one");
            int index = 0;
            foreach (var song in final_search)  
            {
                Console.WriteLine("("+index+")" + song.Titulo_Cancion);
                index++;

            }
            int selected = Convert.ToInt32(Console.ReadLine());
            return final_search[selected];
        }    
        
        public void buscarVideo()
        {

        }
        public Playlist buscarPlaylist(string playlist_name, List<Playlist> playlists)
        {//busca una determinada cancion en una determinada lista
                List<Playlist> final_search = new List<Playlist>();  
                foreach (var playlist in playlists)
                {
                    if (playlist.NombrePlaylist.Contains(playlist_name) == true)
                    {
                        final_search.Add(playlist);
                    }
                }
                Console.WriteLine("Select one");
                int index = 0;
                foreach (var playlist in final_search)
                {
                    Console.WriteLine("(" + index + ")" + playlist.NombrePlaylist);
                    index++;

                }
                int selected = Convert.ToInt32(Console.ReadLine());
       
        return final_search[selected];
        }
        
        public void buscarArtista()
        {

        }
        public Album searchAlbum(string album_name, List<Album> albums) 
        {
          //busca un determinado album en una determinada lista de albums
                List<Album> final_search = new List<Album>();
                foreach (var album in albums)
                {
                    if (album.Nombre_Album.Contains(album_name) == true)
                    {
                        final_search.Add(album);
                    }
                }
                Console.WriteLine("Select one");
                int index = 0;
                foreach (var album in final_search)
                {
                    Console.WriteLine("(" + index + ")" + album.Nombre_Album);
                    index++;

                }
                int selected = Convert.ToInt32(Console.ReadLine());
                return final_search[selected];


        }

        

    }
}
