using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrega2
{
    public class PlayLIstDatabase
    {
        List<Playlist> playlists;



        public List<Playlist> Playlists { get => playlists; set => playlists = value; }

        List<Playlist> All_Playlists = new List<Playlist>();

        public PlayLIstDatabase()
        {
        }

        public void AgregarPlaylist(Playlist user_playlist) 
        {
            All_Playlists.Add(user_playlist);
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


    }
}
