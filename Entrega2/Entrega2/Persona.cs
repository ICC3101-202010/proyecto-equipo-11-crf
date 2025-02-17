﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrega2
{
    [Serializable]
     public class Persona
    {
        protected string namePerson;
        protected string lastName;
        protected string rut;
        protected string nation;
        private int edad;
        protected string gender;

        public string NamePerson { get => namePerson; set => namePerson = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Rut { get => rut; set => rut = value; }
        public string Nacion { get => nation; set => nation = value; }
        
        public string Gender { get => gender; set => gender = value; }
        public int Edad { get => edad; set => edad = value; }

        /*public Persona(string namePerson, string lastName, string rut, string nation, DateTime birthDate, string gender)
        {
            this.namePerson = namePerson;
            this.lastName = lastName;
            this.rut = rut;
            this.nation = nation;
            this.birthDate = birthDate;
            this.gender = gender;
        }*/
        public Persona() { }
       
    }
}
