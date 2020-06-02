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
    public partial class Register : UserControl
    {
        public Register()
        {
            InitializeComponent();
        }

        private void btnSubmitRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
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
        }

        private void bAtrasRegistration_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1.Welcome.Show();
        }
    }
}
