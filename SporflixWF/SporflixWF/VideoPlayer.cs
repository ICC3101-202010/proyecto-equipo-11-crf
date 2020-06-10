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
using TagLib;
using Spotflix;
using AxWMPLib;
using WMPLib;

namespace SporflixWF
{
    public partial class VideoPlayer : UserControl
    {
        private List<Label> playlist_label = new List<Label>();
        Video actual_video;
        public VideoPlayer()
        {
            

            InitializeComponent();
            List<Video> videos = new List<Video>();
            
            //Form1.Reproductor.Video_Library()
            foreach (Video video in Form1.Reproductor.Video_Library())
            {
                Panel videoPanel = new Panel();
                videoPanel.Size= new Size(640, 67);
                PictureBox videoImage = new PictureBox();
                videoImage.Size = new Size(99, 67);
                Label name_label = new Label();
                Label durartion_label = new Label();

                //options panels-labels
                Panel song_options = new Panel();
                Panel song_info_panel = new Panel();
                Panel playlist_list = new Panel();
                playlist_list.Enabled = false;
                song_options.Enabled = false;
                song_info_panel.Enabled = false;
                song_options.Visible = false;
                song_info_panel.Visible = false;
                playlist_list.Visible = false;

                Label song_rating = new Label();
                Label song_Info = new Label();
                Label song_favorite = new Label();
                Label song_add_playlist = new Label();

                Label song_Artist = new Label();
                Label song_Genre = new Label();
                Label song_Date = new Label();
                Label song_Rate = new Label();
                Label song_Album = new Label();
                Label song_plays = new Label();

                song_options.Size = new Size(200, 126);
                song_info_panel.Size = new Size(200, 130);
                playlist_list.Size = new Size(182, 63);
                playlist_list.AutoScroll = true;
                song_options.BackColor = Color.FromArgb(82, 39, 65);
                name_label.AutoSize = true;

                //Color text labels
                song_Info.ForeColor = Color.White;
                song_rating.ForeColor = Color.White;
                song_favorite.ForeColor = Color.White;
                song_add_playlist.ForeColor = Color.White;

                //Tex aling
                song_Info.TextAlign = ContentAlignment.MiddleCenter;
                song_rating.TextAlign = ContentAlignment.MiddleCenter;
                song_favorite.TextAlign = ContentAlignment.MiddleCenter;
                song_add_playlist.TextAlign = ContentAlignment.MiddleCenter;

                //Text of option labels
                song_Info.Text = "Info";
                song_rating.Text = "Rate";
                song_favorite.Text = "Favorite";
                song_add_playlist.Text = "Add playlist";


                //Size of option labels
                song_rating.Size = new Size(200, 30);
                song_Info.Size = new Size(200, 30);
                song_favorite.Size = new Size(200, 30);
                song_add_playlist.Size = new Size(200, 30);

                //Size of info labels
                song_Album.Size = new Size(200, 21);
                song_Date.Size = new Size(200, 21);
                song_Rate.Size = new Size(200, 21);
                song_Artist.Size = new Size(200, 21);
                song_Genre.Size = new Size(200, 21);
                song_plays.Size = new Size(200, 21);

                //Add labels to option songs
                song_options.Controls.Add(song_rating);
                song_rating.Dock = DockStyle.Top;
                song_options.Controls.Add(song_Info);
                song_Info.Dock = DockStyle.Top;
                song_options.Controls.Add(song_favorite);
                song_favorite.Dock = DockStyle.Top;
                song_options.Controls.Add(song_add_playlist);
                song_add_playlist.Dock = DockStyle.Top;

                //Add labels to info panel

                song_info_panel.Controls.Add(song_Date);
                song_Date.Dock = DockStyle.Top;
                song_info_panel.Controls.Add(song_Genre);
                song_Genre.Dock = DockStyle.Top;
                song_info_panel.Controls.Add(song_Rate);
                song_Rate.Dock = DockStyle.Top;

                song_info_panel.Controls.Add(song_plays);
                song_plays.Dock = DockStyle.Top;

                flowLayoutPanelVideo.Controls.Add(song_options);
                flowLayoutPanelVideo.Controls.Add(song_info_panel);
                flowLayoutPanelVideo.Controls.Add(playlist_list);


                durartion_label.Text = video.Duration;
                durartion_label.ForeColor = Color.White;
                durartion_label.Location = new Point(528, 25);

                videoPanel.Dock = DockStyle.Top;
                videoPanel.Margin = new Padding(0, 0, 3, 0);

                videoImage.Image = video.VideoImage;
                videoImage.SizeMode = PictureBoxSizeMode.Zoom;

                name_label.Text = video.NameVideo;
                name_label.ForeColor = Color.White;
                name_label.AutoSize = false;
                name_label.Size = new Size(100, 17);


                videoPanel.Controls.Add(videoImage);
                videoPanel.Controls.Add(durartion_label);

                videoPanel.Controls.Add(name_label);

                name_label.Location = new Point(158, 25);
                flowLayoutPanelVideo.Controls.Add(videoPanel);

                videoPanel.MouseHover += delegate (object sender, EventArgs e)
                {
                    videoPanel.BackColor = Color.FromArgb(63, 33, 65);

                };
                videoPanel.MouseLeave += delegate (object sender, EventArgs e)
                {
                    videoPanel.BackColor = Color.FromArgb(41, 22, 39);

                };
                videoPanel.Click += delegate (object sender, EventArgs e)
                {

                    panelPlayVideo.Visible = true;
                    axWindowsMediaPlayer1.Show();
                    axWindowsMediaPlayer1.URL = video.Path ;
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                    
                };
                videoPanel.MouseDown += delegate (object sender, MouseEventArgs e)
                {
                    if (e.Button == MouseButtons.Right)
                    {
                        actual_video = video;
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
                    song_plays.ForeColor = Color.White;


                    song_Date.Text = "Year :" + video.Year.ToString();
                    song_Genre.Text = "Genre :" + video.Genero;
                    song_Rate.Text = "Rate :" + video.Rating.ToString();
                    song_plays.Text = "Plays :" + video.Vistos.ToString();

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
                song_add_playlist.MouseHover += delegate (object sender, EventArgs e)
                {
                    song_add_playlist.BackColor = Color.FromArgb(41, 22, 39);
                };
                song_add_playlist.MouseLeave += delegate (object sender, EventArgs e)
                {
                    song_add_playlist.BackColor = Color.FromArgb(82, 39, 65);
                };
                playlist_list.MouseLeave += delegate (object sender, EventArgs e)
                {
                    playlist_list.Enabled = false;
                    playlist_list.Visible = false;


                };
                //Add playist
                song_add_playlist.Click += delegate (object sender, EventArgs e)
                {
                    if (Global.UserNow.My_Playlist.Any() == false)
                    {

                        //Combo box diciendo que no hay playlist
                    }
                    else
                    {
                        playlist_list.Enabled = true;
                        playlist_list.Visible = true;



                    }

                };
                playlist_list.EnabledChanged += delegate (object sender, EventArgs e)
                {
                    playlist_label = new List<Label>();
                    foreach (Playlist playlist in Global.UserNow.My_Playlist)
                    {
                        Label playlist_name = new Label();
                        playlist_name.Text = playlist.NombrePlaylist;
                        playlist_name.ForeColor = Color.White;
                        playlist_name.BackColor = Color.FromArgb(58, 31, 50);
                        playlist_list.Controls.Add(playlist_name);
                        playlist_label.Add(playlist_name);
                        playlist_name.Dock = DockStyle.Top;
                        playlist_name.Click += new EventHandler(AddVideo);

                    }

                };
                song_favorite.Click += delegate (object sender, EventArgs e)
                {

                    if (Global.UserNow.Canciones_favoritas.Any() == false)
                    {
                        Playlist playlist_fav = new Playlist("✪Favorite✪", Global.UserNow);
                        playlist_fav.agregarVideoPlaylist(video);
                        Global.UserNow.My_Playlist.Add(playlist_fav);
                    }
                    else
                    {
                        Global.UserNow.Videos_favoritos.Add(video);
                    }
                };

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void buttonPause_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            panelPlayVideo.Visible = false;
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }

        private void buttonNextVideo_Click(object sender, EventArgs e)
        {
            int count = 0;
            int numberOnList = 0;
            foreach(Video vid in Form1.Reproductor.Video_Library())
            {
                if (axWindowsMediaPlayer1.URL == vid.Path)
                {
                    numberOnList = count;
                }
                count += 1;
            }
            if (numberOnList < count-1)
            {
                axWindowsMediaPlayer1.URL = Form1.Reproductor.Video_Library()[numberOnList + 1].Path;
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
            
        }
        public void AddVideo(object sender, EventArgs e)
        {
            foreach (Playlist playlist in Global.UserNow.My_Playlist)
            {
                foreach (Label label in playlist_label)
                {
                    if (playlist.NombrePlaylist == label.Text)
                    {
                        playlist.agregarVideoPlaylist(actual_video);                                             
                    }
                }
            }
        }
    }
}
