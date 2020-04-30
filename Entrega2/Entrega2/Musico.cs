using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Entrega2
{
    class Musico:Persona
    {
        private string Rol;
        private Banda Banda;
        private List<Cancion> canciones;


        public string Rol1 { get => Rol; set => Rol = value; }

        public Musico(string Rol) => this.Rol = Rol;
    }
}
