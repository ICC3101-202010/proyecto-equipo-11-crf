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
    public partial class MailValidation : UserControl
    {
        public MailValidation()
        {
            InitializeComponent();
        }

        private void MailValidation_Load(object sender, EventArgs e)
        {

        }

        private void PanelRegisterInformation_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSubmitPreferencesRegister_Click(object sender, EventArgs e)
        {
            if (checkBoxNoVerified.Checked == true)
            {
                MessageBox.Show("MailService: Se ha enviado un email al correo indicado para Verificar su correo");
                Form1.MailVerified.Hide();
                Form1.Welcome.BringToFront();
                Form1.Welcome.Show();


            }
            else
            {
                Form1.MailVerified.Hide();
                Form1.Welcome.BringToFront();
                Form1.Welcome.Show();
            }
        }
    }
}
