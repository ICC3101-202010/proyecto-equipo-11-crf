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
    public partial class UCLoging : UserControl
    {
        public UCLoging()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Form1.UcLogin.Hide();
            Form1.UcLoading.Show();
        }

        private void labelLogIn_Click(object sender, EventArgs e)
        {
            
        }
        

    }
}
