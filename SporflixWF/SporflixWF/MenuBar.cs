using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Spotflix;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;

namespace SporflixWF
{
    public partial class MenuBar : UserControl
    {
        public MenuBar()
        {
            InitializeComponent();
        }

        



        private void buttonProfile_Click_1(object sender, EventArgs e)
        {
            Form1.Profile.Refresh();
            Form1.Profile.Show();
            Form1.Profile.BringToFront();
            Form1.MainMenu.Hide();
            Form1.Register.Hide();
            Form1.Login.Hide();
            Form1.Preferences.Hide();
            Form1.MailVerified.Hide();
            Form1.Finderr.Hide();
            Form1.Librarymenu.Hide();
            Form1.Mixer.Hide();
            Form1.Notpremium.Hide();
            Form1.VideoPlayer.Hide();
        }

        private void buttonFinder_Click_1(object sender, EventArgs e)
        {
            Form1.Register.Hide();
            Form1.Login.Hide();
            Form1.MainMenu.Hide();
            Form1.Preferences.Hide();
            Form1.MailVerified.Hide();
            Form1.Profile.Hide();
            Form1.Finderr.Show();
            Form1.Librarymenu.Hide();
            Form1.Mixer.Hide();
            Form1.Notpremium.Hide();
            Form1.VideoPlayer.Hide();

        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            Form1.Register.Hide();
            Form1.Login.Hide();
            Form1.MainMenu.Show();
            Form1.Preferences.Hide();
            Form1.MailVerified.Hide();
            Form1.Profile.Hide();
            Form1.Finderr.Hide();
            Form1.Librarymenu.Hide();
            Form1.Mixer.Hide();
            Form1.Notpremium.Hide();
            Form1.VideoPlayer.Hide();
        }

        private void buttonLibrary_Click(object sender, EventArgs e)
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
                    if (value[7] == "true")
                    {
                        Form1.Register.Hide();
                        Form1.Login.Hide();
                        Form1.MainMenu.Hide();
                        Form1.Preferences.Hide();
                        Form1.MailVerified.Hide();
                        Form1.Profile.Hide();
                        Form1.Librarymenu.Enabled = true;
                        Form1.Finderr.Hide();
                        Form1.Librarymenu.Show();
                        Form1.Mixer.Hide();
                        Form1.VideoPlayer.Hide();
                    }
                    else
                    {
                        Form1.Register.Hide();
                        Form1.Login.Hide();
                        Form1.MainMenu.Hide();
                        Form1.Preferences.Hide();
                        Form1.MailVerified.Hide();
                        Form1.Profile.Hide();
                        Form1.Librarymenu.Enabled = true;
                        Form1.Finderr.Hide();
                        Form1.Librarymenu.Hide();
                        Form1.Mixer.Hide();
                        Form1.Notpremium.Show();
                        Form1.VideoPlayer.Hide();
                    }
                }

            }

        }

        private void buttonMixer_Click(object sender, EventArgs e)
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
                    if (value[7] == "true")
                    {
                        Form1.Register.Hide();
                        Form1.Login.Hide();
                        Form1.MainMenu.Hide();
                        Form1.Preferences.Hide();
                        Form1.MailVerified.Hide();
                        Form1.Profile.Hide();
                        Form1.Finderr.Hide();
                        Form1.Librarymenu.Hide();
                        Form1.Mixer.Show();
                        Form1.Notpremium.Hide();
                        Form1.VideoPlayer.Hide();
                    }
                    else
                    {
                        Form1.Register.Hide();
                        Form1.Login.Hide();
                        Form1.MainMenu.Hide();
                        Form1.Preferences.Hide();
                        Form1.MailVerified.Hide();
                        Form1.Profile.Hide();
                        Form1.Librarymenu.Enabled = true;
                        Form1.Finderr.Hide();
                        Form1.Librarymenu.Hide();
                        Form1.Mixer.Hide();
                        Form1.VideoPlayer.Hide();
                        Form1.Notpremium.Show();
                    }
                }

            }
            

        }

        private void buttonVideo_Click(object sender, EventArgs e)
        {
            Form1.VideoPlayer.Show();
            Form1.Register.Hide();
            Form1.Login.Hide();
            Form1.MainMenu.Hide();
            Form1.Preferences.Hide();
            Form1.MailVerified.Hide();
            Form1.Profile.Hide();
            Form1.Finderr.Hide();
            Form1.Librarymenu.Hide();
            Form1.Mixer.Hide();
            Form1.Notpremium.Hide();
        }
    }
}
