using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using TagLib;
namespace Entrega2
{
    class Album
    {
        private string nombre_Album;
        private Caratula caratula;
        private List<Cancion> cancion;
        private Banda banda;

        //Album agregar canciones segun album , como cuando me meto a spotify y veo las canciones segun album
        
        public string Nombre_Album { get => nombre_Album; }
        public Caratula Caratula { get => caratula; }
        public List<Cancion> Cancion { get => cancion; }
        public Banda Banda { get =>banda;  }


        public Album(Cancion song)
        {
            
        }


    }
}
