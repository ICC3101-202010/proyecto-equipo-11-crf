using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetadataExtractor.Formats.Mpeg;

namespace Entrega2
{
    class Video
    {
        private string nameVideo;
        private string direccionMemoria;
        private string genero;
        private int vistos;
        private List<Actor> actores;
        private Director director;
        private string estudio;
        private string caratula;

        public string NameVideo { get => nameVideo; set => nameVideo = value; }
        public string DireccionMemoria { get => direccionMemoria; set => direccionMemoria = value; }
        public string Genero { get => genero; set => genero = value; }
        public int Vistos { get => vistos; set => vistos = value; }
        public string Estudio { get => estudio; set => estudio = value; }
        public string Caratula { get => caratula; set => caratula = value; }
        internal List<Actor> Actores { get => actores; set => actores = value; }
        internal Director Director { get => director; set => director = value; }

        public Video(string path)
        {
            TagLib.File video = TagLib.File.Create(path);

            

        }
    }
}
