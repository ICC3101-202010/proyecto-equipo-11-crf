using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entrega2;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;

namespace Spotflix
{
    [Serializable]
    public partial class Register : UserControl
    {

        public Dictionary<int, List<string>> registrados;
        public Register()
        {
            InitializeComponent();
            registrados = new Dictionary<int, List<string>>();
        }
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
        public RegistroUsuarios Data { get; }
        

        public Register(RegistroUsuarios data)
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

        private void btnSubmitRegister_Click(object sender, EventArgs e)
        {
            //RegistroUsuarios registroUsuarios = new RegistroUsuarios();
            if (tConfirmPasswordRegistration.Text == tPasswordRegistration.Text)
            {
                this.Hide();
                Usuario usuario = new Usuario();
                string nombre_usuario = textBoxUsernameRegister.Text;
                usuario.Username = nombre_usuario;
                string email = textBoxMailRegister.Text;
                usuario.Mail = email;
                string contrasena = tPasswordRegistration.Text;
                usuario.Contraseña = contrasena;
                string celular = textBoxMobileRegister.Text;
                usuario.Telefono = celular;
                if (checkBoxPrivateRegister.Checked == true)
                {
                    string privacidad = "Privada";
                    usuario.privacidad = privacidad;
                }
                if (checkBoxPublicRegister.Checked == true)
                {
                    string privacidad = "Publica";
                    usuario.privacidad = privacidad;
                }
                usuario.followers = "0";
                usuario.Member = "false";
                IFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream("MyFile.bin", FileMode.Create, FileAccess.Write, FileShare.None);
                formatter.Serialize(stream, usuario);
                stream.Close();

                string verificationLink = GenerateLink(usuario.Username);


                //MessageBox.Show("nombre:  " + usuario.Username + "\n" + usuario.Mail + "\n" + usuario.Contraseña + "\n" + usuario.privacidad + "\n" + verificationLink + "\n" + Convert.ToString(DateTime.Now) + "\n" + usuario.Telefono + "\n" + usuario.Member + "\n" + usuario.followers);
                List<string> data = new List<string>();
                data.Add(usuario.Username);
                data.Add(usuario.Mail);
                data.Add(usuario.Contraseña);
                data.Add(usuario.privacidad);
                data.Add(verificationLink);
                data.Add(Convert.ToString(DateTime.Now));
                data.Add(usuario.Telefono);
                data.Add(usuario.Member);
                data.Add(usuario.followers);
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
                    try
                    {
                        IFormatter formatter3 = new BinaryFormatter();
                        Stream stream3 = new FileStream("Registrados.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
                        Dictionary<int, List<string>> registrados = formatter3.Deserialize(stream3) as Dictionary<int, List<string>>;
                        stream3.Close();
                        registrados.Add(registrados.Count + 1, data);
                        IFormatter formatter1 = new BinaryFormatter();
                        Stream stream1 = new FileStream("Registrados.bin", FileMode.Create, FileAccess.Write, FileShare.None);
                        formatter1.Serialize(stream1, registrados);
                        stream1.Close();
                    }
                    catch (Exception)
                    {
                        registrados.Add(registrados.Count + 1, data);
                        IFormatter formatter1 = new BinaryFormatter();
                        Stream stream1 = new FileStream("Registrados.bin", FileMode.Create, FileAccess.Write, FileShare.None);
                        formatter1.Serialize(stream1, registrados);
                        stream1.Close();
                        throw;

                    }
                }
                string result = descripcion;
                //string result = Data.AddUser(new List<string>()
                //{usuario.Username, usuario.Mail, usuario.Contraseña, usuario.privacidad, verificationLink, Convert.ToString(DateTime.Now),  usuario.Telefono, usuario.Member, usuario.followers});
                if (result == null)
                {

                    OnRegistered(usuario.Username, usuario.Contraseña, verificationlink: verificationLink, email: usuario.Mail);
                    if (checkBoxYesRegister.Checked == true)
                    {
                        Form1.Preferences.BringToFront();
                        Form1.Preferences.Show();

                    }
                    if (checkBoxNoRegister.Checked == true)
                    {
                        Form1.MailVerified.BringToFront();
                        Form1.MailVerified.Show();
                    }
                    if (checkBoxNoRegister.Checked == false & checkBoxYesRegister.Checked == false)
                    {
                        Form1.Welcome.Show();
                    }
                }
                else
                {

                    MessageBox.Show("[!] ERROR: " + result + "\n");
                    Form1.Register.Show();
                    Form1.Register.BringToFront();

                }
            }
            else
            {
                MessageBox.Show("[!] ERROR: " + "Las Contraseñas deben Coincidir!" + "\n");
            }
            
            

            
            
        }

        private void bAtrasRegistration_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1.Welcome.Show();
        }
    }
}
