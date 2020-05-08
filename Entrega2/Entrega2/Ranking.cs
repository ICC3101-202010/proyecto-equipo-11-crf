using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Entrega2
{
    class Ranking
    {
           //Esta en duda si seguir implementando
        private List<Cancion> Ranking_Canciones;
        private List<Video> Ranking_Videos;
        private List<Cancion> Ranking_Canciones_Rating;
        private List<Video> Ranking_Videos_Rating;

        public List<Cancion> Ranking_Canciones1 { get => Ranking_Canciones; set => Ranking_Canciones = value; }
        internal List<Video> Ranking_Videos1 { get => Ranking_Videos; set => Ranking_Videos = value; }
        public List<Cancion> Ranking_Canciones_Rating1 { get => Ranking_Canciones_Rating; set => Ranking_Canciones_Rating = value; }
        internal List<Video> Ranking_Videos_Rating1 { get => Ranking_Videos_Rating; set => Ranking_Videos_Rating = value; }

        public Ranking(List<Cancion> Ranking_Canciones, List<Video> Ranking_Videos)
        {

            this.Ranking_Canciones = Ranking_Canciones;
            this.Ranking_Videos = Ranking_Videos;
        }


        public void Agregar_Cancion(Cancion cancion)
        {
            List<Cancion> Ranking_Canciones = new List<Cancion>();
            Ranking_Canciones.Add(cancion);
        }


        public void Agregar_Video(Video video)
        {
            List<Video> Ranking_Videos = new List<Video>();
            Ranking_Videos.Add(video);
        }


        /* public void Ordenar_Cancion_por_Rating(List<Cancion> Ranking_Canciones)
        {
            Ranking_Canciones.Sort(Cancion cancion.rating);
            foreach ( Cancion cancion in Ranking_Canciones)
            {
                List<Cancion> Ranking_Canciones_Rating = new List<Cancion>();
                Ranking_Canciones_Rating.Add(cancion);
            }

        }

        public void Ordenar_Video_por_Rating(List<Cancion> Ranking_Videos)
        {
            Ranking_Canciones.Sort(Video.rating)
            foreach (Video video in Ranking_Videos)
            {
                List<Video> Ranking_Video_Rating = new List<Video>();
                Ranking_Video_Rating.Add(video);
            }

        }*/
    }
}
