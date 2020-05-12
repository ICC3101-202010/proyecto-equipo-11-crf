using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrega2
{
    public class MediaDatabase
    {
        List<Playlist> playlists=new List<Playlist>();

        List<Cancion> user_songs=new List<Cancion>();

        public List<Playlist> Playlists { get => playlists; set => playlists = value; }
        public List<Cancion> User_songs { get => user_songs; set => user_songs = value; }

        

        public MediaDatabase()
        {
        }

        public void AgregarPlaylist(Playlist user_playlist) 
        {
            playlists.Add(user_playlist);
        }

        public List<Playlist> Show_playlist_by_user(List<Playlist> all_playlist, Usuario usuario)
        {
            List<Playlist> user_playlists = new List<Playlist>();
            foreach (var playlist in all_playlist)
            {
                if (usuario.NamePerson == playlist.NombreCreador1)
                {
                    user_playlists.Add(playlist);
                }

            }
            return user_playlists;
        }
            
        public void AgregarCancion(Cancion song)
        {
            user_songs.Add(song);
        }

        public List<Cancion> Show_songs_by_user(List<Cancion> all_songs, Usuario usuario)
        {
            List<Cancion> user_songs = new List<Cancion>();
            foreach (var song in all_songs)
            {
                if (usuario.NamePerson == song.Usuario_)
                {
                    user_songs.Add(song);
                }

            }
            return user_songs;
        }



    }
}
