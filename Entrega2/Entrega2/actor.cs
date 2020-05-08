using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrega2
{
    class Actor : Persona
    {
        private List<Video> peliculas;
        internal List<Video> Peliculas { get => peliculas; set => peliculas = value; }

        public Actor(List<Video> peliculas, string NamePerson, string LastName, string nation, DateTime birthDate, string gender)
        {
            this.peliculas = peliculas;
        }
    }
}
