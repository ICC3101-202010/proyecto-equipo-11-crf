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
        
        private string titulo_Cancion;
        private uint numero_Cancion_Album;
        private uint fecha_Lanzamiento;
        private string nombre_Estudio;
        private string genero;
        public int rating;
        public int reproducciones = 0;
        private Caratula caratula;
        private string album;
        private IPicture[] pre_caratula;
        private string path;
        private string banda;
        private int likes;

        public string Banda { get => banda; set => banda = value; }
        public string Titulo_Cancion { get => titulo_Cancion; set => titulo_Cancion = value; }
        public uint Numero_Cancion_Album { get => numero_Cancion_Album; set => numero_Cancion_Album = value; }
        public uint Fecha_Lanzamiento { get => fecha_Lanzamiento; set => fecha_Lanzamiento = value; }
        public string Nombre_Estudio { get => nombre_Estudio; set => nombre_Estudio = value; }
        public string Genero { get => genero; set => genero = value; }
        public int Rating { get => rating; set => rating = value; }
        public Caratula Caratula { get => caratula; set => caratula = value; }
        public string Album { get => album; set => album = value; }
        public IPicture[] Pre_caratula { get => pre_caratula; set => pre_caratula = value; }
        public string Path { get => path; set => path = value; }
        public int Likes { get =>likes; set => likes = value; }

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
            this.pre_caratula = song.Tag.Pictures;
            this.path = path;
            this.likes = likes;
            //Caratula caratula = new Caratula(song.Tag.Pictures);
           
        }



        //Metodo momentaneo
        public string Show_info(Cancion cancion)
        {
            string info;
            info = "Nombre:" + cancion.titulo_Cancion + "\n" + "Compositor: " + cancion.Banda
            +"\n" + "N° pista: "+cancion.numero_Cancion_Album+"\n"
                +"Lanzamiento: "+ cancion.fecha_Lanzamiento + "\n"+ "Estudio: " + cancion.nombre_Estudio+"\n"
                +"Genero: "+ cancion.genero + "\n" + "Album: " + cancion.Album+ "\n";
            return info;
        }
        public void descargarCancion()
        {

        }
    }
}
