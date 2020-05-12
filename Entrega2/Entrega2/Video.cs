using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetadataExtractor.Formats.Mpeg;

namespace Entrega2
{
    public class Video
    {
        private string nameVideo;
        private string direccionMemoria;
        private string genero;
        private int vistos;
        private List<Actor> actores;
        private Director director;
        private string estudio;
        private string caratula;
        private string coment;
        private int rating;
        private uint year;
        private string category;
        private string duration;
        private double resolution;

        public string NameVideo { get => nameVideo; set => nameVideo = value; }
        public string DireccionMemoria { get => direccionMemoria; set => direccionMemoria = value; }
        public string Genero { get => genero; set => genero = value; }
        public int Vistos { get => vistos; set => vistos = value; }
        public string Estudio { get => estudio; set => estudio = value; }
        public string Caratula { get => caratula; set => caratula = value; }
        internal List<Actor> Actores { get => actores; set => actores = value; }
        internal Director Director { get => director; set => director = value; }
        public string Coment { get => coment; set => coment = value; }
        public uint Year { get => year; set => year = value; }
        public int Rating { get => rating; set => rating = value; }

        public string Categoria { get => category; set => category = value; }

        public string Duration { get => duration; set => duration = value; }
        public double Resolution { get => resolution; set => resolution = value; }

        public Video(string path)
        {
            TagLib.File video = TagLib.File.Create(path);
            this.nameVideo=video.Tag.Title;
            this.genero = video.Tag.FirstGenre;
            this.year = video.Tag.Year;
            this.coment = video.Tag.Comment;
            TimeSpan time_prev = video.Properties.Duration;

                

            foreach (var codec in video.Properties.Codecs)
            {
                if (codec is TagLib.Mpeg.VideoHeader)
                {
                    TagLib.Mpeg.VideoHeader G = (TagLib.Mpeg.VideoHeader)codec;
                    this.resolution = G.VideoFrameRate;
                    
                }
            }
            Console.WriteLine(Resolution);
            ;

            if (time_prev.Hours == 0)
            {
                this.duration = Convert.ToString(video.Properties.Duration.Minutes) + ":" + Convert.ToString(video.Properties.Duration.Seconds);
            }
            else if (time_prev.Minutes == 0)
            {
                this.duration = Convert.ToString(video.Properties.Duration.Seconds);
            }



        }
        public void agregarFavoritosVideo(Usuario user)
        {
            user.Videos_favoritos.Add(this);
            Console.WriteLine("Video " + this.nameVideo + " agregado a favoritos");
        }
    }
}
