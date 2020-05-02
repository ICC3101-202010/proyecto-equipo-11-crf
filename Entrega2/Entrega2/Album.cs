using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Entrega2
{
    class Album : Persona
    {
        private string nombre_Album;
        private Caratula caratula;
        private List<Cancion> cancion;
        private Banda banda;

        
        public string Nombre_Album { get => nombre_Album; set => nombre_Album = value; }

        public Album(string Nombre_Album,  string namePerson, string lastName, string rut, string nation, DateTime birthDate, string gender): base(namePerson, lastName, rut, nation, birthDate, gender)
        {
            this.nombre_Album = Nombre_Album;
        }


    }
}
