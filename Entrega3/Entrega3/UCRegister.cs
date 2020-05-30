using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entrega3;
 

namespace Entrega3
{
    public partial class UCRegister : UserControl 
    {
        public UCRegister()
        {
            InitializeComponent();
        }

        private void btnSubmitRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (checkBoxYesRegister.Checked == true) 
            {
                Form1.UcPreferences.BringToFront();
                Form1.UcPreferences.Show();

            }
            if (checkBoxNoRegister.Checked == true) 
            {
                Form1.UcMailVerified.BringToFront();
                Form1.UcMailVerified.Show();
            }
        }

        private void PanelRegisterInformation_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
