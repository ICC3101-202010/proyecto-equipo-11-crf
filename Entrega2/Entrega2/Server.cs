﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;

namespace Entrega2
{
    public class server : RegistroUsuarios
    {

        
        private List<string>  cantantes;

        List<string> cantantes_list = new List<string>();

        public List<string> Cantantes { get => cantantes; set => cantantes = value; }
        // 1- Define a Delegate
        public delegate void RegisterEventHandler(object source, RegistrarEventArgs args);
        // 2- Define an Event based on that Delegate
        public event RegisterEventHandler Registered;
        // 3- Raise the Event
        protected virtual void OnRegistered(string username, string contrasena, string verificationlink, string email)
        {
            if (Registered != null)
            {
                Registered(this, new RegistrarEventArgs() { VerificationLink = verificationlink, Contrasena = contrasena, Username = username, Email = email });
            }
        }


        
        public delegate void ChangePasswordEventHandler(object source, CambiarContrasenaEventArgs args);
        
        public event ChangePasswordEventHandler PasswordChanged;
       
        protected virtual void OnPasswordChanged(string username, string email, string number)
        {
            if (PasswordChanged != null)
            {
                PasswordChanged(this, new CambiarContrasenaEventArgs() { Username = username, Email = email, Number = number });
            }
        }



        public delegate void ChangeUsernameEventHandler(object source, CambiarNombreUsuarioEventArgs args);

        public event ChangeUsernameEventHandler UsernameChanged;

        protected virtual void OnUsernameChanged( string email, string number)
        {
            if (UsernameChanged != null)
            {
                UsernameChanged(this, new CambiarNombreUsuarioEventArgs {  Email = email, Number = number });
            }
        }


        public RegistroUsuarios Data { get; }
        

        public server(RegistroUsuarios data)
        {
            this.Data = data;
        }

