﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
using System.IO;


namespace Entrega2
{
    [Serializable]
    public class Usuario : Persona
    {
        protected int id;
        protected string member;
        protected DateTime member_expiration;
        protected string administrador;
        protected string mail;
        protected string contraseña;
        protected string telefono;
        protected string username;
        public string privacidad;
        public string followers;
        public string following;
        public string artista1;
        public string artista2;
        public string artista3;
        public string FotoPerfil;


        public List<Cancion> canciones_favoritas=new List<Cancion>();
        private List<Video> videos_favoritos = new List<Video>();




        private List<Playlist> my_Playlist = new List<Playlist>();

        private List<Usuario> seguidosUsuarios;
        private List<Usuario> MeSiguenUsuarios;

        public List<string> seguidosPlaylist=new List<string>();
        public List<string> seguidosAlbum=new List<string>();
        public List<string> seguidosBanda=new List<string>();

        private List<Actor> seguidosActor;

        

        public int ID  { get => id; set => id = value; }
        public string Member { get => member; set => member = value; }
        public DateTime Member_expiration  { get => member_expiration; set => member_expiration = value; }
        public string Administrador { get => administrador; set => administrador = value; }
        public string Mail { get => mail; set => mail = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }
        public string Telefono { get => telefono; set => telefono = value; }

        public string Username { get => username; set => username = value; }
        public List<Cancion> Canciones_favoritas { get => canciones_favoritas; set => canciones_favoritas = value; }
        //internal List<Video> Videos_favoritos { get => Videos_favoritos1; set => Videos_favoritos1 = value; }

        public List<Usuario> SeguidosUsuarios { get => seguidosUsuarios; set => seguidosUsuarios = value; }

        
        internal List<string> SeguidosPlaylist { get => seguidosPlaylist; set => seguidosPlaylist = value; }
        internal List<string> SeguidosAlbum { get => seguidosAlbum; set => seguidosAlbum = value; }
        internal List<string> SeguidosBanda { get => seguidosBanda; set => seguidosBanda = value; }

        internal List<Actor> SeguidosActor { get => seguidosActor; set => seguidosActor = value; }
        public List<Playlist> My_Playlist { get => my_Playlist; set => my_Playlist = value; }
        public List<Usuario> MeSiguenUsuarios1 { get => MeSiguenUsuarios; set => MeSiguenUsuarios = value; }
        public List<Video> Videos_favoritos { get => videos_favoritos; set => videos_favoritos = value; }

        public Usuario(int ID, string member, DateTime Member_expiration,string Administrador,string Mail,string contraseña,string telefono, string NamePerson, string LastName, string Rut, string Nation) 
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
            //this.canciones_favoritas = canciones_favoritas;
            //this.videos_favoritos = videos_favoritos;
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


