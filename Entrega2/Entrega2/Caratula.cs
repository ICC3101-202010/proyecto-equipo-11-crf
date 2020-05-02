using System;
using TagLib;

namespace Entrega2
{
    public class Caratula
    {
        private string direccion;
        
        
        public string Direccion { get => direccion; set => direccion = value; }

        public Caratula(IPicture[] imagen)
        {
            this.direccion = Direccion;

        }

    }
}