        public void MostrarUsuarios()
        {
            foreach (List<string> user in this.registrados.Values)
            {
                Console.WriteLine(user[0]);
                Console.WriteLine(user[1]);
                Console.WriteLine(user[2]);  
                
            }
        }
        public List<string> LogIn()
        {


            /*IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("MyFile.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
            Usuario usuario = formatter.Deserialize(stream) as Usuario;
            stream.Close();
            RegistroUsuarios reg = new RegistroUsuarios();
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("MyFile.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
            List<string> data = formatter.Deserialize(stream) as List<string> ;
            reg.registrados.Add(registrados.Count + 1, data); */



            /*IFormatter formatter2 = new BinaryFormatter();
            Stream stream2 = new FileStream("MyFile.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
            Usuario usuario2= formatter2.Deserialize(stream2) as Usuario;

            stream2.Close();
            */
            try
            {
                IFormatter formatter1 = new BinaryFormatter();
                Stream stream1 = new FileStream("MyFile.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
                Usuario usuario1 = formatter1.Deserialize(stream1) as Usuario;
                stream1.Close();
                string verificationLink = GenerateLink(usuario1.Username);
                Data.AddUser(new List<string>()
                {usuario1.Username,  usuario1.Mail, usuario1.Contraseña, usuario1.privacidad, verificationLink, Convert.ToString(DateTime.Now),  usuario1.Telefono, usuario1.Member, usuario1.followers});
            }
            catch (Exception ex)
            {
                IFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream("MyFile.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
                Usuario usuario1 = formatter.Deserialize(stream) as Usuario;
                stream.Close();
                string verificationLink = GenerateLink(usuario1.Username);
                Data.AddUser(new List<string>()
                {usuario1.Username,  usuario1.Mail, usuario1.Contraseña, usuario1.privacidad, verificationLink, Convert.ToString(DateTime.Now),  usuario1.Telefono, usuario1.Member, usuario1.followers});
            }
            

            

            List<string> datosLogin = new List<string>();
            Console.WriteLine("Bienvenido de vuelta a Spotflix! Te extrañamos!");
            Console.WriteLine("Ingresa tu nombre de usuario: \n");
            string usuario = Console.ReadLine();
            Console.Write("Ingresa tu Contraseña: ");
            string contrasena = Console.ReadLine();

            string result = Data.LogIn(usuario, contrasena);
            datosLogin.Add(result);
            datosLogin.Add(usuario);
            return datosLogin;

        }
        
        
        public void Registrarse()
        {
            
            Usuario usuario1 = new Usuario();
            Console.Write("Bienvenido! Ingrese sus datos de registro en Spotflix\nUsuario: ");
            string usuario = Console.ReadLine();
            usuario1.Username = usuario;
            Console.Write("Correo: ");
            string email = Console.ReadLine();
            usuario1.Mail = email;
            Console.Write("Contraseña: ");
            string contrasena = Console.ReadLine();
            usuario1.Contraseña = contrasena;
            Console.Write("Numero de celular: ");
            string celular = Console.ReadLine();
            usuario1.Telefono = celular;
            string privacidad = "";
            int d = 1;
            /*while (d == 1)
            {
                Console.WriteLine("Deseas contratar Spotflix Premium?");
                Console.WriteLine("1 --> Si");
                Console.WriteLine("2 --> No");
                string premium = Console.ReadLine();
                if (premium == "1")
                {
                    usuario1.Member = "true";
                    d = 0;
                }
                else if (premium == "2")
                {
                    usuario1.Member = "false";
                    d = 0;
                }
                else
                {
                    Console.WriteLine("Opcion Invalida");
                }
            }*/
            usuario1.Member = "false";
            
            int a = 1;
            while ( a== 1)
            {
                Console.WriteLine("Que tipo de privacidad quieres?");
                Console.WriteLine("");
                Console.WriteLine("1 --> Usuario Privado");
                Console.WriteLine("2 --> Usuario Publico");
                int resp = Convert.ToInt32(Console.ReadLine());
                if (resp == 1)
                {
                    privacidad = "Privada";
                    usuario1.privacidad = privacidad;
                    a = 0; 
                }
                else if (resp == 2)
                {
                    privacidad = "Publica";
                    usuario1.privacidad = privacidad;
                    a = 0;
                }
                else
                {
                    a = 1;
                }
            }
            int b = 0;
            int c = 0;
            
            while (b == 0)
            {
                Console.WriteLine("Deseas agregar tus gustos?");
                Console.WriteLine("1 --> Si");
                Console.WriteLine("2 --> No");
                int respuesta = Convert.ToInt32(Console.ReadLine());

                if (respuesta == 1)
                {
                    Console.WriteLine("Te pediremos el nombre de 3 cantantes que te gusten");
                    while (c<= 2)
                    {
                        Console.WriteLine("Escribe el nombre de 1 cantante: ");
                        string cantante = Console.ReadLine();
                        cantantes_list.Add(cantante);
                        c += 1;
                    }
                    b = 1;
                }
                else if (respuesta == 2)
                {
                    
                    b = 1;
                }
                else
                {
                    b = 0;
                }
            }
            
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("MyFile.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, usuario1);
            stream.Close();

            string verificationLink = GenerateLink(usuario1.Username);
           
            string result = Data.AddUser(new List<string>()
                {usuario1.Username, usuario1.Mail, usuario1.Contraseña, usuario1.privacidad, verificationLink, Convert.ToString(DateTime.Now),  usuario1.Telefono, usuario1.Member, usuario1.followers});
            if (result == null)
            {
               
                OnRegistered(usuario1.Username, usuario1.Contraseña,  verificationlink: verificationLink, email: usuario1.Mail);
            }
            else
            {
                
                Console.WriteLine("[!] ERROR: " + result + "\n");
            }
        }

        public void CambiarNombreUsuario()
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("MyFile.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
            Usuario usuario1 = formatter.Deserialize(stream) as Usuario;
            stream.Close();
            string verificationLink = GenerateLink(usuario1.Username);
            Data.AddUser(new List<string>()
                {usuario1.Username,  usuario1.Mail, usuario1.Contraseña, usuario1.privacidad, verificationLink, Convert.ToString(DateTime.Now),  usuario1.Telefono, usuario1.Member, usuario1.followers});

            Console.WriteLine("Ingresa tu nombre de usuario: ");
            string usuario = Console.ReadLine();
            Console.WriteLine("Ingresa tu contrasena: ");
            string contrasena = Console.ReadLine();

            string result = Data.LogIn(usuario, contrasena);
            string b = "1";
            
            if (result == null)
            {
                while (b == "1")
                {
                    Console.Write("Ingrese el nuevo nombre de usuario: ");
                    string NuevoNombre = Console.ReadLine();
                    Data.ChangeUsername(usuario, NuevoNombre);

                    List<string> data = Data.GetData(NuevoNombre);
                    OnUsernameChanged( data[1], data[5]);
                    b = "2";
                    /*Usuario usuario4 = new Usuario();
                    usuario4.Username = data[0];
                    usuario4.Username = data[1];
                    usuario4.Mail = data[2];
                    usuario4.Contraseña = data[3];
                    usuario4.privacidad = data[4];
                    usuario4.Telefono = data[7];
                    usuario4.Member = data[8];
                    usuario4.followers = data[9];*/
                    usuario1.Username = NuevoNombre;
                    IFormatter formatter1 = new BinaryFormatter();
                    Stream stream1 = new FileStream("MyFile.bin", FileMode.Create, FileAccess.Write, FileShare.None);
                    formatter1.Serialize(stream1, usuario1);
                    stream1.Close();
                }
                
                
                
            }
            else
            {

                Console.WriteLine("[!] ERROR: " + result + "\n");
            }
        }

        public void CambiarContrasena()
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("MyFile.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
            Usuario usuario1 = formatter.Deserialize(stream) as Usuario;
            stream.Close();
            string verificationLink = GenerateLink(usuario1.Username);
            Data.AddUser(new List<string>()
                {usuario1.Username,  usuario1.Mail, usuario1.Contraseña, usuario1.privacidad, verificationLink, Convert.ToString(DateTime.Now),  usuario1.Telefono, usuario1.Member, usuario1.followers});
            Console.WriteLine("Ingresa tu nombre de usuario: ");
            string usuario = Console.ReadLine();
            Console.WriteLine("Ingresa tu contrasena: ");
            string contrasena = Console.ReadLine();
            string a = "1";
            string result = Data.LogIn(usuario, contrasena);

            
            
            if (result == null)
            {
                while (a == "1")
                {
                    Console.Write("Ingrese la nueva contrasena: ");
                    string NuevaContrasena1 = Console.ReadLine();
                    Console.Write("Re-Ingrese la nueva contrasena: ");
                    string NuevaContrasena2 = Console.ReadLine();
                    if (NuevaContrasena1 == NuevaContrasena2)
                    {
                        Data.ChangePassword(usuario, NuevaContrasena1);

                        List<string> data = Data.GetData(usuario);
                        OnPasswordChanged(data[0], data[1], data[5]);
                        a = "2";
                        /*Usuario usuario4 = new Usuario();
                        usuario4.Username = usuario1.Username;
                        usuario4.Mail = data[2];
                        usuario4.Contraseña = data[3];
                        usuario4.privacidad = data[4];
                        usuario4.Telefono = data[7];
                        usuario4.Member = data[8];
                        usuario4.followers = data[9];*/
                        usuario1.Contraseña = NuevaContrasena1;

                        IFormatter formatter1 = new BinaryFormatter();
                        Stream stream1 = new FileStream("MyFile.bin", FileMode.Create, FileAccess.Write, FileShare.None);
                        formatter1.Serialize(stream1, usuario1);
                        stream1.Close();

                    }
                    else
                    {
                        Console.WriteLine("Contrasenas no coinciden");
                        a = "1";
                    }


                }

            }
            else
            {
               
                Console.WriteLine("[!] ERROR: " + result + "\n");
            }
        }

        
        public string GenerateLink(string usuario)
        {
            Random rnd = new Random();
            string result = "";
            for (int ctr = 0; ctr <= 99; ctr++)
            {
                char random = (char)rnd.Next(33, 126);
                result += random;
            }
            return "http://spotflix.com/verificar-correo.php?=" + usuario + "_" + result;
        }

        
        public void OnEmailVerified(object source, EventArgs e)
        {
            Console.WriteLine("MailService: Se ha enviado un email al correo indicado para Verificar su correo");
            Thread.Sleep(2000);
        }

    }
}

