using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace Entrega2
{
    public class Playlist
    {
        private string nombrePlaylist;
        private List<Cancion> canciones;
        private List<Video> videos;
        private Image imagen_personalizada;
        private string NombreCreador;

        public string NombrePlaylist { get => nombrePlaylist; set => nombrePlaylist = value; }
        public List<Cancion> Canciones { get => canciones; set => canciones = value; }
        internal List<Video> Videos { get => videos; set => videos = value; }

        public Image Imagen_personalizada { get => imagen_personalizada; set => imagen_personalizada = value; }
        public string NombreCreador1 { get => NombreCreador; set => NombreCreador = value; }

        public Playlist(string nombrePlaylist, List<Cancion> canciones, List<Video> videos, string NombreCreador)
        {
            this.nombrePlaylist = nombrePlaylist;
            this.Canciones = canciones;
            this.Videos = videos;
            this.NombreCreador = NombreCreador;

        }
        public void mostrarCanciones()
        {
            for (int i = 0; i < canciones.Count; i++)
            {
                Console.WriteLine("Cancion " + (i));
                Console.WriteLine("Nombre Cancion: " + canciones[i].Titulo_Cancion);
                Console.WriteLine("Artista :" + canciones[i].Banda);
                Console.WriteLine("");

            }
        }
        public void agregarCancionPlaylist(Cancion cancion)
        {

            canciones.Add(cancion);
            Console.WriteLine("Cancion " + cancion.Titulo_Cancion + " agregada");

        }
        public void eliminarCancionPlaylist()
        {
            mostrarCanciones();
            Console.WriteLine("Ingrese el numero de la cancion que desea eliminar");
            int eliminada = Convert.ToInt32(Console.ReadLine());
            Cancion cancionEliminada = canciones[eliminada];
            canciones.Remove(canciones[eliminada]);
            Console.WriteLine("Cancion " + cancionEliminada.Titulo_Cancion + " eliminada");

        }
        public void addIamge()
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "../../../../Images");
            DirectoryInfo Image_folder = new DirectoryInfo(path);
            int index = 0;
            foreach (var image_file in Image_folder.GetFiles())
            {
                Console.WriteLine(Convert.ToString(index) + image_file);
                index++;
            }
            Console.WriteLine("Choose a picture");
            int selecction = Convert.ToInt32(Console.ReadLine());
            int Count = 0;
            foreach (var image_file in Image_folder.GetFiles())
            {
                if (Count == selecction)
                {
                    Imagen_personalizada = Image.FromFile(image_file.FullName);
                }
                Count++;
            }


        }
        public void Lista_favoritos(List<Cancion> all_songs, Usuario usuario)
        {
          Playlist favoritos = new Playlist("Favortitos",all_songs,null,usuario.NamePerson);
            
        }
       
        
    }
}
