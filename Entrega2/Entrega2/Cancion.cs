using System;
using TagLib.Audible;
using MetadataExtractor;
using MetadataExtractor.Formats.Exif;
using System.Reflection.Metadata;
using System.IO;
using TagLib;
using System.Drawing;
using WMPLib;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

namespace Entrega2
{
    public class Cancion
    {
        
        private string titulo_Cancion;
        private uint numero_Cancion_Album;
        private uint fecha_Lanzamiento;
        private string nombre_Estudio;
        private string genero;
        private int rating;//Metodo valorarCancion 
        private int reproducciones = 0;
        private Caratula caratula;
        private string album;
        private IPicture pre_caratula;
        public string path;
        private string banda;
        private int likes;
        private string duration;
        private Image custom_image;
        private string usuario_;
        private bool favorite;

        public string Banda { get => banda; set => banda = value; }
        public string Titulo_Cancion { get => titulo_Cancion; set => titulo_Cancion = value; }
        public uint Numero_Cancion_Album { get => numero_Cancion_Album; set => numero_Cancion_Album = value; }
        public uint Fecha_Lanzamiento { get => fecha_Lanzamiento; set => fecha_Lanzamiento = value; }
        public string Nombre_Estudio { get => nombre_Estudio; set => nombre_Estudio = value; }
        public string Genero { get => genero; set => genero = value; }
        public int Rating { get => rating; set => rating = value; }
        public Caratula Caratula { get => caratula; set => caratula = value; }
        public string Album { get => album; set => album = value; }
        public IPicture Pre_caratula { get => pre_caratula; set => pre_caratula = value; }
        public string Path { get => path; set => path = value; }
        public int Likes { get =>likes; set => likes = value; }
        public int Reproducciones { get => reproducciones; set => reproducciones = value; }
        private Image Custom_image { get => Custom_image; set => Custom_image = value; }
        public string Duration { get =>duration; set => duration = value; }
        public string Usuario_ { get => usuario_; set => usuario_ = value; }
        public bool Favorite { get => favorite; set => favorite = value; }

        public Cancion(string path)
        {

            TagLib.File song = TagLib.File.Create(path);

            this.titulo_Cancion = song.Tag.Title;
            this.Banda = song.Tag.FirstPerformer;
            this.numero_Cancion_Album = song.Tag.Track;
            this.fecha_Lanzamiento = song.Tag.Year;
            this.nombre_Estudio = song.Tag.Conductor;
            this.genero = song.Tag.FirstGenre;
            this.Album = song.Tag.Album;
            this.path = path;
            TimeSpan time_prev = song.Properties.Duration;
            this.Pre_caratula = song.Tag.Pictures.FirstOrDefault();

            if (time_prev.Hours == 0)
            {
                this.duration = Convert.ToString(song.Properties.Duration.Minutes) + ":" + Convert.ToString(song.Properties.Duration.Seconds);
            }
            else if (time_prev.Minutes == 0) 
            {
                this.duration = Convert.ToString(song.Properties.Duration.Seconds);
            }
            
            //Caratula caratula = new Caratula(song.Tag.Pictures);
           
        }



        //Metodo momentaneo
        public string Show_info(Cancion cancion)
        {
            string info;
            info = "Nombre:" + cancion.titulo_Cancion + "\n" + "Compositor: " + cancion.Banda
            +"\n" + "N° pista: "+cancion.numero_Cancion_Album+"\n"
                +"Lanzamiento: "+ cancion.fecha_Lanzamiento + "\n"+ "Estudio: " + cancion.nombre_Estudio+"\n"
                +"Genero: "+ cancion.genero + "\n" + "Album: " + cancion.Album+ "\n" + cancion.duration + "\n";
            return info;
        }
        public void descargarCancion(Cancion song, Usuario usuario)
        {
            string sourcePath = path;
            string targetPath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "../../../../Descargas");
            string destPath = System.IO.Path.Combine(targetPath, titulo_Cancion);
            System.IO.File.Copy(sourcePath, destPath, true);
        }

        public void agregarFavoritos(Usuario user)
        {
            user.Canciones_favoritas.Add(this);
            Console.WriteLine("Cancion " + this.titulo_Cancion + " agregada a favoritos");
        }
        public void valorarCancion()
        {
  
            Console.WriteLine("Ingrese una nota de 0 a 5 a la cancion");
            int nota = System.Convert.ToInt32(Console.ReadLine());
            while (nota<0 ||nota >5)
            {
                Console.WriteLine("Ingrese una nota valida entre 1 y 5");
                nota = System.Convert.ToInt32(Console.ReadLine());

            }
            this.rating = nota;
        }
        public void agregarAPlaylist(Playlist playlist)
        {
            playlist.Canciones.Add(this);
        }

    }
}
