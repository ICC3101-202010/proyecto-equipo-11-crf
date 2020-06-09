using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetadataExtractor.Formats.Exif.Makernotes;
using System.Linq;

namespace Entrega2
{
    public class Finder1
    {
        public List<Cancion> buscarCancion(string song_name, List<Cancion> songs)
        {//busca una determinada cancion en una determinada lista
            List<Cancion> final_search = new List<Cancion>();
            if (song_name.Contains("or"))
            {

                string[] separator = { "or" };
                string[] filters = song_name.Split(separator, StringSplitOptions.RemoveEmptyEntries);
                foreach (string item in filters)
                {
                    if (item.Contains("and"))
                    {
                        string[] sep = { "and" };
                        string[] subfilters = item.Split(sep, StringSplitOptions.RemoveEmptyEntries);
                        foreach (string subitem in subfilters)
                        {
                            foreach (var song in songs)
                            {
                                if (song.Titulo_Cancion.Contains(subitem) == true)
                                {
                                    final_search.Add(song);
                                }
                            }
                        }
                    }
                    else
                    {
                        foreach (var song in songs)
                        {
                            if (song.Titulo_Cancion.Contains(item) == true)
                            {
                                final_search.Add(song);
                            }
                        }
                    }
                }
            }
            else if (song_name.Contains("and"))
            {
                string[] separator = { "and" };
                string[] filters = song_name.Split(separator, StringSplitOptions.RemoveEmptyEntries);
                foreach (string item in filters)
                {
                    foreach (var song in songs)
                    {
                        
                        if (song.Titulo_Cancion.Contains(item) == true)
                        {
                            final_search.Add(song);
                        }
                    }
                }
            }
            else
            {
                foreach (var song in songs)
                {

                    if (song.Titulo_Cancion.Contains(song_name) == true)
                    {
                        final_search.Add(song);
                    }
                }
            }
            return final_search;
            int index = 0;
            if (final_search.Any() == true)
            {
                foreach (var song in final_search)
                {
                    Console.WriteLine("(" + index + ")" + song.Titulo_Cancion);
                    index++;

                }
                int selected = Convert.ToInt32(Console.ReadLine());
                
            }
            else
            {
                Console.WriteLine("No hay canciones que cooincidan");
                return null;
            }

        }
        public List<Usuario> buscar_usuario(string song_name, List<Usuario> songs)
        {
            List<Usuario> final_search = new List<Usuario>();
            if (song_name.Contains("or"))
            {

                string[] separator = { "or" };
                string[] filters = song_name.Split(separator, StringSplitOptions.RemoveEmptyEntries);
                foreach (string item in filters)
                {
                    
                    if (item.Contains("and"))
                    {
                        string[] sep = { "and" };
                        string[] subfilters = item.Split(sep, StringSplitOptions.RemoveEmptyEntries);
                        foreach (string subitem in subfilters)
                        {
                            foreach (var song in songs)
                            {
                                if (song.Username.Contains(subitem) == true)
                                {
                                    final_search.Add(song);
                                }
                            }
                        }
                    }
                    else
                    {
                        foreach (var song in songs)
                        {
                            if (song.Username.Contains(item) == true)
                            {
                                final_search.Add(song);
                            }
                        }
                    }
                }
            }
            else if (song_name.Contains("and"))
            {
                string[] separator = { "and" };
                string[] filters = song_name.Split(separator, StringSplitOptions.RemoveEmptyEntries);
                foreach (string item in filters)
                {
                    foreach (var song in songs)
                    {

                        if (song.Username.Contains(item) == true)
                        {
                            final_search.Add(song);
                        }
                    }
                }
            }
            else
            {
                foreach (var song in songs)
                {

                    if (song.Username.Contains(song_name) == true)
                    {
                        final_search.Add(song);
                    }
                }
            }
            return final_search;
        }
        public List<Video> buscarVideo(string song_name, List<Video> songs)
        {
            List<Video> final_search = new List<Video>();

            
            if (song_name.Contains("or"))
            {

                string[] separator = { "or" };
                string[] filters = song_name.Split(separator, StringSplitOptions.RemoveEmptyEntries);
                foreach (string item in filters)
                {
                    if (item.Contains("and"))
                    {
                        string[] sep = { "and" };
                        string[] subfilters = item.Split(sep, StringSplitOptions.RemoveEmptyEntries);
                        foreach (string subitem in subfilters)
                        {
                            foreach (var song in songs)
                            {
                                if (song.NameVideo.Contains(subitem) == true)
                                {
                                    final_search.Add(song);
                                }
                            }
                        }
                    }
                    else
                    {
                        foreach (var song in songs)
                        {
                            if (song.NameVideo.Contains(item) == true)
                            {
                                final_search.Add(song);
                            }
                        }
                    }
                }
            }
            else if (song_name.Contains("and"))
            {
                string[] separator = { "and" };
                string[] filters = song_name.Split(separator, StringSplitOptions.RemoveEmptyEntries);
                foreach (string item in filters)
                {
                    foreach (var song in songs)
                    {

                        if (song.NameVideo.Contains(item) == true)
                        {
                            final_search.Add(song);
                        }
                    }
                }
            }
            else
            {
                foreach (var song in songs)
                {

                    if (song.NameVideo.Contains(song_name) == true)
                    {
                        final_search.Add(song);
                    }
                }
            }
            return final_search;
            int index = 0;
            foreach (var vid in final_search)
            {
                Console.WriteLine("(" + index + ")" + vid.NameVideo);
                index++;

            }
            int selected = Convert.ToInt32(Console.ReadLine());
            if (final_search.Any() == true)
            {
                //return final_search[selected];

            }
            return null;
            
        }



