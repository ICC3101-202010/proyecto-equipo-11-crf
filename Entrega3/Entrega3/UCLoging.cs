using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace Entrega3
{
    public partial class UCLoging : UserControl
    {
        public UCLoging()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Thread.Sleep(4000);
            //Form1.UcLogin.Hide();
            //Thread.Sleep(4000);
            Form1.UcLogin.Hide();
            //Form1.UcLoading.BringToFront();
            Form1.UcLoading.Show();
            
            //Form1.UcLoading.Hide();
            //Thread.Sleep(4000);
            //Form1.UcLogin.Show();
            //Form1.UcLoading.Hide();
            //Form1.UcMainMenu.Show();
        }

        private void labelLogIn_Click(object sender, EventArgs e)
        {
            
        }

        private void PanelRegisterInformation_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
