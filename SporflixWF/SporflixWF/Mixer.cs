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
using WMPLib;

namespace Spotflix
{
    public partial class Mixer : UserControl
    {
        public Mixer()
        {
            InitializeComponent();
            WindowsMediaPlayer SongPlayer = new WindowsMediaPlayer();
            WindowsMediaPlayer EffectPlayer = new WindowsMediaPlayer();
            /*foreach (Cancion can in Form1.Reproductor.Library())
            {
                comboBoxMixer.Items.Add(can.Titulo_Cancion);
            }*/
        }

        private void buttonPlayMixer_Click(object sender, EventArgs e)
        {
            Cancion selected = new Cancion();
            foreach(Cancion can in Global.allSongs)
            {
                if (can.Titulo_Cancion == comboBoxMixer.Text)
                {
                    selected = can;
                }
            }
            Form1.Player.URL = selected.path;
            Form1.Player.controls.play();
            
        }
    }
}