        public List<Playlist> buscarPlaylist(string song_name, List<Playlist> songs)
        {//busca una determinada cancion en una determinada lista
            List<Playlist> final_search = new List<Playlist>();
            if (song_name.Contains("or"))
            {

                string[] separator = { "or" };
                string[] filters = song_name.Split(separator, StringSplitOptions.RemoveEmptyEntries);
                foreach (string item in filters)
                {
                    if (item.Contains("and"))
                    {
                        string[] sep = { "and" };
                        string[] subfilters = item.Split(sep, StringSplitOptions.RemoveEmptyEntries);
                        foreach (string subitem in subfilters)
                        {
                            foreach (var song in songs)
                            {
                                if (song.NombrePlaylist.Contains(subitem) == true)
                                {
                                    final_search.Add(song);
                                }
                            }
                        }
                    }
                    else
                    {
                        foreach (var song in songs)
                        {
                            if (song.NombrePlaylist.Contains(item) == true)
                            {
                                final_search.Add(song);
                            }
                        }
                    }
                }
            }
            else if (song_name.Contains("and"))
            {
                string[] separator = { "and" };
                string[] filters = song_name.Split(separator, StringSplitOptions.RemoveEmptyEntries);
                foreach (string item in filters)
                {
                    foreach (var song in songs)
                    {

                        if (song.NombrePlaylist.Contains(item) == true)
                        {
                            final_search.Add(song);
                        }
                    }
                }
            }
            else
            {
                foreach (var song in songs)
                {

                    if (song.NombrePlaylist.Contains(song_name) == true)
                    {
                        final_search.Add(song);
                    }
                }
            }
            return final_search;
            
        }

