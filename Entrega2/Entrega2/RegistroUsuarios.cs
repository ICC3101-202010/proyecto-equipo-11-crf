using System;
using System.Collections.Generic;
using System.Text;
namespace Entrega2
{
    public class RegistroUsuarios
    {
        // Diccionario para guardar todos los registros
        // Los datos de cada registro se guardan en List<string> con formato [usuario, correo, password, linkVerificacion, fecha, numero, privacidad, gustos]
        private Dictionary<int, List<string>> registrados;

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
            }
            return descripcion;
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
    }

    
}
