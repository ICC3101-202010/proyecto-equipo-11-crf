using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Entrega2;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;


namespace Spotflix
{
    public partial class LogIn : UserControl
    {
        public LogIn()
        {
            InitializeComponent();
            labelError.Visible = false;
        }
        
        public RegistroUsuarios Data { get; }


        public LogIn(RegistroUsuarios data)
        {
            this.Data = data;
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
        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            if (Convert.ToString(textBoxPasswordLogin.Text) == "" & Convert.ToString(textBoxUsernameLogIn.Text) == "")
            {
                labelError.Visible = true;
            }
            else
            {
                try
                {
                    RegistroUsuarios registro = new RegistroUsuarios();
                    IFormatter formatter1 = new BinaryFormatter();
                    Stream stream1 = new FileStream("MyFile.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
                    Usuario usuario1 = formatter1.Deserialize(stream1) as Usuario;
                    Global.UserNow = usuario1;
                    stream1.Close();
                    string verificationLink = GenerateLink(usuario1.Username);
                    registro.AddUser(new List<string>()
                {usuario1.Username,  usuario1.Mail, usuario1.Contraseña, usuario1.privacidad, verificationLink, Convert.ToString(DateTime.Now),  usuario1.Telefono, usuario1.Member, usuario1.followers});
                }
                catch (Exception ex)
                {
                    IFormatter formatter1 = new BinaryFormatter();
                    Stream stream1 = new FileStream("MyFile.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
                    Usuario usuario1 = formatter1.Deserialize(stream1) as Usuario;
                    stream1.Close();
                    string verificationLink = GenerateLink(usuario1.Username);
                    Data.AddUser(new List<string>()
                {usuario1.Username,  usuario1.Mail, usuario1.Contraseña, usuario1.privacidad, verificationLink, Convert.ToString(DateTime.Now),  usuario1.Telefono, usuario1.Member, usuario1.followers});
                }

                List<string> datosLogin = new List<string>();

                string usuario = Convert.ToString(textBoxUsernameLogIn.Text);
                
                string contrasena = Convert.ToString(textBoxPasswordLogin.Text);

                IFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream("Registrados.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
                Dictionary<int, List<string>> registrados = formatter.Deserialize(stream) as Dictionary<int, List<string>>;
                stream.Close();
                
                string descripcion = null;
                string result = "";
                foreach (List<string> user in registrados.Values)
                {

                    
                    if (user[0] == usuario && user[2] == contrasena)
                    {
                        result=  descripcion;
                        break;
                    }
                    else
                    {
                        result = "Usuario o contrasena incorrecta";
                    }
                }
                
                //string result = Data.LogIn(usuario, contrasena);
                //datosLogin.Add(result);
                //datosLogin.Add(usuario);
                if ( result == null)
                {
                    IFormatter formatter2 = new BinaryFormatter();
                    Stream stream2 = new FileStream("nombre.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
                    List<string> nombre = formatter2.Deserialize(stream2) as List<string>;
                    stream2.Close();
                    nombre.Add(textBoxUsernameLogIn.Text);
                    IFormatter formatter1 = new BinaryFormatter();
                    Stream stream1 = new FileStream("nombre.bin", FileMode.Create, FileAccess.Write, FileShare.None);
                    formatter1.Serialize(stream1, nombre);
                    stream1.Close();
                    Form1.MainMenu.Show();
                    Form1.ProgresBar.Show();
                    Form1.Menubar.Show();
                }
                else
                {
                    MessageBox.Show("[!] ERROR: " + result + "\n");
                }
                
                

                
            }
        }

        private void bAtrasLogIn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1.Welcome.Show();
        }

        private void textBoxUsernameLogIn_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
