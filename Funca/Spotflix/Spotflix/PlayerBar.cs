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
                ProgressBarSong.
            
            }
        
        }
    }
}
