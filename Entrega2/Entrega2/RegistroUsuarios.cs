using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
namespace Entrega2
{
    [Serializable]
    public class RegistroUsuarios
    {
        // Diccionario para guardar todos los registros
        // Los datos de cada registro se guardan en List<string> con formato [usuario, correo, password, linkVerificacion, fecha, numero, privacidad, gustos]
        public Dictionary<int, List<string>> registrados;
        public Dictionary<Cancion, List<Double>> retomar;
        public List<string> paths;
        public Dictionary<int, List<Cancion>> Listas;

        public RegistroUsuarios()
        {
            registrados = new Dictionary<int, List<string>>();
        }

        public void ChangePassword(string usuario, string nueva_contrasena)
        {
            foreach (List<string> user in this.registrados.Values)
            {
                if (user[0] == usuario)
                {
                    user[2] = nueva_contrasena;
                }
            }
        }
        public void ChangeUsername(string usuario, string nuevo_usuario)
        {
            foreach (List<string> user in this.registrados.Values)
            {
                if (user[0] == usuario)
                {
                    user[0] = nuevo_usuario;
                }
            }
        }
        public void RegistrarMembresia(Membresia_Usuario usuario)
        {
            foreach (List<string> value in this.registrados.Values)
            {
                if (value[0]== usuario.username)
                {
                    value[8] = usuario.member;
                }
            }
        }
        public void UpdateMembership(List<string> data)
        {
            if (data[7]== "false")
            {
                int a = 0;
                foreach (List<string> value in this.registrados.Values)
                {
                    if (data[0] == value[0])
                    {
                        registrados[a][7] = "true";
                    }
                    else
                    {
                        a += 1;
                    }
                }
            }
            else if (data[7]== "true")
            {
                int a = 0;
                foreach (List<string> value in this.registrados.Values)
                {
                    if (data[0] == value[0])
                    {
                        registrados[a][8] = "false";
                    }
                    else
                    {
                        a += 1;
                    }
                }
            }
            
        }

        public string AddUser(List<string> data)
        {
            string descripcion = null;
            foreach (List<string> value in this.registrados.Values)
            {
                if (data[0] == value[0])
                {
                    descripcion = "El nombre de usuario especificado ya existe";
                }
                else if (data[1] == value[1])
                {
                    descripcion = "El correo ingresado ya existe";
                }
            }
            if (descripcion == null)
            {
                this.registrados.Add(registrados.Count + 1, data);
                /*IFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream("MyFile.bin", FileMode.Create, FileAccess.Write, FileShare.None);
                formatter.Serialize(stream, data);
                stream.Close();*/
            }
            return descripcion;
        }

        public void RetomarCancion(Cancion cancion, string path, List<Double> tiempo)
        {
            this.retomar.Add(cancion, tiempo);
            this.paths.Add(path);
        }

        public void RetomarLista(List<Cancion> songs)
        {
            this.Listas.Add(Listas.Count + 1, songs);
        }
        public List<string> GetData(string usuario)
        {
            foreach (List<string> user in this.registrados.Values)
            {
                if (user[0] == usuario)
                {
                    return user;
                }
            }

            return new List<string>();
        }

        
        public string LogIn(string username, string contrasena)
        {
            string descripcion = null;
            foreach (List<string> user in this.registrados.Values)
            {
                if (user[0] == username && user[2] == contrasena)
                {
                    return descripcion;
                }
            }
            return "Usuario o contrasena incorrecta";
        }
        public string RetornarMembresia(string username)
        {
            foreach (List<string> user in this.registrados.Values)
            {
                if (user[0] == username)
                {
                    return user[7];
                    
                }
                else
                {
                    return "false";
                }
                
            }
            return "";
        }
    }

    
}