        public void OpcionesUsuario()
        {
            RegistroUsuarios database = new RegistroUsuarios();
            server server = new server(database);
            
            
            int a = 1;
            while (a == 1)
            {
                Console.WriteLine("Que te gustaria hacer?");
                Console.WriteLine("1 --> Cambiar Nombre de Usuario");
                Console.WriteLine("2 --> Cambiar Contrasena");
                Console.WriteLine("3 --> Cambiar Membresia");
                Console.WriteLine("4 --> Salir");
                int respuesta = Convert.ToInt32(Console.ReadLine());
                if (respuesta == 1)
                {
                    server.CambiarNombreUsuario();
                    
                }
                else if (respuesta == 2)
                {
                    server.CambiarContrasena();
                   
                }
                else if (respuesta == 3)
                {

                    List<string> usuario1 = new List<string>();
                    Membresia_Usuario usuario = new Membresia_Usuario();
                    usuario.username = username;
                    member = database.RetornarMembresia(username);
                    usuario.member = member;
                    usuario1.Add(username);
                    usuario1.Add(mail);
                    usuario1.Add(contraseña);
                    usuario1.Add(privacidad);
                    string link= server.GenerateLink(username);
                    usuario1.Add(link);
                    usuario1.Add(Convert.ToString(DateTime.Now));
                    usuario1.Add(telefono);
                    usuario1.Add(member);
                    
                    if (member == "true")
                    {
                        Console.WriteLine("Actualmente eres un Miembro Premium de Spotflix");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("Deseas Cancelar tu Membresia?");
                        Console.WriteLine("1 --> Si");
                        Console.WriteLine("2 --> No");
                        int b = 0;
                        int cancelar = Convert.ToInt32(Console.ReadLine());
                        while (b== 0)
                        {
                            if (cancelar == 1)
                            {
                                IFormatter formatter = new BinaryFormatter();
                                Stream stream = new FileStream("MyFile.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
                                Usuario usuario2 = formatter.Deserialize(stream) as Usuario;
                                stream.Close();
                                string verificationLink = server.GenerateLink(usuario2.Username);
                                database.AddUser(new List<string>() { usuario2.Username, usuario2.Mail, usuario2.Contraseña, usuario2.privacidad, verificationLink, Convert.ToString(DateTime.Now), usuario2.Telefono, usuario2.Member, usuario2.followers });

                                Console.Clear();
                                Console.WriteLine("Lamentamos Verte Partir!");
                                Console.WriteLine("");
                                Console.WriteLine("Ingresa tu nombre de Usuario");
                                string nombre = Console.ReadLine();
                                Console.WriteLine("Por favor escribenos el motivo de tu partida");
                                string motivo = Console.ReadLine();
                                Console.WriteLine("Presiona Enter para Confirmar la Cancelacion de tu Membresia");
                                string confirmacion = Console.ReadLine();
                                if (confirmacion== "")
                                {
                                    database.UpdateMembership(usuario1);
                                    
                                    member = "false";
                                    usuario2.Member = member;
                                    b = 1;
                                    Console.Clear();
                                    List<string> data = database.GetData(nombre);
                                    /*Usuario usuario4 = new Usuario();
                                    usuario4.Username = data[0];
                                    usuario4.Username = data[1];
                                    usuario4.Mail = data[2];
                                    usuario4.Contraseña = data[3];
                                    usuario4.privacidad = data[4];
                                    usuario4.Telefono = data[7];
                                    usuario4.Member = member;
                                    usuario4.followers = data[9];*/

                                    IFormatter formatter1 = new BinaryFormatter();
                                    Stream stream1 = new FileStream("MyFile.bin", FileMode.Create, FileAccess.Write, FileShare.None);
                                    formatter1.Serialize(stream1, usuario2);
                                    stream1.Close();
                                    /*IFormatter formatter1 = new BinaryFormatter();
                                    Stream stream1 = new FileStream("MyFile.bin", FileMode.Create, FileAccess.Write, FileShare.None);
                                    formatter1.Serialize(stream1, usuario);
                                    stream1.Close();*/

                                }
                            }
                            else
                            {
                                member = "true";
                                b = 1;
                               
                            }
                        }
                        
                    }
                    else
                    {
                        IFormatter formatter = new BinaryFormatter();
                        Stream stream = new FileStream("MyFile.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
                        Usuario usuario2 = formatter.Deserialize(stream) as Usuario;
                        stream.Close();
                        string verificationLink = server.GenerateLink(usuario2.Username);
                        database.AddUser(new List<string>() { usuario2.Username, usuario2.Mail, usuario2.Contraseña, usuario2.privacidad, verificationLink, Convert.ToString(DateTime.Now), usuario2.Telefono, usuario2.Member, usuario2.followers });

                        Console.WriteLine("Aun No eres un Usuario Premium de Spotflix!");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("Deseas Contratar tu Membresia y formar parte de la Comunidad mas grande de Listeners en el Mundo?");
                        Console.WriteLine("1 --> Si");
                        Console.WriteLine("2 --> No");
                        int contratar = Convert.ToInt32(Console.ReadLine());
                        if (contratar == 1)
                        {
                            
                            database.UpdateMembership(usuario1);
                            Console.Clear();
                            Console.WriteLine("Bienvenido a Spotflix Premium!");
                            Console.WriteLine("");
                            Console.WriteLine("Ya puedes disfrutar de musica Ilimitada y sin Anuncios!");
                            member = "true";
                            usuario2.Member = member;
                            //List<string> data = database.GetData(nombre);
                            /*Usuario usuario4 = new Usuario();
                            usuario4.Username = data[0];
                            usuario4.Username = data[1];
                            usuario4.Mail = data[2];
                            usuario4.Contraseña = data[3];
                            usuario4.privacidad = data[4];
                            usuario4.Telefono = data[7];
                            usuario4.Member = member;
                            usuario4.followers = data[9];*/

                            IFormatter formatter1 = new BinaryFormatter();
                            Stream stream1 = new FileStream("MyFile.bin", FileMode.Create, FileAccess.Write, FileShare.None);
                            formatter1.Serialize(stream1, usuario2);
                            stream1.Close();
                            Thread.Sleep(2000);

                            /*IFormatter formatter1 = new BinaryFormatter();
                            Stream stream1 = new FileStream("MyFile.bin", FileMode.Create, FileAccess.Write, FileShare.None);
                            formatter1.Serialize(stream1, usuario);
                            stream1.Close();*/
                            break;
                            
                        }
                        else
                        {
                            member = "false";
                            
                        }
                    }
                        
                }
                else if (respuesta == 4)
                {
                    a = 0;
                }
                else
                {
                    Console.WriteLine("Opcion Invalida");
                    a = 1;
                }
            }
            
        }



        public void seguirUsuario(string user)
        {
            //this.SeguidosUsuarios.Add(user);
        }
        public void seguirPlaylist(Playlist playlist)
        {
            //this.seguidosPlaylist.Add(playlist);
        }
        public void seguirActor(Actor actor)
        {
            this.seguidosActor.Add(actor);
        }
        public void seguirAlbum(Album album)
        {
            //this.seguidosAlbum.Add(album);
            
        }
        public void seguirBanda(Banda banda)
        {
            //this.seguidosBanda.Add(banda);
        }


        public string Info_Personas()
        {
            string a = "Nombre de Usuario: " + username +  ", Mail: " + mail;
            return a;
        }


    }
}
