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
    public partial class NotPremium : UserControl
    {
        
        public NotPremium()
        {
            InitializeComponent();
        }

        private void buttonUpgradeNotPremium_Click(object sender, EventArgs e)
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
        }
    }
}
