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

        private void timer1_Tick(object sender, EventArgs e)
        {
            RefreshSongStatus();
            ProgressBarSong.Value = (int)player.controls.currentPosition;
        }

        private void ProgressBarSong_ValueChanged(object sender, decimal value)
        {

        }
        
        
        
        

    }
}
