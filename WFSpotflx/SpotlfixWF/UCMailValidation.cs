using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Entrega3
{
    public partial class UCMailValidation : UserControl
    {
        public UCMailValidation()
        {
            InitializeComponent();
        }

        private void checkBoxYesVerified_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnSubmitPreferencesRegister_Click(object sender, EventArgs e)
        {
            
            if (checkBoxNoVerified.Checked == true) 
            {
                Form1.UcMailVerified.Hide();
                Form1.UcWelcome.BringToFront();
                Form1.UcWelcome.Show();

            
            }
        }
    }
}
