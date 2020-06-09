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
    public partial class Welcome : UserControl
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void buttonRegistrar_Click(object sender, EventArgs e)
        {
            Form1.Welcome.Hide();
            Form1.Register.Show();
            Form1.Register.BringToFront();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Form1.Welcome.Hide();
            Form1.Login.Show();
            Form1.Login.BringToFront();

        }
    }
}
