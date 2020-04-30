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

        public Actor(List<Video> peliculas, string namePerson, string lastName, string rut, string nation, DateTime birthDate, string gender): base(namePerson,lastName,rut,nation,birthDate,gender)
        {
            this.peliculas = peliculas;
        }
    }
}
