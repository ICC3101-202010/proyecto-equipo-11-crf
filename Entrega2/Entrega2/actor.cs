using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrega2
{
    public class Actor : Persona
    {
        private List<Video> peliculas;
        internal List<Video> Peliculas { get => peliculas; set => peliculas = value; }

        public Actor(List<Video> peliculas, string NamePerson1, string LastName1, string nation1, int edad, string gender)
        {
            this.peliculas = peliculas;
            this.NamePerson = NamePerson1;
            this.LastName = LastName1;
            this.nation = nation1;
            this.Gender = gender;
            this.Edad = edad;
        }
    }
}
