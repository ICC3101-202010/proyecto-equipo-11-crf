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

        private void buttonFinder_Click(object sender, EventArgs e)
        {
            Form1.Register.Hide();
            Form1.Login.Hide();
            Form1.MainMenu.Hide();
            Form1.Preferences.Hide();
            Form1.MailVerified.Hide();
            Form1.Profile.Hide();
            Form1.Finderr.Show();

            Form1.MainMenu.Hide();
        }

        private void buttonProfile_Click(object sender, EventArgs e)
        {
            Form1.Profile.Show();
            Form1.MainMenu.Hide();
            Form1.Register.Hide();
            Form1.Login.Hide();
            Form1.MainMenu.Hide();
            Form1.Preferences.Hide();
            Form1.MailVerified.Hide();
            Form1.Finderr.Hide();
        }
    }
}
