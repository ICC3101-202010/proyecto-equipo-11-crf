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
            if (Form1.Librarymenu.Enabled == true) 
            {
                if (Global.UserNow.My_Playlist.Any() == false)
                {
                    pbEmpty.Enabled = false;
                    pbEmpty.Visible = false;
                    labelEmptyLibrary.Enabled = false;
                    labelEmptyLibrary.Visible = false;
                }

            
            }
        }

        private void labelEmptyLibrary_Click(object sender, EventArgs e)
        {

        }

        private void panelLibrary_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
