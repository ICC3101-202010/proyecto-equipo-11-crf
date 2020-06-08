using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Entrega2;
using WMPLib;
using System.Runtime.CompilerServices;
using AxWMPLib;

namespace Spotflix
{
    public partial class Form1 : Form
    {
        
        private static UserControl welcome;
        private static UserControl login;
        private static UserControl register;
        private static UserControl preferences;
        private static UserControl mailVerified;
        private static UserControl loading;
        private static UserControl mainmenu;
        private static UserControl finderr;
        private static UserControl profile;
        private static Cancion actual;
        private static UserControl progresBar;
        private static UserControl menubar;
        private static UserControl mixer;
        private static UserControl librarymenu;
        private static UserControl videoPlayer;
        private static UserControl notpremium;
        private static List<Cancion> library = new List<Cancion>();
        private static WindowsMediaPlayer player = new WindowsMediaPlayer();
        private static AxWindowsMediaPlayer MediaPlayer = new AxWindowsMediaPlayer();
        private static Reproductor reproductor = new Reproductor();
        
        
        

        List<Panel> stackPanels = new List<Panel>();
        static List<UserControl> stackUserControls = new List<UserControl>();
        Dictionary<string, Panel> panels = new Dictionary<string, Panel>();

        public static UserControl Welcome { get => welcome; set => welcome = value; }
        public static UserControl Register { get => register; set => register = value; }
        public static UserControl Preferences { get => preferences; set => preferences = value; }
        public static UserControl MailVerified { get => mailVerified; set => mailVerified = value; }
        public static UserControl Login { get => login; set => login = value; }
        public static UserControl Loading { get => loading; set => loading = value; }
        public static UserControl MainMenu { get => mainmenu; set => mainmenu = value; }
        public static List<UserControl> StackUserControls { get => stackUserControls; set => stackUserControls = value; }
        public static UserControl Finderr { get => finderr; set => finderr = value; }
        public static UserControl Profile { get => profile; set => profile = value; }
        public static Reproductor Reproductor { get => reproductor; set => reproductor = value; }
        public static List<Cancion> Library { get => library; set => library = reproductor.Library(); }
        public static Cancion Actual { get => actual; set => actual = value; }
        public static WindowsMediaPlayer Player { get => player; set => player = value; }
        public static UserControl ProgresBar { get => progresBar; set => progresBar = value; }
        public static UserControl Menubar { get => menubar; set => menubar = value; }
        public static UserControl Mixer { get => mixer; set => mixer = value; }
        public static UserControl Librarymenu { get => librarymenu; set => librarymenu = value; }
        public static UserControl VideoPlayer { get => videoPlayer; set => videoPlayer = value; }
        public static AxWindowsMediaPlayer MediaPlayer1 { get => MediaPlayer; set => MediaPlayer = value; }
        public static UserControl Notpremium { get => notpremium; set => notpremium = value; }

        public Form1()
        {
            InitializeComponent();
            

        }

        private void ShowLastPanel()
        {
            foreach (Panel panel in panels.Values)
            {
                if (panel != stackPanels.Last())
                {
                    panel.Visible = false;
                }
                else
                {
                    panel.Visible = true;
                }
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            Login = logIn1;
            Register = register1;
            Welcome = welcome1;
            MailVerified = mailValidation1;
            Preferences = preferences1;
            MainMenu = mainMenu1;
            Finderr = finderr1;
            Profile = profile1;
            ProgresBar = playerBar1;
            Menubar = menuBar1;
            Mixer = mixer1;
            Librarymenu = library1;
            VideoPlayer = videoPlayer1;
            Notpremium = notPremium1;
            Welcome.BringToFront();
            Notpremium.Hide();
            VideoPlayer.Hide();
            Mixer.Hide();
            Librarymenu.Hide();
            MainMenu.Hide();
            Login.Hide();
            Preferences.Hide();
            MailVerified.Hide();
            Finderr.Hide();
            Profile.Hide();
            ProgresBar.Hide();
            Menubar.Hide();
            Reproductor reproducto = new Reproductor();
            Global.allSongs = reproducto.Library();
            Playlist allSongs = new Playlist("allSongs", Global.allSongs, null, "Defect");
            Global.allPlaylists.Add(allSongs);
            Global.allVideos = reproducto.Video_Library();

            
        }

        private void mainMenu1_Load(object sender, EventArgs e)
        {
            
        }

        private void finderr1_Load(object sender, EventArgs e)
        {

        }

        private void menuBar1_Load(object sender, EventArgs e)
        {

        }
    }
}