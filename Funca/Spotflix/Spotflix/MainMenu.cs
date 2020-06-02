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
using TagLib;


namespace Spotflix
{
    public partial class MainMenu : UserControl
    {
        Reproductor tester = new Reproductor();

        public MainMenu()
        {
            InitializeComponent();
            string ss = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "../../Biblioteca/06.Love Somebody 2");
            //Cancion song = new Cancion("C:/Users/Francisco/Desktop/proyecto-equipo-11-crf/Biblioteca/Love.mp3");
            //pbTestSong.Image = song.Custom_image;
            //labelNameSong.Text = song.Titulo_Cancion;
        }

        private void labelLoading_Click(object sender, EventArgs e)
        {

        }

        private void panelMusicLibrary_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pbTestSong_Click(object sender, EventArgs e)
        {
            //string ss = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "../../Biblioteca/06.Love Somebody 2");
           // Cancion song = new Cancion("C:/Users/Francisco/Desktop/proyecto-equipo-11-crf/Biblioteca/Love.mp3");
           // pbTestSong.Image = song.Custom_image;
           // labelNameSong.Text = song.Titulo_Cancion;

        }

        private void panelTestSOng_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
