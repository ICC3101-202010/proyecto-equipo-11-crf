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
            if (final_search.Any() ==true)
            {
                Console.WriteLine("Select one");
                int index = 0;

                foreach (var song in final_search)
                {
                    Console.WriteLine("(" + index + ")" + song.Titulo_Cancion);
                    index++;

                }
                int selected = Convert.ToInt32(Console.ReadLine());
                return final_search[selected];

            }
            else
            {
                Console.WriteLine("Ninguna cancion coincide con la busqueda");
                return null;
            }
            
        }

        public Video buscarVideo(string videoName,List<Video> todos)
        {
            List<Video> final_search = new List<Video>();
            foreach (var vid in todos)
            {
                if (vid.NameVideo.Contains(videoName) == true)
                {
                    final_search.Add(vid);
                }
            }
            Console.WriteLine("Select one");
            int index = 0;
            foreach (var vid in final_search)
            {
                Console.WriteLine("(" + index + ")" + vid.NameVideo);
                index++;

            }
            int selected = Convert.ToInt32(Console.ReadLine());
            return final_search[selected];
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

        public List<Cancion> buscarArtista(string artista, List<Cancion> todasLasCanciones)
        {
            List<Cancion> finalSearch = new List<Cancion>();
            foreach (Cancion song in todasLasCanciones)
            {
                if (song.Banda.Contains(artista) == true)
                {
                    finalSearch.Add(song);
                }
            }
            int index = 0;
            foreach (Cancion song in finalSearch)
            {
                Console.WriteLine("(" + index + ")" + song.Titulo_Cancion);
                index++;
            }
            return finalSearch;


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
        public List<Video> buscarActorDirector(string name, List<Video> todosLosVideos)
        {
            List<Video> finalSearch = new List<Video>();

            {
                foreach (Video vid in todosLosVideos)
                {
                    int i = 0;
                    if (vid.Director.NamePerson == name)
                    {
                        finalSearch.Add(vid);
                    }
                    while (i < vid.Actores.Count())
                    {
                        if (vid.Actores[i].NamePerson == name)
                        {
                            finalSearch.Add(vid);
                        }
                    }
                }

            }
            return finalSearch;

        }
        public List<Cancion> ratingReproducciones(List<Cancion> todasLasCanciones)
        {
            Console.WriteLine("1.Todas las canciones");
            Console.WriteLine("2. 5 primeras");
            int opt = System.Convert.ToInt32(Console.ReadLine());
            if (opt == 1)
            {
                List<Cancion> lista = (from canciones in todasLasCanciones orderby canciones.Reproducciones descending select canciones).ToList();
                int cont = 0;
                foreach(Cancion can in lista)
                {
                    Console.WriteLine(cont);
                    Console.WriteLine("Artista: "+can.Banda);
                    Console.WriteLine("Cancion: " + can.Titulo_Cancion);
                    cont++;

                }
                return lista;
            }
            else
            {
                List<Cancion> lista = (from canciones in todasLasCanciones orderby canciones.Reproducciones descending select canciones).Take(5).ToList();
                int cont = 0;
                foreach (Cancion can in lista)
                {
                    Console.WriteLine(cont);
                    Console.WriteLine("Artista: " + can.Banda);
                    Console.WriteLine("Cancion: " + can.Titulo_Cancion);
                    cont++;

                }

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
                int cont = 0;
                foreach (Cancion can in lista)
                {
                    Console.WriteLine(cont);
                    Console.WriteLine("Artista: " + can.Banda);
                    Console.WriteLine("Cancion: " + can.Titulo_Cancion);
                    cont++;

                }
                return lista;

            }
            else
            {
                List<Cancion> lista = (from can in canciones orderby can.Rating descending select can).Take(5).ToList();
                int cont = 0;
                foreach (Cancion can in lista)
                {
                    Console.WriteLine(cont);
                    Console.WriteLine("Artista: " + can.Banda);
                    Console.WriteLine("Cancion: " + can.Titulo_Cancion);
                    cont++;

                }
                return lista;
            }


        }
    }
}

