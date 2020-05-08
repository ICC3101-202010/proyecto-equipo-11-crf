using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrega2
{
    class Director:Persona
    {
        private List<Video> peliculas;

        public Director(List<Video> peliculas) 
        { 
            this.peliculas = peliculas;
        }
    }
}
