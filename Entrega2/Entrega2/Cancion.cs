using System;
namespace Entrega2
{
    public class Cancion
    {
        private string Nombre_Compositor;
        private string Titulo_Cancion;
        private int Numero_Cancion_Album;
        private DateTime Fecha_Lanzamiento;
        private string Nombre_Estudio;
        private string Genero;
        private string Rating;
        private string Caratula;

        public string Nombre_Compositor1 { get => Nombre_Compositor; set => Nombre_Compositor = value; }
        public string Titulo_Cancion1 { get => Titulo_Cancion; set => Titulo_Cancion = value; }
        public int Numero_Cancion_Album1 { get => Numero_Cancion_Album; set => Numero_Cancion_Album = value; }
        public DateTime Fecha_Lanzamiento1 { get => Fecha_Lanzamiento; set => Fecha_Lanzamiento = value; }
        public string Nombre_Estudio1 { get => Nombre_Estudio; set => Nombre_Estudio = value; }
        public string Genero1 { get => Genero; set => Genero = value; }
        public string Rating1 { get => Rating; set => Rating = value; }
        public string Caratula1 { get => Caratula; set => Caratula = value; }

        public Cancion(string Nombre_Compositor, string Titulo_Cancion, int Numero_Cancion_Album, DateTime Fecha_Lanzamiento, string Nombre_Estudio, string Genero, string Rating, string Caratula)
        {
            this.Nombre_Compositor = Nombre_Compositor;
            this.Titulo_Cancion = Titulo_Cancion;
            this.Numero_Cancion_Album = Numero_Cancion_Album;
            this.Fecha_Lanzamiento = Fecha_Lanzamiento;
            this.Nombre_Estudio = Nombre_Estudio;
            this.Genero = Genero;
            this.Rating = Rating;
            this.Caratula = Caratula;
        }
    }
}
