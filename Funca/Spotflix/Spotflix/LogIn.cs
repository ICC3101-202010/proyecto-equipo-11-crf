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
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;


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
                IFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream("nombre.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
                List<string> nombre = formatter.Deserialize(stream) as List<string>;
                stream.Close();
                nombre.Add(textBoxUsernameLogIn.Text);
                string name = "carlo";
                nombre.Add(name);
                IFormatter formatter1 = new BinaryFormatter();
                Stream stream1 = new FileStream("nombre.bin", FileMode.Create, FileAccess.Write, FileShare.None);
                formatter1.Serialize(stream1, nombre);
                stream1.Close();
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
