using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spotflix
{
    public partial class Preferences : UserControl
    {
        public Preferences()
        {
            InitializeComponent();
        }

        private void PanelRegisterInformation_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSubmitPreferencesRegister_Click(object sender, EventArgs e)
        {

            Form1.MailVerified.BringToFront();
        }
    }
}