        public List<Cancion> buscarArtista(string song_name, List<Cancion> songs)
        {
            List<Cancion> final_search = new List<Cancion>();
            if (song_name.Contains("or"))
            {

                string[] separator = { "or" };
                string[] filters = song_name.Split(separator, StringSplitOptions.RemoveEmptyEntries);
                foreach (string item in filters)
                {
                    if (item.Contains("and"))
                    {
                        string[] sep = { "and" };
                        string[] subfilters = item.Split(sep, StringSplitOptions.RemoveEmptyEntries);
                        foreach (string subitem in subfilters)
                        {
                            foreach (var song in songs)
                            {
                                if (song.Banda.Contains(subitem) == true)
                                {
                                    final_search.Add(song);
                                }
                            }
                        }
                    }
                    else
                    {
                        foreach (var song in songs)
                        {
                            if (song.Banda.Contains(item) == true)
                            {
                                final_search.Add(song);
                            }
                        }
                    }
                }
            }
            else if (song_name.Contains("and"))
            {
                string[] separator = { "and" };
                string[] filters = song_name.Split(separator, StringSplitOptions.RemoveEmptyEntries);
                foreach (string item in filters)
                {
                    foreach (var song in songs)
                    {

                        if (song.Banda.Contains(item) == true)
                        {
                            final_search.Add(song);
                        }
                    }
                }
            }
            else
            {
                foreach (var song in songs)
                {

                    if (song.Banda.Contains(song_name) == true)
                    {
                        final_search.Add(song);
                    }
                }
            }
            return final_search;


        }
        public List<Cancion> searchAlbum(string song_name, List<Cancion> songs)
        {
            //busca un determinado album en una determinada lista de albums
            List<Cancion> final_search = new List<Cancion>();
            if (song_name.Contains("or"))
            {

                string[] separator = { "or" };
                string[] filters = song_name.Split(separator, StringSplitOptions.RemoveEmptyEntries);
                foreach (string item in filters)
                {
                    if (item.Contains("and"))
                    {
                        string[] sep = { "and" };
                        string[] subfilters = item.Split(sep, StringSplitOptions.RemoveEmptyEntries);
                        foreach (string subitem in subfilters)
                        {
                            foreach (var song in songs)
                            {
                                if (song.Album.Contains(subitem) == true)
                                {
                                    final_search.Add(song);
                                }
                            }
                        }
                    }
                    else
                    {
                        foreach (var song in songs)
                        {
                            if (song.Album.Contains(item) == true)
                            {
                                final_search.Add(song);
                            }
                        }
                    }
                }
            }
            else if (song_name.Contains("and"))
            {
                string[] separator = { "and" };
                string[] filters = song_name.Split(separator, StringSplitOptions.RemoveEmptyEntries);
                foreach (string item in filters)
                {
                    foreach (var song in songs)
                    {

                        if (song.Album.Contains(item) == true)
                        {
                            final_search.Add(song);
                        }
                    }
                }
            }
            else
            {
                foreach (var song in songs)
                {

                    if (song.Album.Contains(song_name) == true)
                    {
                        final_search.Add(song);
                    }
                }
            }

            return final_search;


        }
        public List<Video> buscarActorDirector(string name, List<Video> todosLosVideos)
        {
            List<Video> finalSearch = new List<Video>();

            
                foreach (Video vid in todosLosVideos)
                {
                    int i = 0;
                    try
                    {
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
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error: "+ex.Message);
                    }

                   
                }

            
            return finalSearch;

        }
        public List<Cancion> ratingReproducciones(List<Cancion> todasLasCanciones)
        {
            /*Console.WriteLine("1.Todas las canciones");
            Console.WriteLine("2. 5 primeras");
            int opt = System.Convert.ToInt32(Console.ReadLine());
            if (opt == 1)
            {
                List<Cancion> lista = (from canciones in todasLasCanciones orderby canciones.Reproducciones descending select canciones).ToList();
                int cont = 0;
                foreach (Cancion can in lista)
                {
                    Console.WriteLine(cont);
                    Console.WriteLine("Artista: " + can.Banda);
                    Console.WriteLine("Cancion: " + can.Titulo_Cancion);
                    cont++;

                }
                return lista;
            }*/
            
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
            /*if (opt == 1)
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

            }*/
            
            {
                List<Cancion> lista = (from can in canciones orderby can.Rating descending select can).Take(5).ToList();
                int cont = 0;
                /*foreach (Cancion can in lista)
                {
                    Console.WriteLine(cont);
                    Console.WriteLine("Artista: " + can.Banda);
                    Console.WriteLine("Cancion: " + can.Titulo_Cancion);
                    cont++;

                }*/
                return lista;
            }


        }
        public List<Video> buscarVideoResolucion(string resolucion, List<Video> todosLosVideos)
        {
            List<Video> finalSearch = new List<Video>();
            Console.Write("[1]Mayor '\n' [2]Menor ");
            string res_op = Console.ReadLine();
            
            {
                foreach (Video video in todosLosVideos)
                {
                    int Resolution = Convert.ToInt32(resolucion);
                    if (res_op == "1")
                    {
                        if (video.Weight > Resolution) 
                        {
                            finalSearch.Add(video);
                        }
                    }
                    else if (res_op == "2") 
                    {
                        if (video.Weight < Resolution)
                        {
                            finalSearch.Add(video);
                        }
                    }
                }
            }
            return finalSearch;

        }
    }
}

