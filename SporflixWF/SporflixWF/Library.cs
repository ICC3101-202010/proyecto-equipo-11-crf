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
    public partial class Library : UserControl
    {
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
                pbEmpty.Enabled = false;
                pbEmpty.Visible = false;
                labelEmptyLibrary.Enabled = false;
                labelEmptyLibrary.Visible = false;
                foreach (Playlist playlist in Global.UserNow.My_Playlist) 
                {
                    FlowLayoutPanel playlistPanel = new FlowLayoutPanel();
                    Label playlist_name = new Label();
                    PictureBox pictureBox = new PictureBox();
                    label1.Text = playlist.NombrePlaylist;
                
                }
            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Playlist nueva = new Playlist("Primera", Global.UserNow);
            Global.UserNow.My_Playlist.Add(nueva);
            //label1.Text = Global.UserNow.Username;
            
        }
    }
}
