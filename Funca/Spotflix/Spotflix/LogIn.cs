using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Entrega2;

namespace Spotflix
{
    public partial class LogIn : UserControl
    {
        public LogIn()
        {
            InitializeComponent();
            labelError.Visible = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            if (Convert.ToString(textBoxPasswordLogin.Text) == "" & Convert.ToString(textBoxUsernameLogIn.Text) == "")
            {
                labelError.Visible = true;
            }
            else
            {
                Usuario usuario = new Usuario();
                usuario.Username = textBoxUsernameLogIn.Text;
                Form1.MainMenu.Show();
            }
        }

        private void bAtrasLogIn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1.Welcome.Show();
        }
    }
}
