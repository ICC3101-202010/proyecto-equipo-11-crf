using System;
using TagLib.Audible;
using MetadataExtractor;
using MetadataExtractor.Formats.Exif;
using System.Reflection.Metadata;
using System.IO;
using TagLib;


namespace Entrega2
{
    public class Cancion
    {
        private string[] nombre_Compositor;
        private string titulo_Cancion;
        private uint numero_Cancion_Album;
        private uint fecha_Lanzamiento;
        private string nombre_Estudio;
        private string genero;
        private string rating;
        private Caratula Caratula;

        public string[] Nombre_Compositor { get => nombre_Compositor; set => nombre_Compositor = value; }
        public string Titulo_Cancion { get => titulo_Cancion; set => titulo_Cancion = value; }
        public uint Numero_Cancion_Album { get => numero_Cancion_Album; set => numero_Cancion_Album = value; }
        public uint Fecha_Lanzamiento { get => fecha_Lanzamiento; set => fecha_Lanzamiento = value; }
        public string Nombre_Estudio { get => nombre_Estudio; set => nombre_Estudio = value; }
        public string Genero { get => genero; set => genero = value; }
        public string Rating { get => rating; set => rating = value; }


        public Cancion(string[] Nombre_Compositor, string Titulo_Cancion, uint Numero_Cancion_Album, uint Fecha_Lanzamiento, string Nombre_Estudio, string Genero, string Rating, string Caratula)
        {
            this.nombre_Compositor = Nombre_Compositor;
            this.titulo_Cancion = Titulo_Cancion;
            this.numero_Cancion_Album = Numero_Cancion_Album;
            this.fecha_Lanzamiento = Fecha_Lanzamiento;
            this.nombre_Estudio = Nombre_Estudio;
            this.genero = Genero;
            this.rating = Rating;
        }

        public Cancion(string path)
        {
            
            TagLib.File song = TagLib.File.Create(path);

            this.titulo_Cancion = song.Tag.Title;
            this.nombre_Compositor = song.Tag.Composers;
            this.numero_Cancion_Album = song.Tag.Track;
            this.fecha_Lanzamiento = song.Tag.Year;
            this.nombre_Estudio = song.Tag.Conductor;
            this.genero = song.Tag.FirstGenre;
            


        }
        //@"C:Users/Francisco/Desktop/proyecto-equipo-1-crf/The Weeknd-Blinding Lights.mp3";
        string TW = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "../The Weeknd-Blinding Lights.mp3");
        TagLib.File music = TagLib.File.Create(TW);
       
      

        //Para testear

    }
}
