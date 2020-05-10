using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Entrega2
{
    public class RegistrarEventArgs : EventArgs
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string Contrasena { get; set; }
        public string VerificationLink { get; set; }
        public string Privacidad { get; set; }
        public List<string> gustos_musica;
        public List<string> gustos_videos;
    }
}
