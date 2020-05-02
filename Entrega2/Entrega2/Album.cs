using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Entrega2
{
    class Album
    {
        private string Nombre_Album;
        private Caratula Caratula;
        private List<Cancion> cancion;
        private Banda Banda;

        
        public string Nombre_Album1 { get => Nombre_Album; set => Nombre_Album = value; }

        //public Album(string Nombre_Album)
        //{
        //    this.Nombre_Album = Nombre_Album;
        //}

    }
}
