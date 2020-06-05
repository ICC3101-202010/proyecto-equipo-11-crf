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
    public partial class Profile : UserControl
    {
        

        public Profile()
        {
            InitializeComponent();
            pIntroProfile.Visible = true;
            pIntroProfile.BringToFront();
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

        protected virtual void OnUsernameChanged(string email, string number)
        {
            if (UsernameChanged != null)
            {
                UsernameChanged(this, new CambiarNombreUsuarioEventArgs { Email = email, Number = number });
            }
        }

        private void bAtrasProfile_Click(object sender, EventArgs e)
        {
            Form1.Profile.Hide();
            pIntroProfile.Visible = false;
            Form1.MainMenu.Show();
            
        }

        private void bUserOptions_Click(object sender, EventArgs e)
        {
            panelOpcionesUsuario.Visible = true;
        }

        private void bEditProfile_Click(object sender, EventArgs e)
        {
            pEditarProfile.Visible = true;
        }

        private void bAtrasIntroProfile_Click(object sender, EventArgs e)
        {
            Form1.Profile.Hide();
            Form1.MainMenu.Show();
        }

        private void bVerUsuario_Click(object sender, EventArgs e)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("nombre.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
            List<string> nombre = formatter.Deserialize(stream) as List<string>;
            stream.Close();
            IFormatter formatter3 = new BinaryFormatter();
            Stream stream3 = new FileStream("Registrados.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
            Dictionary<int, List<string>> registrados = formatter3.Deserialize(stream3) as Dictionary<int, List<string>>;
            stream3.Close();

            foreach (List<string> value in registrados.Values)
            {
                if (nombre[0] == value[0])
                {
                    labelFollowing.Text = "Following:    "+ value[10];
                    labelPlaylist.Text = "Playlists:    0";
                    labelFollowers.Text = "Followers:    "+ value[8];
                }
            }
            tNombreProfile.Text = nombre[0];
            
            pIntroProfile.Visible = false;
        }

        private void buttonAtrasEditarProfile_Click(object sender, EventArgs e)
        {
            pEditarProfile.Visible = false;
            pIntroProfile.Visible = true;
        }

        private void bEditarProfile_Click(object sender, EventArgs e)
        {

            

            if (comboBoxEditarProfile.Text == "Cambiar Nombre de Usuario")
            {
                
                checkBoxPublica.Visible = false;
                checkBoxPrivada.Visible = false;
                panelEditarNombre.Visible = true;
                textBoxIngresarNuevo.Visible = true;
                LabelIngresarNuevo.Visible = true;
                
            }
            if (comboBoxEditarProfile.Text == "Cambiar Contraseña")
            {
                checkBoxPublica.Visible = false;
                checkBoxPrivada.Visible = false;
                panelEditarNombre.Visible = true;
                textBoxIngresarNuevo.Visible = true;
                LabelIngresarNuevo.Visible = true;
                LabelIngresarNuevo.Text = "Ingresa la Nueva Contraseña";
                textBoxIngresarNuevo.Text = "";
                
            }
            if (comboBoxEditarProfile.Text == "Cambiar Privacidad")
            {
                IFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream("nombre.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
                List<string> nombre = formatter.Deserialize(stream) as List<string>;
                stream.Close();
                IFormatter formatter3 = new BinaryFormatter();
                Stream stream3 = new FileStream("Registrados.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
                Dictionary<int, List<string>> registrados = formatter3.Deserialize(stream3) as Dictionary<int, List<string>>;
                stream3.Close();
                checkBoxPrivada.Checked = false;
                checkBoxPublica.Checked = false;
                panelEditarNombre.Visible = true;
                textBoxIngresarNuevo.Visible = false;
                checkBoxPrivada.Visible = true;
                checkBoxPublica.Visible = true;
                foreach (List<string> value in registrados.Values)
                {
                    if (nombre[0] == value[0])
                    {
                        LabelIngresarNuevo.Text = "Tu cuenta es:   " + value[3] + "\n"+ "\n" + "Elige La Nueva Privacidad";
                    }
                }        
            }
        }

        private void bCambiarEditar_Click(object sender, EventArgs e)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("nombre.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
            List<string> nombre = formatter.Deserialize(stream) as List<string>;
            stream.Close();
            IFormatter formatter3 = new BinaryFormatter();
            Stream stream3 = new FileStream("Registrados.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
            Dictionary<int, List<string>> registrados = formatter3.Deserialize(stream3) as Dictionary<int, List<string>>;
            stream3.Close();
            if (comboBoxEditarProfile.Text == "Cambiar Nombre de Usuario")
            {
                string nuevo_nombre = textBoxIngresarNuevo.Text;
                int a = 1;
                foreach (List<string> value in registrados.Values)
                {
                    if (nombre[0] == value[0])
                    {
                        foreach (List<string> valor in registrados.Values)
                        {
                            if (nuevo_nombre == valor[0])
                            {
                                a = 2;
                                MessageBox.Show("El Nombre de Usuario ya Existe!");
                                break;
                            }
                            else
                            {
                                a = 3;
                                
                            }
                        }
                        if (a == 3)
                        {
                            value[0] = nuevo_nombre;
                            OnUsernameChanged(value[1], value[5]);
                            IFormatter formatter1 = new BinaryFormatter();
                            Stream stream1 = new FileStream("Registrados.bin", FileMode.Create, FileAccess.Write, FileShare.None);
                            formatter1.Serialize(stream1, registrados);
                            stream1.Close();
                            MessageBox.Show("Cambiaste el Nombre de Usuario con Exito!");
                            
                            pEditarProfile.Visible = true;
                            panelEditarNombre.Visible = false;
                        }
                    }
                }
            }
            if (comboBoxEditarProfile.Text == "Cambiar Contraseña")
            {
                string nueva_contrasena = textBoxIngresarNuevo.Text;
                foreach (List<string> value in registrados.Values)
                {
                    if (nombre[0] == value[0])
                    {
                        value[2] = nueva_contrasena;
                        OnPasswordChanged(value[0], value[1], value[5]);
                        IFormatter formatter1 = new BinaryFormatter();
                        Stream stream1 = new FileStream("Registrados.bin", FileMode.Create, FileAccess.Write, FileShare.None);
                        formatter1.Serialize(stream1, registrados);
                        stream1.Close();
                        MessageBox.Show("Cambiaste la Contraseña con Exito!");
                        pEditarProfile.Visible = true;
                        panelEditarNombre.Visible = false;
                    }
                }
            }
            if (comboBoxEditarProfile.Text == "Cambiar Privacidad")
            {
                foreach (List<string> value in registrados.Values)
                {
                    if (nombre[0] == value[0])
                    {
                        

                        if (checkBoxPrivada.Checked == true)
                        {
                            value[3] = "Privada";
                            IFormatter formatter1 = new BinaryFormatter();
                            Stream stream1 = new FileStream("Registrados.bin", FileMode.Create, FileAccess.Write, FileShare.None);
                            formatter1.Serialize(stream1, registrados);
                            stream1.Close();
                            MessageBox.Show("Cambiaste la Privacidad con Exito!");
                            pEditarProfile.Visible = true;
                            panelEditarNombre.Visible = false;

                        }
                        if (checkBoxPublica.Checked == true)
                        {
                            value[3] = "Publica";
                            IFormatter formatter1 = new BinaryFormatter();
                            Stream stream1 = new FileStream("Registrados.bin", FileMode.Create, FileAccess.Write, FileShare.None);
                            formatter1.Serialize(stream1, registrados);
                            stream1.Close();
                            MessageBox.Show("Cambiaste la Privacidad con Exito!");
                            pEditarProfile.Visible = true;
                            panelEditarNombre.Visible = false;
                        }
                    }
                }

            }
            comboBoxEditarProfile.Text = "";
        }

        private void bAtrasOpciones_Click(object sender, EventArgs e)
        {
            panelOpcionesUsuario.Visible = false;
        }

        private void buttonSeleccionarOpcionUsuario_Click(object sender, EventArgs e)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("nombre.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
            List<string> nombre = formatter.Deserialize(stream) as List<string>;
            stream.Close();
            IFormatter formatter3 = new BinaryFormatter();
            Stream stream3 = new FileStream("Registrados.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
            Dictionary<int, List<string>> registrados = formatter3.Deserialize(stream3) as Dictionary<int, List<string>>;
            stream3.Close();
            if (comboBoxOpcionesUsuario.Text == "Cambiar Membresia")
            {
                panelCambiarOpcionesUsuario.Visible = true;
                labelCambio.Visible = true;
                checkBoxNo.Visible = true;
                checkBoxSi.Visible = true;
                checkBoxNo.Checked = false;
                checkBoxSi.Checked = false;
                labelPremium.Visible = true;
                foreach (List<string> value in registrados.Values)
                {
                    if (nombre[0] == value[0])
                    {
                        if (value[7] == "false")
                        {
                            labelPremium.Text = "Aun No eres Un Usuario Premium! Contrata Spotflix Premium para disfrutar de la Mejor Musica y Videos!";
                            
                        }
                        if (value[7] == "true")
                        {
                            labelPremium.Text = "You´re a Premium User!";
                        }
                        
                    }
                }
                labelCambio.Text = "Which Membership do you want?";
                checkBoxSi.Text = "Premium";
                checkBoxNo.Text = "Free";
                
            }
            if (comboBoxOpcionesUsuario.Text == "Agregar Cancion")
            {
                foreach (List<string> value in registrados.Values)
                {
                    if (nombre[0] == value[0])
                    {
                        if (value[9] == "False")
                        {
                            labelPremium.Text = "You´re not an Admin Yet! Update to Admin to be able to Add Songs!";
                            labelPremium.Visible = true;
                            panelCambiarOpcionesUsuario.Visible = true;
                        }
                        if (value[9] == "True")
                        {
                            labelPremium.Text = "You´re an Admin!";
                            labelPremium.Visible = true;
                            panelCambiarOpcionesUsuario.Visible = true;
                            labelPath.Visible = true;
                            textBoxPath.Visible = true;
                        }

                    }
                }
                
            }
            if (comboBoxOpcionesUsuario.Text == "Agregar Video")
            {
                foreach (List<string> value in registrados.Values)
                {
                    if (nombre[0] == value[0])
                    {
                        if (value[9] == "False")
                        {
                            labelPremium.Text = "You´re not an Admin Yet! Update to Admin to be able to Add Videos!";
                            labelPremium.Visible = true;
                            panelCambiarOpcionesUsuario.Visible = true;
                        }
                        if (value[9] == "True")
                        {
                            labelPremium.Text = "You´re an Admin!";
                            labelPremium.Visible = true;
                            panelCambiarOpcionesUsuario.Visible = true;
                            labelPath.Visible = true;
                            textBoxPath.Visible = true;
                        }

                    }
                }
                
            }
            if (comboBoxOpcionesUsuario.Text == "Cambiar Atributo Administrador")
            {
                panelCambiarOpcionesUsuario.Visible = true;
                labelCambio.Visible = true;
                checkBoxNo.Visible = true;
                checkBoxSi.Visible = true;
                labelPremium.Visible = true;
                checkBoxNo.Checked = false;
                checkBoxSi.Checked = false;
                foreach (List<string> value in registrados.Values)
                {
                    if (nombre[0] == value[0])
                    {
                        if (value[9] == "False")
                        {
                            labelPremium.Text = "You´re not an Admin Yet! Update to Admin to be able to Add Songs and Videos!";

                        }
                        if (value[9] == "True")
                        {
                            labelPremium.Text = "You´re an Admin!";
                        }

                    }
                }
                labelCambio.Text = "Would you like to be Admin?";
                checkBoxSi.Text = "Yes";
                checkBoxNo.Text = "No";
            }
        }

        private void bAtrasCambiarOpciones_Click(object sender, EventArgs e)
        {
            panelCambiarOpcionesUsuario.Visible = false;
            labelCambio.Visible = false;
            checkBoxNo.Visible = false;
            checkBoxSi.Visible = false;
            labelPremium.Visible = false;
            labelPath.Visible = false;
            textBoxPath.Visible = false;
        }

        private void buttonUpdateOpciones_Click(object sender, EventArgs e)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("nombre.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
            List<string> nombre = formatter.Deserialize(stream) as List<string>;
            stream.Close();
            IFormatter formatter3 = new BinaryFormatter();
            Stream stream3 = new FileStream("Registrados.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
            Dictionary<int, List<string>> registrados = formatter3.Deserialize(stream3) as Dictionary<int, List<string>>;
            stream3.Close();
            if (comboBoxOpcionesUsuario.Text == "Cambiar Membresia")
            {
                foreach (List<string> value in registrados.Values)
                {
                    if (nombre[0] == value[0])
                    {
                        if (checkBoxSi.Checked == true)
                        {
                            value[7] = "true";
                            MessageBox.Show("Congrats! You´ve Upgraded to Spotflix Premium!");
                            IFormatter formatter1 = new BinaryFormatter();
                            Stream stream1 = new FileStream("Registrados.bin", FileMode.Create, FileAccess.Write, FileShare.None);
                            formatter1.Serialize(stream1, registrados);
                            stream1.Close();
                            panelCambiarOpcionesUsuario.Visible = false;
                            labelCambio.Visible = false;
                            checkBoxNo.Visible = false;
                            checkBoxSi.Visible = false;
                            labelPremium.Visible = false;
                        }
                        if (checkBoxNo.Checked == true)
                        {
                            value[7] = "false";
                            MessageBox.Show("We´re sad to see you go... Upgrade to Premium to Enjoy the best App!");
                            IFormatter formatter1 = new BinaryFormatter();
                            Stream stream1 = new FileStream("Registrados.bin", FileMode.Create, FileAccess.Write, FileShare.None);
                            formatter1.Serialize(stream1, registrados);
                            stream1.Close();
                            panelCambiarOpcionesUsuario.Visible = false;
                            labelCambio.Visible = false;
                            checkBoxNo.Visible = false;
                            checkBoxSi.Visible = false;
                            labelPremium.Visible = false;
                        }

                    }
                }
                
            }
            if (comboBoxOpcionesUsuario.Text == "Agregar Cancion")
            {
                string path = textBoxPath.Text;
                MessageBox.Show("You´ve Successfully Added a Song!");
                labelPath.Visible = false;
                textBoxPath.Text = "";
                textBoxPath.Visible = false;
                panelCambiarOpcionesUsuario.Visible = false;
                labelPremium.Visible = false;

            }
            if (comboBoxOpcionesUsuario.Text == "Agregar Video")
            {
                string path = textBoxPath.Text;
                MessageBox.Show("You´ve Successfully Added a Video!");
                textBoxPath.Text = "";
                labelPath.Visible = false;
                textBoxPath.Visible = false;
                panelCambiarOpcionesUsuario.Visible = false;
                labelPremium.Visible = false;
            }
            if (comboBoxOpcionesUsuario.Text == "Cambiar Atributo Administrador")
            {
                foreach (List<string> value in registrados.Values)
                {
                    if (nombre[0] == value[0])
                    {
                        if (checkBoxSi.Checked == true)
                        {
                            value[9] = "True";
                            MessageBox.Show("Congrats! You´ve Upgraded to Admin! You can Now Add Songs and Videos to the App!");
                            IFormatter formatter1 = new BinaryFormatter();
                            Stream stream1 = new FileStream("Registrados.bin", FileMode.Create, FileAccess.Write, FileShare.None);
                            formatter1.Serialize(stream1, registrados);
                            stream1.Close();
                            panelCambiarOpcionesUsuario.Visible = false;
                            labelCambio.Visible = false;
                            checkBoxNo.Visible = false;
                            checkBoxSi.Visible = false;
                            labelPremium.Visible = false;
                        }
                        if (checkBoxNo.Checked == true)
                        {
                            value[9] = "False";
                            MessageBox.Show("You´re Not an Admin Anymore!");
                            IFormatter formatter1 = new BinaryFormatter();
                            Stream stream1 = new FileStream("Registrados.bin", FileMode.Create, FileAccess.Write, FileShare.None);
                            formatter1.Serialize(stream1, registrados);
                            stream1.Close();
                            panelCambiarOpcionesUsuario.Visible = false;
                            labelCambio.Visible = false;
                            checkBoxNo.Visible = false;
                            checkBoxSi.Visible = false;
                            labelPremium.Visible = false;
                        }

                    }
                }
            }
            comboBoxOpcionesUsuario.Text = "";
        }
    }
}
