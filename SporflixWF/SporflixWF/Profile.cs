﻿using System;
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

        public void buttonProfile_Click_1(object sender, EventArgs e)
        {
            //MessageBox.Show("entre");
            pIntroProfile.Visible = true;
            pIntroProfile.BringToFront();
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("nombre.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
            List<string> nombre = formatter.Deserialize(stream) as List<string>;
            stream.Close();
            IFormatter formatter3 = new BinaryFormatter();
            Stream stream3 = new FileStream("Registrados.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
            List < Usuario > registrados = formatter3.Deserialize(stream3) as List<Usuario>;
            stream3.Close();

            foreach (Usuario value in registrados)
            {
                if (nombre[0] == value.Username)
                {
                    labelFollowing.Text = "Following:    " + value.following;
                    labelPlaylist.Text = "Playlists:    "+ Global.UserNow.My_Playlist.Count();
                    labelFollowers.Text = "Followers:    " + value.followers;
                }
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
        private void recargarProfile(object sender, EventArgs e)
        {

        }
        private void bAtrasProfile_Click(object sender, EventArgs e)
        {
            Form1.Profile.Hide();
            pIntroProfile.Visible = false;
            Form1.MainMenu.Show();
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("nombre.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
            List<string> nombre = formatter.Deserialize(stream) as List<string>;
            stream.Close();
            IFormatter formatter3 = new BinaryFormatter();
            Stream stream3 = new FileStream("Registrados.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
            List < Usuario > registrados = formatter3.Deserialize(stream3) as List<Usuario>;
            stream3.Close();

            foreach (Usuario value in registrados)
            {
                if (nombre[0] == value.Username)
                {
                    labelFollowing.Text = "Following:    " + value.following;
                    labelPlaylist.Text = "Playlists:    "+ Global.UserNow.My_Playlist.Count();
                    labelFollowers.Text = "Followers:    " + value.followers;
                }
            }

        }

        private void bUserOptions_Click(object sender, EventArgs e)
        {
            panelOpcionesUsuario.Visible = true;
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("nombre.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
            List<string> nombre = formatter.Deserialize(stream) as List<string>;
            stream.Close();
            IFormatter formatter3 = new BinaryFormatter();
            Stream stream3 = new FileStream("Registrados.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
            List < Usuario > registrados = formatter3.Deserialize(stream3) as List<Usuario>;
            stream3.Close();

            foreach (Usuario value in registrados)
            {
                if (nombre[0] == value.Username)
                {
                    labelFollowing.Text = "Following:    " + value.following;
                    labelPlaylist.Text = "Playlists:    "+ Global.UserNow.My_Playlist.Count();
                    labelFollowers.Text = "Followers:    " + value.followers;
                }
            }
        }

        private void bEditProfile_Click(object sender, EventArgs e)
        {
            pEditarProfile.Visible = true;
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("nombre.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
            List<string> nombre = formatter.Deserialize(stream) as List<string>;
            stream.Close();
            IFormatter formatter3 = new BinaryFormatter();
            Stream stream3 = new FileStream("Registrados.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
            List < Usuario > registrados = formatter3.Deserialize(stream3) as List<Usuario>;
            stream3.Close();

            foreach (Usuario value in registrados)
            {
                if (nombre[0] == value.Username)
                {
                    labelFollowing.Text = "Following:    " + value.following;
                    labelPlaylist.Text = "Playlists:    "+ Global.UserNow.My_Playlist.Count();
                    labelFollowers.Text = "Followers:    " + value.followers;
                }
            }
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
            List < Usuario > registrados = formatter3.Deserialize(stream3) as List<Usuario>;
            stream3.Close();
            
            foreach (Usuario value in registrados)
            {
                if (nombre[0] == value.Username)
                {
                    try
                    {
                        panelImagenPerfil.BackgroundImage = System.Drawing.Image.FromFile(value.FotoPerfil);
                        labelFollowing.Text = "Following:    " + value.following;
                        labelPlaylist.Text = "Playlists:    " + Global.UserNow.My_Playlist.Count();
                        labelFollowers.Text = "Followers:    " + value.followers;
                    }
                    catch (Exception)
                    {

                        labelFollowing.Text = "Following:    " + value.following;
                        labelPlaylist.Text = "Playlists:    " + Global.UserNow.My_Playlist.Count();
                        labelFollowers.Text = "Followers:    " + value.followers;
                    }
                    
                }
            }
            tNombreProfile.Text = nombre[0];
            
            pIntroProfile.Visible = false;
        }

        private void buttonAtrasEditarProfile_Click(object sender, EventArgs e)
        {
            pEditarProfile.Visible = false;
            
        }

        private void bEditarProfile_Click(object sender, EventArgs e)
        {

            

            if (comboBoxEditarProfile.Text == "Change Username")
            {
                
                checkBoxPublica.Visible = false;
                checkBoxPrivada.Visible = false;
                panelEditarNombre.Visible = true;
                LabelIngresarNuevo.Text = "Enter the new Username";
                textBoxIngresarNuevo.Visible = true;
                LabelIngresarNuevo.Visible = true;
                textBoxIngresarNuevo.Text = "";
            }
            if (comboBoxEditarProfile.Text == "Change Password")
            {
                checkBoxPublica.Visible = false;
                checkBoxPrivada.Visible = false;
                panelEditarNombre.Visible = true;
                textBoxIngresarNuevo.Visible = true;
                LabelIngresarNuevo.Visible = true;
                LabelIngresarNuevo.Text = "Enter the new Password";
                textBoxIngresarNuevo.Text = "";
                
            }
            if (comboBoxEditarProfile.Text == "Change Privacy")
            {
                IFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream("nombre.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
                List<string> nombre = formatter.Deserialize(stream) as List<string>;
                stream.Close();
                IFormatter formatter3 = new BinaryFormatter();
                Stream stream3 = new FileStream("Registrados.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
                List < Usuario > registrados = formatter3.Deserialize(stream3) as List<Usuario>;
                stream3.Close();
                checkBoxPrivada.Checked = false;
                checkBoxPublica.Checked = false;
                panelEditarNombre.Visible = true;
                textBoxIngresarNuevo.Visible = false;
                checkBoxPrivada.Visible = true;
                checkBoxPublica.Visible = true;
                foreach (Usuario value in registrados)
                {
                    if (nombre[0] == value.Username)
                    {
                        LabelIngresarNuevo.Visible = true;
                        LabelIngresarNuevo.Text = "Your Account is:   " + value.privacidad + "\n"+ "\n" + "Select the new Privacy";
                    }
                }        
            }
            if (comboBoxEditarProfile.Text == "Change Profile Picture")
            {
                IFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream("nombre.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
                List<string> nombre = formatter.Deserialize(stream) as List<string>;
                stream.Close();
                IFormatter formatter3 = new BinaryFormatter();
                Stream stream3 = new FileStream("Registrados.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
                List<Usuario> registrados = formatter3.Deserialize(stream3) as List<Usuario>;
                stream3.Close();
                if (openFoto.ShowDialog() == DialogResult.OK)
                {

                    // codigo para abrir y leer el archivo
                    var pathFoto = openFoto.FileName;
                    panelImagenPerfil.BackgroundImage = System.Drawing.Image.FromFile(pathFoto);
                    foreach (Usuario value in registrados)
                    {
                        if (nombre[0] == value.Username)
                        {
                            value.FotoPerfil = pathFoto;
                            IFormatter formatter1 = new BinaryFormatter();
                            Stream stream1 = new FileStream("Registrados.bin", FileMode.Create, FileAccess.Write, FileShare.None);
                            formatter1.Serialize(stream1, registrados);
                            stream1.Close();
                            MessageBox.Show("You´ve Succesfully Changed Your Profile Picture!");
                        }
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
            List < Usuario > registrados = formatter3.Deserialize(stream3) as List<Usuario>;
            stream3.Close();
            if (comboBoxEditarProfile.Text == "Change Username")
            {
                string nuevo_nombre = textBoxIngresarNuevo.Text;
                int a = 1;
                foreach (Usuario value in registrados)
                {
                    if (nombre[0] == value.Username)
                    {
                        foreach (Usuario valor in registrados)
                        {
                            if (nuevo_nombre == valor.Username)
                            {
                                a = 2;
                                MessageBox.Show("The Username already exists!");
                                break;
                            }
                            else
                            {
                                a = 3;
                                
                            }
                        }
                        if (a == 3)
                        {
                            value.Username = nuevo_nombre;
                            OnUsernameChanged(value.Mail, value.Telefono);
                            IFormatter formatter1 = new BinaryFormatter();
                            Stream stream1 = new FileStream("Registrados.bin", FileMode.Create, FileAccess.Write, FileShare.None);
                            formatter1.Serialize(stream1, registrados);
                            stream1.Close();
                            MessageBox.Show("You´ve successfully changed your Username!");
                            textBoxIngresarNuevo.Text = "";
                            pEditarProfile.Visible = true;
                            panelEditarNombre.Visible = false;
                            comboBoxEditarProfile.Text = "";
                        }
                    }
                }
            }
            if (comboBoxEditarProfile.Text == "Change Password")
            {
                string nueva_contrasena = textBoxIngresarNuevo.Text;
                foreach (Usuario value in registrados)
                {
                    if (nombre[0] == value.Username)
                    {
                        value.Contraseña = nueva_contrasena;
                        OnPasswordChanged(value.Username, value.Mail, value.Telefono);
                        IFormatter formatter1 = new BinaryFormatter();
                        Stream stream1 = new FileStream("Registrados.bin", FileMode.Create, FileAccess.Write, FileShare.None);
                        formatter1.Serialize(stream1, registrados);
                        stream1.Close();
                        MessageBox.Show("You´ve Successfully changed your Password!");
                        textBoxIngresarNuevo.Text = "";
                        pEditarProfile.Visible = true;
                        panelEditarNombre.Visible = false;
                    }
                }
            }
            if (comboBoxEditarProfile.Text == "Change Privacy")
            {
                foreach (Usuario value in registrados)
                {
                    if (nombre[0] == value.Username)
                    {
                        

                        if (checkBoxPrivada.Checked == true)
                        {
                            value.privacidad = "Privada";
                            IFormatter formatter1 = new BinaryFormatter();
                            Stream stream1 = new FileStream("Registrados.bin", FileMode.Create, FileAccess.Write, FileShare.None);
                            formatter1.Serialize(stream1, registrados);
                            stream1.Close();
                            MessageBox.Show("You´ve Successfully Changed your Privacy!");
                            pEditarProfile.Visible = true;
                            panelEditarNombre.Visible = false;

                        }
                        if (checkBoxPublica.Checked == true)
                        {
                            value.privacidad = "Publica";
                            IFormatter formatter1 = new BinaryFormatter();
                            Stream stream1 = new FileStream("Registrados.bin", FileMode.Create, FileAccess.Write, FileShare.None);
                            formatter1.Serialize(stream1, registrados);
                            stream1.Close();
                            MessageBox.Show("You´ve Successfully Changed your Privacy!");
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
            buttonUpdateOpciones.Visible = true;
        }

        private void buttonSeleccionarOpcionUsuario_Click(object sender, EventArgs e)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("nombre.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
            List<string> nombre = formatter.Deserialize(stream) as List<string>;
            stream.Close();
            IFormatter formatter3 = new BinaryFormatter();
            Stream stream3 = new FileStream("Registrados.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
            List < Usuario > registrados = formatter3.Deserialize(stream3) as List<Usuario>;
            stream3.Close();
            if (comboBoxOpcionesUsuario.Text == "Log Out")
            {
                Form1.Profile.Hide();
                Form1.MainMenu.Hide();
                Form1.Register.Hide();
                Form1.Login.Hide();
                Form1.Preferences.Hide();
                Form1.MailVerified.Hide();
                Form1.Finderr.Hide();
                Form1.Librarymenu.Hide();
                Form1.Mixer.Hide();
                Form1.Welcome.Show();
                Form1.Welcome.BringToFront();
            }
            if (comboBoxOpcionesUsuario.Text == "Change Membership")
            {
                buttonUpdateOpciones.Visible = true;
                textBoxNombreCancion.Visible = false;
                labelInsertTitle.Visible = false;
                panelCambiarOpcionesUsuario.Visible = true;
                labelCambio.Visible = true;
                checkBoxNo.Visible = true;
                checkBoxSi.Visible = true;
                checkBoxNo.Checked = false;
                checkBoxSi.Checked = false;
                labelPremium.Visible = true;
                foreach (Usuario value in registrados)
                {
                    if (nombre[0] == value.Username)
                    {
                        if (value.Member == "false")
                        {
                            labelPremium.Text = "You´re not a Premium User Yet! Purchase Spotflix Premium to Enjoy the best Music & Videos!";
                            
                        }
                        if (value.Member == "true")
                        {
                            labelPremium.Text = "You´re a Premium User!";
                        }
                        
                    }
                }
                labelCambio.Text = "Which Membership do you want?";
                checkBoxSi.Text = "Premium";
                checkBoxNo.Text = "Free";
                
            }
            if (comboBoxOpcionesUsuario.Text == "Add Song")
            {
                foreach (Usuario value in registrados)
                {
                    if (nombre[0] == value.Username)
                    {
                        if (value.Administrador == "False")
                        {
                            labelPremium.Text = "You´re not an Admin Yet! Update to Admin to be able to Add Songs!";
                            labelPremium.Visible = true;
                            labelInsertTitle.Visible = false;
                            panelCambiarOpcionesUsuario.Visible = true;
                            buttonUpdateOpciones.Visible = false;
                        }
                        if (value.Administrador == "True")
                        {
                            labelPremium.Text = "You´re an Admin!";
                            labelPremium.Visible = true;
                            panelCambiarOpcionesUsuario.Visible = true;
                            labelPath.Visible = true;
                            textBoxPath.Visible = true;
                            labelInsertTitle.Visible = true;
                            labelInsertTitle.Text = "Insert the Title of the Song";
                            textBoxNombreCancion.Visible = true;
                            if (openMusic.ShowDialog() == DialogResult.OK)
                            {
                                var pathSong = openMusic.FileName;
                                textBoxPath.Text = pathSong;
                            }
                        }

                    }
                }
                
            }
            if (comboBoxOpcionesUsuario.Text == "Add Video")
            {
                foreach (Usuario value in registrados)
                {
                    if (nombre[0] == value.Username)
                    {
                        if (value.Administrador == "False")
                        {
                            labelPremium.Text = "You´re not an Admin Yet! Update to Admin to be able to Add Videos!";
                            labelPremium.Visible = true;
                            labelInsertTitle.Visible = false;
                            panelCambiarOpcionesUsuario.Visible = true;
                            buttonUpdateOpciones.Visible = false;
                        }
                        if (value.Administrador == "True")
                        {
                            labelPremium.Text = "You´re an Admin!";
                            labelPremium.Visible = true;
                            panelCambiarOpcionesUsuario.Visible = true;
                            labelPath.Visible = true;
                            textBoxPath.Visible = true;
                            labelInsertTitle.Visible = true;
                            labelInsertTitle.Text = "Insert the Title of the Video";
                            textBoxNombreCancion.Visible = true;
                            if (openVideo.ShowDialog() == DialogResult.OK)
                            {
                                var pathVideo = openVideo.FileName;
                                textBoxPath.Text = pathVideo;
                            }
                        }

                    }
                }
                
            }
            if (comboBoxOpcionesUsuario.Text == "Change Admin Attribute")
            {
                buttonUpdateOpciones.Visible = true;
                textBoxNombreCancion.Visible = false;
                labelInsertTitle.Visible = false;
                panelCambiarOpcionesUsuario.Visible = true;
                labelCambio.Visible = true;
                checkBoxNo.Visible = true;
                checkBoxSi.Visible = true;
                labelPremium.Visible = true;
                checkBoxNo.Checked = false;
                checkBoxSi.Checked = false;
                foreach (Usuario value in registrados)
                {
                    if (nombre[0] == value.Username)
                    {
                        if (value.Administrador == "False")
                        {
                            labelInsertTitle.Visible = false;
                            labelPremium.Text = "You´re not an Admin Yet! Update to Admin to be able to Add Songs and Videos!";

                        }
                        if (value.Administrador == "True")
                        {
                            labelInsertTitle.Visible = false;
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
            comboBoxOpcionesUsuario.Text = "";
        }

        private void buttonUpdateOpciones_Click(object sender, EventArgs e)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("nombre.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
            List<string> nombre = formatter.Deserialize(stream) as List<string>;
            stream.Close();
            IFormatter formatter3 = new BinaryFormatter();
            Stream stream3 = new FileStream("Registrados.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
            List < Usuario > registrados = formatter3.Deserialize(stream3) as List<Usuario>;
            stream3.Close();
            if (comboBoxOpcionesUsuario.Text == "Change Membership")
            {
                foreach (Usuario value in registrados)
                {
                    if (nombre[0] == value.Username)
                    {
                        if (checkBoxSi.Checked == true)
                        {
                            value.Member = "true";
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
                            value.Member = "false";
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

            if (comboBoxOpcionesUsuario.Text == "Add Song")
            {
                
                foreach (Usuario value in registrados)
                {
                    if (nombre[0] == value.Username)
                    {
                        if (value.Administrador == "False")
                        {
                            
                            /*textBoxNombreCancion.Visible = false;
                            labelInsertTitle.Visible = false;
                            panelCambiarOpcionesUsuario.Visible = true;
                            labelCambio.Visible = true;
                            checkBoxNo.Visible = true;
                            checkBoxSi.Visible = true;
                            labelPremium.Visible = true;
                            checkBoxNo.Checked = false;
                            checkBoxSi.Checked = false;
                            foreach (Usuario data in registrados)
                            {
                                if (nombre[0] == data.Username)
                                {
                                    if (data.Administrador == "False")
                                    {
                                        labelInsertTitle.Visible = false;
                                        labelPremium.Text = "You´re not an Admin Yet! Update to Admin to be able to Add Songs and Videos!";
                                        comboBoxOpcionesUsuario.Text = "Change Admin Attribute";
                                    }
                                    if (data.Administrador == "True")
                                    {
                                        labelInsertTitle.Visible = false;
                                        labelPremium.Text = "You´re an Admin!";
                                    }

                                }
                            }
                            labelCambio.Text = "Would you like to be Admin?";
                            checkBoxSi.Text = "Yes";
                            checkBoxNo.Text = "No";*/

                        }
                        
                        if (value.Administrador == "True")
                        {
                            string path = textBoxPath.Text;
                            string titulo_Cancion = textBoxNombreCancion.Text;
                            string sourcePath = path;
                            string targetPath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "../../../../Biblioteca");
                            string destPath = System.IO.Path.Combine(targetPath, titulo_Cancion + ".mp3");
                            System.IO.File.Copy(sourcePath, destPath, true);
                            FileAttributes attributes = File.GetAttributes(sourcePath);
                            File.SetAttributes(destPath, attributes);
                            MessageBox.Show("You´ve Successfully Added a Song!");
                            labelPath.Visible = false;
                            labelInsertTitle.Visible = false;
                            textBoxNombreCancion.Text = "";
                            textBoxNombreCancion.Visible = false;
                            textBoxPath.Text = "";
                            textBoxPath.Visible = false;
                            panelCambiarOpcionesUsuario.Visible = false;
                            labelPremium.Visible = false;
                        }

                    }
                }
            }
            if (comboBoxOpcionesUsuario.Text == "Add Video")
            {
                foreach (Usuario value in registrados)
                {
                    if (nombre[0] == value.Username)
                    {
                        if (value.Administrador == "False")
                        {
                            
                            /*
                            textBoxNombreCancion.Visible = false;
                            labelInsertTitle.Visible = false;
                            panelCambiarOpcionesUsuario.Visible = true;
                            labelCambio.Visible = true;
                            checkBoxNo.Visible = true;
                            checkBoxSi.Visible = true;
                            labelPremium.Visible = true;
                            checkBoxNo.Checked = false;
                            checkBoxSi.Checked = false;
                            foreach (Usuario data in registrados)
                            {
                                if (nombre[0] == data.Username)
                                {
                                    if (data.Administrador == "False")
                                    {
                                        labelInsertTitle.Visible = false;
                                        labelPremium.Text = "You´re not an Admin Yet! Update to Admin to be able to Add Songs and Videos!";
                                        comboBoxOpcionesUsuario.Text = "Change Admin Attribute";
                                    }
                                    if (data.Administrador == "True")
                                    {
                                        labelInsertTitle.Visible = false;
                                        labelPremium.Text = "You´re an Admin!";
                                    }

                                }
                            }
                            labelCambio.Text = "Would you like to be Admin?";
                            checkBoxSi.Text = "Yes";
                            checkBoxNo.Text = "No";*/

                        }
                        
                        if (value.Administrador == "True")
                        {
                            string path = textBoxPath.Text;
                            string titulo_Video = textBoxNombreCancion.Text;
                            string sourcePath = path;
                            string targetPath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "../../../../Video");
                            string destPath = System.IO.Path.Combine(targetPath, titulo_Video + ".mp4");
                            System.IO.File.Copy(sourcePath, destPath, true);
                            FileAttributes attributes = File.GetAttributes(sourcePath);
                            File.SetAttributes(destPath, attributes);
                            MessageBox.Show("You´ve Successfully Added a Video!");
                            textBoxPath.Text = "";
                            labelPath.Visible = false;
                            labelInsertTitle.Visible = false;
                            textBoxNombreCancion.Text = "";
                            textBoxNombreCancion.Visible = false;
                            textBoxPath.Visible = false;
                            panelCambiarOpcionesUsuario.Visible = false;
                            labelPremium.Visible = false;
                        }
                    }
                }
            }
            if (comboBoxOpcionesUsuario.Text == "Change Admin Attribute")
            {

                foreach (Usuario value in registrados)
                {
                    if (nombre[0] == value.Username)
                    {
                        if (checkBoxSi.Checked == true)
                        {
                            value.Administrador = "True";
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
                            value.Administrador = "False";
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

        private void Profile_Load(object sender, EventArgs e)
        {
            

            

            
        }
    }
}
