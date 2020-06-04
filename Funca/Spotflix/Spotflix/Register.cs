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
    public partial class Register : UserControl
    {

        
        public Register()
        {
            InitializeComponent();
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
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("MyFile.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, usuario);
            stream.Close();

            string verificationLink = GenerateLink(usuario.Username);
            string result = Data.AddUser(new List<string>()
                {usuario.Username, usuario.Mail, usuario.Contraseña, usuario.privacidad, verificationLink, Convert.ToString(DateTime.Now),  usuario.Telefono, usuario.Member, usuario.followers});
            if (result == null)
            {

                OnRegistered(usuario.Username, usuario.Contraseña, verificationlink: verificationLink, email: usuario.Mail);
            }
            else
            {

                MessageBox.Show("[!] ERROR: " + result + "\n");
            }
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

        private void bAtrasRegistration_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1.Welcome.Show();
        }
    }
}
