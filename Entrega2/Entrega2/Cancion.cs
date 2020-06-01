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
    [Serializable]
    public class Cancion
    {

        private string titulo_Cancion;
        private uint numero_Cancion_Album;
        private uint fecha_Lanzamiento;
        private string nombre_Estudio;
        private string genero;
        private int rating;//Metodo valorarCancion 
        private int reproducciones = 0;
        private string album;
        private IPicture pre_caratula;
        public string path;
        private string banda;
        private int likes;
        private string duration;
        private string usuario_;
        private bool favorite;
        private string letra;
        private int seconds;
        private int Largo_letra;
        private Image custom_image;

        public string Banda { get => banda; set => banda = value; }
        public string Titulo_Cancion { get => titulo_Cancion; set => titulo_Cancion = value; }
        public uint Numero_Cancion_Album { get => numero_Cancion_Album; set => numero_Cancion_Album = value; }
        public uint Fecha_Lanzamiento { get => fecha_Lanzamiento; set => fecha_Lanzamiento = value; }
        public string Nombre_Estudio { get => nombre_Estudio; set => nombre_Estudio = value; }
        public string Genero { get => genero; set => genero = value; }
        public int Rating { get => rating; set => rating = value; }
        public string Album { get => album; set => album = value; }
        public IPicture Pre_caratula { get => pre_caratula; set => pre_caratula = value; }
        public string Path { get => path; set => path = value; }
        public int Likes { get => likes; set => likes = value; }
        public int Reproducciones { get => reproducciones; set => reproducciones = value; }
        public Image Custom_image { get => custom_image; set => custom_image = value; }
        public string Duration { get => duration; set => duration = value; }
        public string Usuario_ { get => usuario_; set => usuario_ = value; }
        public bool Favorite { get => favorite; set => favorite = value; }
        public string Letra { get => letra; set => letra = value; }
        public int Seconds { get => seconds; set => seconds = value; }
        public int Largoletra { get => Largo_letra; set => Largo_letra = value; }

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
            this.letra = song.Tag.Lyrics;

            if (time_prev.Hours == 0)
            {
                this.duration = Convert.ToString(song.Properties.Duration.Minutes) + ":" + Convert.ToString(song.Properties.Duration.Seconds);
            }
            else if (time_prev.Minutes == 0)
            {
                this.duration = Convert.ToString(song.Properties.Duration.Seconds);
            }

            MemoryStream ms = new MemoryStream(song.Tag.Pictures[0].Data.Data);
            this.Custom_image = Image.FromStream(ms);



            this.seconds = Convert.ToInt32(song.Properties.Duration.Seconds);
            
        }
        public Cancion() 
        { 
        
        }

        public void descargarCancion( Usuario usuario)
        {
            
            string sourcePath = path;
            string targetPath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "../../../../Descargas");
            string ruta = System.IO.Path.Combine(targetPath, "usuario.Username");
            if (!System.IO.Directory.Exists(ruta))
            {
                Console.WriteLine("Creando Carpeta Usuario");
                DirectoryInfo di = System.IO.Directory.CreateDirectory(ruta);
            }
            string destPath = System.IO.Path.Combine(ruta, titulo_Cancion);
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
            while (nota < 0 || nota > 5)
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
        public string lyrics()
        {
            return Letra;
        }


        public Cancion TNL() 
        {
            Cancion tnl = new Cancion("C:/Users/Francisco/Desktop/proyecto-equipo-11-crf/Biblioteca/TheManWhoNeveLied.mp3");
            return tnl;
        
        
        } 
 

    }
}
