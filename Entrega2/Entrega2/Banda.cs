using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Entrega2
{
    class Banda
    {
        //Ver si se implementa  o no porque está ambiguo
        private string Nombre_Banda;
        private List<Musico> musicos;
        private string Info;
        private string Caratula;
       

        public string Nombre_Banda1 { get => Nombre_Banda; set => Nombre_Banda = value; }
        public string Info1 { get => Info; set => Info = value; }
        public string Caratula1 { get => Caratula; set => Caratula = value; }
        internal List<Musico> Musicos { get => musicos; set => musicos = value; }


        public Banda(string Nombre_Banda, List<Musico> musicos, string Info, string Caratula)
        {
            this.Nombre_Banda = Nombre_Banda;
            this.musicos = musicos;
            this.Info = Info;
            this.Caratula = Caratula;
        }
    }
}
