using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entrega2;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;

namespace Spotflix
{
    public partial class Profile : UserControl
    {
        

        public Profile()
        {
            InitializeComponent();
            
            
        }

        

        private void bAtrasProfile_Click(object sender, EventArgs e)
        {
            Form1.Profile.Hide();
            Form1.MainMenu.Show();
            
        }

        private void bUserOptions_Click(object sender, EventArgs e)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("nombre.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
            List<string> nombre = formatter.Deserialize(stream) as List<string>;
            stream.Close();
            
            foreach (string name in nombre)
            {
                
                tNombreProfile.Text += "Nombre Usuario: ";
                tNombreProfile.Text += name;
                
            }
        }

        private void bEditProfile_Click(object sender, EventArgs e)
        {

        }
    }
}
