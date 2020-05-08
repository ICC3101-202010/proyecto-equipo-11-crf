using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Entrega2
{
     class Musico : Persona
     {
        private string rol;
        private Banda banda;
        private List<Cancion> canciones;


        public string Rol { get => rol; set => rol = value; }
        public Banda Banda { get => banda; set => banda = value; }
        public List<Cancion> Canciones { get => canciones; }
        //string rol, Banda banda, List<Cancion> cancion,
        public Musico(string rol, Banda banda, List<Cancion> cancion, string namePerson, string lastName, string rut, string nation, DateTime birthDate, string gender)// : base(namePerson, lastName, rut, nation, birthDate, gender)
        {   this.rol = rol;
            this.banda = banda;
            this.canciones = cancion;
        }
     }
}
