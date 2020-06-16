using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
using System.IO;
using Entrega2;

namespace Spotflix
{
    public partial class PlayerBar : UserControl
    {
        WindowsMediaPlayer player = Form1.Player;
        int status = 0;
        int cant = Form1.Reproductor.Queue(Form1.Actual).Count;
        int current = 0;
        public PlayerBar()
        {
            InitializeComponent();
            pbPlayStop.BackColor = Color.Transparent;
            

        }
        public void RefreshSongStatus() 
        {
            if (player.playState == WMPLib.WMPPlayState.wmppsPlaying) 
            {
                ProgressBarSong.Maximum =(int)player.controls.currentItem.duration;
                timer1.Start();
            
            }
            else if(player.playState == WMPLib.WMPPlayState.wmppsPaused)
            {

                timer1.Stop();
            }
            else if (player.playState == WMPLib.WMPPlayState.wmppsStopped)
            {

                timer1.Stop();
                ProgressBarSong.Value = 0;
                labelDuration.Text = "0:00";
                Form1.Queue_home = Form1.Reproductor.Queue(Form1.Actual);
                if (current < cant)
                {
                    player.URL = Form1.Queue_home[current].path;
                    current++;
                    player.controls.next();

                }
                timer1.Start();

            }


        }
        int min = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            RefreshSongStatus();
            ProgressBarSong.Value = (int)player.controls.currentPosition;
            
            TimeSpan time = (TimeSpan.FromMinutes(player.controls.currentPosition));// + Convert.ToString(TimeSpan.FromSeconds(player.controls.currentPosition));
            int m = (int)time.Minutes;
            int s = (int)time.TotalSeconds;
            if( m == 59) { min = min + 1; }
            labelDuration.Text = Convert.ToString(min) +":"+ Convert.ToString(m);
        }

        private void ProgressBarSong_ValueChanged(object sender, decimal value)
        {

        }

        private void ProgressBarSong_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BarPanelFlow_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ProgressBarSong_Scroll_1(object sender, EventArgs e)
        {
            player.controls.currentPosition = ProgressBarSong.Value;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            Form1.Queue_home = Form1.Reproductor.Queue(Form1.Actual);
            if (current < cant) 
            {
                player.URL = Form1.Queue_home[current].path;
                current++;
                player.controls.next();
            
            }
            RefreshSongStatus();
            
                    


                
            
            
        }

        private void pbPlayStop_Click(object sender, EventArgs e)
        {
            //int status = 0;
            if (status == 0)
            {
                string path = (Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "../../../../ImagenesForm/video (1).png"));
                pbPlayStop.Image = Image.FromFile(path);
                player.controls.pause();
                status = 1;
            }
            else if (status == 1) 
            {
                string path = (Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "../../../../ImagenesForm/pausa.png"));
                pbPlayStop.Image = Image.FromFile(path);
                player.controls.play();
                status = 0;

            }
            RefreshSongStatus();
            
        }
    }
}
