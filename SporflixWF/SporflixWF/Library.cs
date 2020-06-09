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
using System.Diagnostics.Contracts;

namespace Spotflix
{
    public partial class Library : UserControl
    {
        private Playlist actual;
        int side = 2;
        public Library()
        {
            InitializeComponent();

        }

        private void labelEmptyLibrary_Click(object sender, EventArgs e)
        {

        }

        private void panelLibrary_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Library_Enter(object sender, EventArgs e)
        {
            if (Global.UserNow.My_Playlist.Any() == false)
            {



            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Playlist nueva = new Playlist(null, Global.UserNow);
            //Global.UserNow.My_Playlist.Add(nueva);
            actual = nueva;
            panelNewPlaylist.Enabled = true;
            panelNewPlaylist.Visible = true;
            if (Global.UserNow.privacidad == "Publica")
            {
                labelPrivate.Enabled = true;
                labelPrivate.Visible = true;
                radioButtonPrivate.Enabled = true;
                radioButtonPrivate.Visible = true;
            }
            else if (Global.UserNow.privacidad == "Publica")
            {
                labelPrivate.Enabled = false;
                labelPrivate.Visible = false;
                radioButtonPrivate.Enabled = false;
                radioButtonPrivate.Visible = false;
            }
            //label1.Text = Global.UserNow.Username;
            if (Global.UserNow.My_Playlist.Any() == true)
            {
                pbEmpty.Enabled = false;
                pbEmpty.Visible = false;
                labelEmptyLibrary.Enabled = false;
                labelEmptyLibrary.Visible = false;
                pbAdd.Enabled = false;
                pbAdd.Visible = false;


            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddPlaylist_Click(object sender, EventArgs e)
        {


            //Playlist new_playlist = new Playlist(labelNamePlaylist.Text, Global.UserNow);
            if (Global.UserNow.My_Playlist.Any() == false)
            {



                Panel panel_playlist = new Panel();
                PictureBox pb_playlist = new PictureBox();
                Label label_playlist = new Label();
                Label label_type = new Label();

                panel_playlist.Size = new Size(194, 120);
                pb_playlist.Size = new Size(183, 115);
                label_playlist.AutoSize = false;
                label_playlist.TextAlign = ContentAlignment.MiddleLeft;
                //label_type.Size = new Size(36, 35);
                label_type.Location = new Point(0, 60);

                actual.NombrePlaylist = textBoxName.Text;
                label_type.Text = "Song";
                label_playlist.Text = actual.NombrePlaylist;
                label_playlist.ForeColor = Color.White;
                label_type.ForeColor = Color.Yellow;

                pb_playlist.SizeMode = PictureBoxSizeMode.Zoom;

                Global.UserNow.My_Playlist.Add(actual);

                pb_playlist.Image = actual.Imagen_personalizada;

                panel_playlist.BorderStyle = BorderStyle.FixedSingle;
                panel_playlist.Controls.Add(pb_playlist);
                pb_playlist.Dock = DockStyle.Right;
                panel_playlist.Controls.Add(label_playlist);
                //label_playlist.Dock = DockStyle.Left;
                label_playlist.Font = new Font("Arial", 15);
                label_type.Location = new Point(0, 60);
                label_type.Anchor = AnchorStyles.Left;
                //label_playlist.Dock = DockStyle.Bottom;


                panel_playlist.Dock = DockStyle.Top;
                panelLibrary.Controls.Add(panel_playlist);

                pbEmpty.Visible = false;
                pbAdd.Visible = false;
                labelAddPlaylist.Visible = false;
                labelEmptyLibrary.Visible = false;
                panelNewPlaylist.Enabled = false;
                panelNewPlaylist.Visible = false;

                pbAddRigth.Enabled = true;
                pbAddRigth.Visible = true;
                panel_playlist.Click += new EventHandler(InLibrary);
            }
            else
            {




                Panel panel_playlist = new Panel();
                PictureBox pb_playlist = new PictureBox();
                Label label_playlist = new Label();
                Label label_type = new Label();

                panel_playlist.Size = new Size(194, 120);
                pb_playlist.Size = new Size(183, 115);
                label_type.Size = new Size(36, 30);
                label_type.Location = new Point(0, 95);

                actual.NombrePlaylist = textBoxName.Text;
                label_type.Text = "Song";
                label_playlist.Text = actual.NombrePlaylist;
                label_playlist.ForeColor = Color.White;
                label_type.ForeColor = Color.Yellow;

                pb_playlist.SizeMode = PictureBoxSizeMode.Zoom;
                if (Global.UserNow.privacidad == "Publica") 
                {
                    if (radioButtonPrivate.Checked == true)
                    {
                        actual.Privacidad = true;
                    }
                    else 
                    {
                        actual.Privacidad = false;
                    }
                }
                Global.UserNow.My_Playlist.Add(actual);

                pb_playlist.Image = actual.Imagen_personalizada;

                panel_playlist.BorderStyle = BorderStyle.FixedSingle;
                panel_playlist.Controls.Add(pb_playlist);
                pb_playlist.Dock = DockStyle.Right;
                panel_playlist.Controls.Add(label_playlist);
                
                label_playlist.Font = new Font("Arial", 20);
              

                panel_playlist.Dock = DockStyle.Top;
                panelLibrary.Controls.Add(panel_playlist);

                pbEmpty.Visible = false;
                pbAdd.Visible = false;
                labelAddPlaylist.Visible = false;
                labelEmptyLibrary.Visible = false;
                panelNewPlaylist.Enabled = false;
                panelNewPlaylist.Visible = false;

                pbAddRigth.Enabled = true;
                pbAddRigth.Visible = true;
                panel_playlist.Click += new EventHandler(InLibrary);
            }






        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //MemoryStream ms = new MemoryStream(Convert.ToInt32(openFileDialog1.FileName));
                //Image imagen = new Image(openFileDialog1.FileName);
                this.actual.Imagen_personalizada = Image.FromFile(openFileDialog1.FileName);

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pbEmpty.Enabled = false;
            pbEmpty.Visible = false;
            labelEmptyLibrary.Enabled = false;
            labelEmptyLibrary.Visible = false;
            pbAdd.Enabled = false;
            pbAdd.Visible = false;
            Playlist playlist_end = new Playlist(null, Global.UserNow);
            if (Global.UserNow.privacidad == "Publica") 
            {
                labelPrivate.Enabled = true;
                labelPrivate.Visible = true;
                radioButtonPrivate.Enabled = true;
                radioButtonPrivate.Visible = true;
            }
            else if (Global.UserNow.privacidad == "Publica")
            {
                labelPrivate.Enabled = false;
                labelPrivate.Visible = false;
                radioButtonPrivate.Enabled = false;
                radioButtonPrivate.Visible = false;
            }
            actual = playlist_end;
            panelNewPlaylist.Enabled = true;
            panelNewPlaylist.Visible = true;
        }
        private void InLibrary(object sender, EventArgs e)
        {
            flowLayoutPanel1.Enabled = true;
            flowLayoutPanel1.Visible = true;
            flowLayoutPanel1.Controls.Clear();
            //panelLibrary.Visible = false;
            foreach (Cancion song in actual.Canciones) 
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
                song_info_panel.Controls.Add(song_plays);
                song_plays.Dock = DockStyle.Top;

                flowLayoutPanel1.Controls.Add(song_options);
                flowLayoutPanel1.Controls.Add(song_info_panel);
                flowLayoutPanel1.Controls.Add(playlist_list);



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


                flowLayoutPanel1.Controls.Add(song_panel);

            }
        
        }
    }
}
