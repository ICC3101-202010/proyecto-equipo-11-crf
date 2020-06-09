using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
using Entrega2;

namespace Spotflix
{
    public partial class Preferences : UserControl
    {
        public Preferences()
        {
            InitializeComponent();
        }

        private void PanelRegisterInformation_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSubmitPreferencesRegister_Click(object sender, EventArgs e)
        {
            
            IFormatter formatter1 = new BinaryFormatter();
            Stream stream1 = new FileStream("MyFile.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
            Usuario usuario1 = formatter1.Deserialize(stream1) as Usuario;
            stream1.Close();
            IFormatter formatter3 = new BinaryFormatter();
            Stream stream3 = new FileStream("Registrados.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
            List < Usuario > registrados = formatter3.Deserialize(stream3) as List<Usuario>;
            stream3.Close();
            foreach (Usuario user in registrados)
            {


                if (user.Username == usuario1.Username)
                {
                    user.artista1 = textBox1Preference.Text;
                    user.artista2 = textBox2reference.Text;
                    user.artista3 = textBox3Preference.Text;
                    IFormatter formatter = new BinaryFormatter();
                    Stream stream = new FileStream("Registrados.bin", FileMode.Create, FileAccess.Write, FileShare.None);
                    formatter.Serialize(stream, registrados);
                    stream.Close();
                    break;
                }
                
            }


            Form1.Preferences.Hide();
            Form1.MailVerified.Show();
            Form1.MailVerified.BringToFront();
        }
    }
}
