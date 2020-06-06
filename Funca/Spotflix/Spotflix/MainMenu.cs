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
using WMPLib;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
using System.Drawing.Printing;

namespace Spotflix
{
    public partial class MainMenu : UserControl
    {
        //List<Cancion> vacia = new List<Cancion>();
        List<Cancion> library = Form1.Reproductor.Library();
        Reproductor tester = new Reproductor();
        

        List<Panel> song_stack = new List<Panel>();
        

        public MainMenu()
        {
            InitializeComponent();
            
            
            //string ss = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "../../../../../Biblioteca/Love.mp3");

            //Cancion song = new Cancion("C:/Users/Francisco/Desktop/proyecto-equipo-11-crf/Biblioteca/Love.mp3");
            //Cancion song1 = tester.Library()[1];
            foreach (Cancion song in library)
            {
                Panel song_panel = new Panel();
                song_panel.Size = new Size(640, 67);
                PictureBox song_image = new PictureBox();
                song_image.Size = new Size(99, 67);
                Label name_label = new Label();
                Label durartion_label = new Label();

                durartion_label.Text = song.Duration;
                durartion_label.ForeColor = Color.White;
                durartion_label.Location = new Point(528, 25);

                song_panel.Dock = DockStyle.Top;
                song_panel.Margin = new Padding(0, 0, 3, 0);

                song_image.Image = song.Custom_image;
                song_image.SizeMode = PictureBoxSizeMode.Zoom;

                name_label.Text = song.Titulo_Cancion;
                name_label.ForeColor = Color.White;
                name_label.AutoSize = false;
                name_label.Size = new Size(100, 17);


                song_panel.Controls.Add(song_image);
                song_panel.Controls.Add(durartion_label);

                song_panel.Controls.Add(name_label);

                name_label.Location = new Point(158, 25);


                SongsContainerPanelFlow.Controls.Add(song_panel);
                song_stack.Add(song_panel);
                song_panel.MouseHover += delegate (object sender, EventArgs e)
                {
                    song_panel.BackColor = Color.FromArgb(63, 33, 65);

                };
                song_panel.MouseLeave += delegate (object sender, EventArgs e)
                {
                    song_panel.BackColor = Color.FromArgb(41, 22, 39);

                };
                song_panel.Click += delegate (object sender, EventArgs e)
                {
                    Form1.Player.URL =song.path;
                    Form1.Player.controls.play();
                    

                };

            }
            
            //Cancion song = new Cancion(ss);
            //pbTestSong.Image = song.Custom_image;
           // labelNameSong.Text = song.Titulo_Cancion;
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

        private void buttonFinder_Click(object sender, EventArgs e)
        {
            Form1.Register.Hide();
            Form1.Login.Hide();
            Form1.MainMenu.Hide();
            Form1.Preferences.Hide();
            Form1.MailVerified.Hide();
            Form1.Profile.Hide();
            Form1.Finderr.Show();

            Form1.MainMenu.Hide();



        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonProfile_Click(object sender, EventArgs e)
        {
            
            
            Form1.Profile.Show();
            Form1.MainMenu.Hide();
            Form1.Register.Hide();
            Form1.Login.Hide();
            Form1.MainMenu.Hide();
            Form1.Preferences.Hide();
            Form1.MailVerified.Hide();
            Form1.Finderr.Hide();
        }

        private void panelTestSOng_MouseHover(object sender, EventArgs e)
        {
            panelTestSOng.BackColor = Color.FromArgb(63,33,65);


        }

        private void panelTestSOng_MouseLeave(object sender, EventArgs e)
        {
            panelTestSOng.BackColor = Color.FromArgb(41, 22, 39);
        }

        private void panelTestSOng_Click(object sender, EventArgs e)
        {
            //WindowsMediaPlayer player = new WindowsMediaPlayer();
            //player.URL = tester.Library()[1].path;
            //player.controls.play();
        }

        private void buttonMixer_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonLibrary_Click(object sender, EventArgs e)
        {
            
        }
    }
}
