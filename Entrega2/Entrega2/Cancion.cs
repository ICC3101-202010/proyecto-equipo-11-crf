using System;
using TagLib.Audible;
using MetadataExtractor;
using MetadataExtractor.Formats.Exif;
using System.Reflection.Metadata;
using System.IO;
using TagLib;
using System.Drawing;


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
        private Caratula caratula;


        public string[] Nombre_Compositor { get => nombre_Compositor; set => nombre_Compositor = value; }
        public string Titulo_Cancion { get => titulo_Cancion; set => titulo_Cancion = value; }
        public uint Numero_Cancion_Album { get => numero_Cancion_Album; set => numero_Cancion_Album = value; }
        public uint Fecha_Lanzamiento { get => fecha_Lanzamiento; set => fecha_Lanzamiento = value; }
        public string Nombre_Estudio { get => nombre_Estudio; set => nombre_Estudio = value; }
        public string Genero { get => genero; set => genero = value; }
        public string Rating { get => rating; set => rating = value; }
        public Caratula Caratula { get => caratula; set => caratula = value; }
        public Cancion(string path)
        {

            TagLib.File song = TagLib.File.Create(path);

            this.titulo_Cancion = song.Tag.Title;
            this.nombre_Compositor = song.Tag.Composers;
            this.numero_Cancion_Album = song.Tag.Track;
            this.fecha_Lanzamiento = song.Tag.Year;
            this.nombre_Estudio = song.Tag.Conductor;
            this.genero = song.Tag.FirstGenre;
            Caratula caratula = new Caratula(song.Tag.Pictures);




        }
        //@"C:Users/Francisco/Desktop/proyecto-equipo-1-crf/The Weeknd-Blinding Lights.mp3";
        string TW = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "../The Weeknd-Blinding Lights.mp3");
        //TagLib.File music = TagLib.File.Create(TW);

        //Metodo momentaneo
        public string Show_info(Cancion cancion)
        {
            string info;
            info = "Nombre:" + cancion.titulo_Cancion + "Compositor: " + cancion.nombre_Compositor;
            return info;
        }

    }
}
