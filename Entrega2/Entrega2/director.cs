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

        public Director(List<Video> peliculas, string namePerson, string lastName, string rut, string nation, DateTime birthDate, string gender):base(namePerson,lastName,rut,nation,birthDate,gender)
        {
            this.peliculas = peliculas;
        }
    }
}
