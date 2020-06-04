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

namespace Spotflix
{
    public partial class Profile : UserControl
    {
        

        public Profile()
        {
            InitializeComponent();
            tNombreProfile.Text = "Nombre Usuario";
        }

        private void bAtrasProfile_Click(object sender, EventArgs e)
        {
            Form1.Profile.Hide();
            Form1.MainMenu.Show();
            
        }

        private void bUserOptions_Click(object sender, EventArgs e)
        {

        }

        private void bEditProfile_Click(object sender, EventArgs e)
        {

        }
    }
}
