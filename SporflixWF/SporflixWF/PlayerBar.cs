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

namespace Spotflix
{
    public partial class PlayerBar : UserControl
    {
        WindowsMediaPlayer player = Form1.Player;
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
    }
}
