using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrega2
{
    public class Usuario : Persona
    {
        protected int id;
        protected bool member;
        protected DateTime member_expiration;
        protected bool administrador;
        protected string mail;
        protected string contraseña;
        protected int telefono;
        protected string username;
<<<<<<< HEAD
      
        private List<Cancion> canciones_favoritas;
        private List<Video> videos_favoritos;
=======
        public List<Cancion> canciones_favoritas;
        public List<Video> videos_favoritos;
>>>>>>> 6f90dcae4cd88c649818c6948be2323385e0dd15



        public int ID  { get => id; set => id = value; }
        public bool Member { get => member; set => member = value; }
        public DateTime Member_expiration  { get => member_expiration; set => member_expiration = value; }
        public bool Administrador { get => administrador; set => administrador = value; }
        public string Mail { get => mail; set => mail = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }
        public int Telefono { get => telefono; set => telefono = value; }

        public string Username { get => username; set => username = value; }
        public List<Cancion> Canciones_favoritas { get => canciones_favoritas; set => canciones_favoritas = value; }
        internal List<Video> Videos_favoritos { get => videos_favoritos; set => videos_favoritos = value; }

        public Usuario(int ID, bool member, DateTime Member_expiration,bool Administrador,string Mail,string contraseña,int telefono, string NamePerson, string LastName, string Rut, string Nation, DateTime BirthDate) 
        {
            this.id = ID;
            this.member_expiration = Member_expiration;
            this.administrador = Administrador;
            this.contraseña = contraseña;
            this.telefono = telefono;
            this.mail = Mail;
            this.member = member;
            this.namePerson = NamePerson;
            this.lastName = LastName;        
            this.nation = Nation;
            this.birthDate = BirthDate;
            this.canciones_favoritas = canciones_favoritas;
            this.videos_favoritos = videos_favoritos;
        }

        public Usuario()
        {
        }

        // 1- Define a Delegate
        public delegate void EmailVerifiedEventHandler(object source, EventArgs args);

        // 2- Define an Event based on that Delegate
        public event EmailVerifiedEventHandler EmailVerified;

        // 3- Raise the Event
        protected virtual void OnEmailVerified()
        {
            if (EmailVerified != null)
            {
                EmailVerified(this, EventArgs.Empty);
            }
        }
        public void OnEmailSent(object source, EventArgs e)
        {
            Console.WriteLine("Quiere Verificar su Correo?  ( 1 = Si / 2 = No )");
            int verificacion = Convert.ToInt16(Console.ReadLine());
            if (verificacion == 1)
            {
                OnEmailVerified();

            }
        }





    }
}
