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
            
        }

        private void buttonLibrary_Click(object sender, EventArgs e)
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

        }

        private void buttonMixer_Click(object sender, EventArgs e)
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

        }
    }
}
