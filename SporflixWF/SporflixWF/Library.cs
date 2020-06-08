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

                panel_playlist.Size = new Size(194, 190);
                pb_playlist.Size = new Size(183, 158);
                label_type.Size = new Size(36, 13);
                label_type.Location = new Point(97, 187);

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
                pb_playlist.Dock = DockStyle.Top;
                panel_playlist.Controls.Add(label_playlist);
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
            }
            else 
            {




                Panel panel_playlist = new Panel();
                PictureBox pb_playlist = new PictureBox();
                Label label_playlist = new Label();
                Label label_type = new Label();

                panel_playlist.Size = new Size(194, 190);
                pb_playlist.Size = new Size(183, 158);
                label_type.Size = new Size(36, 13);
                label_type.Location = new Point(97, 187);

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
                pb_playlist.Dock = DockStyle.Top;
                panel_playlist.Controls.Add(label_playlist);
               // label_playlist.Dock = DockStyle.Bottom;

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
            actual = playlist_end;
            panelNewPlaylist.Enabled = true;
            panelNewPlaylist.Visible = true;
        }
    }
}
