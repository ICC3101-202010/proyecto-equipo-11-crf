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
using WMPLib;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
using System.Drawing.Printing;

namespace Spotflix
{
    public partial class MainMenu : UserControl
    {
        List<Cancion> vacia = new List<Cancion>();
        //List<Cancion> library = Form1.Reproductor.Library();
        Reproductor tester = new Reproductor();
        

        List<Panel> song_stack = new List<Panel>();
        

        public MainMenu()
        {
            InitializeComponent();


            //string ss = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "../../../../../Biblioteca/Love.mp3");

            //Cancion song = new Cancion("C:/Users/Francisco/Desktop/proyecto-equipo-11-crf/Biblioteca/Love.mp3");
            //Cancion song1 = tester.Library()[1];
            //Cancion song1 = library[7];
            foreach (Cancion song in vacia)
            {
                Panel song_panel = new Panel();
                song_panel.Size = new Size(640, 67);
                PictureBox song_image = new PictureBox();
                song_image.Size = new Size(99, 67);
                Label name_label = new Label();
                Label durartion_label = new Label();

                //options panels-labels
                Panel song_options = new Panel();
                Panel song_info_panel = new Panel();
                song_options.Enabled = false;
                song_info_panel.Enabled = false;
                song_options.Visible = false;
                song_info_panel.Visible = false;

                Label song_rating = new Label();
                Label song_Info = new Label();
                Label song_favorite = new Label();

                Label song_Artist = new Label();
                Label song_Genre = new Label();
                Label song_Date = new Label();
                Label song_Rate = new Label();
                Label song_Album = new Label();

                song_options.Size = new Size(200, 97);
                song_info_panel.Size = new Size(200, 113);
            
                song_options.BackColor = Color.FromArgb(82, 39, 65);

                //Color text labels
                song_Info.ForeColor = Color.White;
                song_rating.ForeColor = Color.White;
                song_favorite.ForeColor = Color.White;

                //Tex aling
                song_Info.TextAlign = ContentAlignment.MiddleCenter;
                song_rating.TextAlign = ContentAlignment.MiddleCenter;
                song_favorite.TextAlign = ContentAlignment.MiddleCenter;

                //Text of option labels
                song_Info.Text = "Info";
                song_rating.Text = "Rate";
                song_favorite.Text = "Favorite";
                
                

                //Size of option labels
                song_rating.Size = new Size(200,30);
                song_Info.Size = new Size(200, 30);
                song_favorite.Size = new Size(200, 30);


                //Size of info labels
                song_Album.Size = new Size(200, 21);
                song_Date.Size = new Size(200, 21);
                song_Rate.Size = new Size(200, 21);
                song_Artist.Size = new Size(200, 21);
                song_Genre.Size = new Size(200, 21);

                //Add labels to option songs
                song_options.Controls.Add(song_rating);
                song_rating.Dock = DockStyle.Top;
                song_options.Controls.Add(song_Info);
                song_Info.Dock = DockStyle.Top;
                song_options.Controls.Add(song_favorite);
                song_favorite.Dock = DockStyle.Top;

                //Add labels to info panel
                song_info_panel.Controls.Add(song_Album);
                song_Album.Dock = DockStyle.Top;
                song_info_panel.Controls.Add(song_Date);
                song_Date.Dock = DockStyle.Top;
                song_info_panel.Controls.Add(song_Genre);
                song_Genre.Dock = DockStyle.Top;
                song_info_panel.Controls.Add(song_Rate);
                song_Rate.Dock = DockStyle.Top;
                song_info_panel.Controls.Add(song_Artist);
                song_Artist.Dock = DockStyle.Top;

                SongsContainerPanelFlow.Controls.Add(song_options);
                SongsContainerPanelFlow.Controls.Add(song_info_panel);



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
                    Form1.Actual = song;
                    

                };
                song_panel.MouseDown += delegate (object sender, MouseEventArgs e)
                {
                    if (e.Button == MouseButtons.Right) 
                    {
                        song_options.Enabled = true;
                        song_options.Visible = true;



                    }

                };
                song_Info.Click += delegate (object sender, EventArgs e) 
                {

                    //song_info_panel.BringToFront();
                    song_info_panel.Location = new Point(80, 80);
                    song_info_panel.BorderStyle = BorderStyle.FixedSingle;
                    song_options.Enabled = false;
                    song_options.Visible = false;
                    song_info_panel.Enabled = true;
                    song_info_panel.Visible = true;

                    song_Artist.ForeColor = Color.White;
                    song_Album.ForeColor = Color.White;
                    song_Date.ForeColor = Color.White;
                    song_Genre.ForeColor = Color.White;
                    song_Rate.ForeColor = Color.White;

                    song_Artist.Text = "Artist :" + song.Banda;
                    song_Album.Text = "Album :" + song.Album;
                    song_Date.Text = "Year :" + song.Fecha_Lanzamiento.ToString();
                    song_Genre.Text = "Genre :" + song.Genero;
                    song_Rate.Text = "Rate :" + song.Rating.ToString(); 
                
                };
                song_info_panel.MouseLeave += delegate (object sender, EventArgs e)
                {

                    song_info_panel.Enabled = false;
                    song_info_panel.Visible = false;

                };
                song_options.MouseLeave += delegate (object sender, EventArgs e) 
                {
                    song_options.Enabled = false;
                    song_options.Visible = false;
                
                };
                song_favorite.MouseHover += delegate (object sender, EventArgs e) 
                { 
                    song_favorite.BackColor = Color.FromArgb(41, 22, 39);
                };
                song_favorite.MouseLeave += delegate (object sender, EventArgs e) 
                {
                    song_favorite.BackColor = Color.FromArgb(82, 39, 65);
                };
                song_Info.MouseHover += delegate (object sender, EventArgs e) 
                {
                    song_Info.BackColor = Color.FromArgb(41, 22, 39);
                };
                song_Info.MouseLeave += delegate (object sender, EventArgs e) 
                {
                    song_Info.BackColor = Color.FromArgb(82, 39, 65);
                };
                song_rating.MouseHover += delegate (object sender, EventArgs e) 
                {
                    song_rating.BackColor = Color.FromArgb(41, 22, 39);
                };
                song_rating.MouseLeave += delegate (object sender, EventArgs e) 
                {
                    song_rating.BackColor = Color.FromArgb(82, 39, 65);
                };

            }
            
            
            //pbTestSong.Image = song1.Custom_image;
            //labelNameSong.Text = song1.Titulo_Cancion;
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

        private void panelTestSOng_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right) 
            {
                panelSongOptions.Enabled = true;
                panelSongOptions.Visible = true;

            
            
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            panelInfoSong.Enabled = true;
            panelInfoSong.Visible = true;
           // labelAlbum.Text = library[7].Album;
            //labelGenre.Text = library[7].Genero;
           // labelLaunchDate.Text = library[7].Fecha_Lanzamiento.ToString();
           // label6.Text = library[7].Banda;
           // labelRate.Text = library[7].Rating.ToString();
            panelSongOptions.Enabled = false;
            panelSongOptions.Visible = false;
        }
    }
}
