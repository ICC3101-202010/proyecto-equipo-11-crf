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
        public VideoPlayer()
        {
            InitializeComponent();

            foreach (Video video in Form1.Reproductor.Video_Library())
            {
                Panel videoPanel = new Panel();
                videoPanel.Size= new Size(640, 67);
                PictureBox videoImage = new PictureBox();
                videoImage.Size = new Size(99, 67);
                Label name_label = new Label();
                Label durartion_label = new Label();

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
                    axWindowsMediaPlayer1.uiMode = "none";
                    axWindowsMediaPlayer1.URL = video.Path ;
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                    
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
    }
}
