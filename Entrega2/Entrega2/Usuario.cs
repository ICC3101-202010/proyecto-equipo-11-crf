using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrega2
{
    class Usuario : Persona
    {
        protected int id;
        protected bool member;
        protected DateTime member_expiration;
        protected bool administrador;
        protected string mail;
        protected string contraseña;
        protected int telefono;
        protected string username;

        public int ID  { get => id; set => id = value; }
        public bool Member { get => member; set => member = value; }
        public DateTime Member_expiration  { get => member_expiration; set => member_expiration = value; }
        public bool Administrador { get => administrador; set => administrador = value; }
        public string Mail { get => mail; set => mail = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }
        public int Telefono { get => telefono; set => telefono = value; }

        public string Username { get => username; set => username = value; }

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
        }
        public Usuario() 
        {
        
        }

    }
}
