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

namespace Spotflix
{
    public partial class Finderr : UserControl
    {
        Finder1 finder1 = new Entrega2.Finder1();
        public Finderr()
        {
            InitializeComponent();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            
            if (comboBoxFind.Text == "Song")
            {
                List<Cancion> canciones= finder1.buscarCancion(textBoxFind.Text, Global.allSongs);
                foreach (Cancion cancion in canciones)
                {
                    listBoxPrueba.Items.Add(cancion);
                }
                
            }
            else if (comboBoxFind.Text == "Video")
            {

            }
            else if (comboBoxFind.Text == "Playlist")
            {

            }
            else if (comboBoxFind.Text == "Actor/Director")
            {

            }
            else if (comboBoxFind.Text == "Band")
            {

            }
            else if (comboBoxFind.Text == "Album")
            {

            }
            else if (comboBoxFind.Text == "Album")
            {

            }
            else if (comboBoxFind.Text == "Top Streamed")
            {

            }
            else if (comboBoxFind.Text == "Top Rated")
            {

            }
            else if (comboBoxFind.Text == "User")
            {

            }
        }
    }
}
