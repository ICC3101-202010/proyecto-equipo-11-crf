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
    public partial class Finderr : UserControl
    {
        Finder1 finder1 = new Entrega2.Finder1();
        
        public Finderr()
        {
            InitializeComponent();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            List<Cancion> canciones;
            Cancion cancion1=new Cancion(@"C:\Users\corre\OneDrive\Escritorio\Entrega3Bien\proyecto-equipo-11-crf\Biblioteca\01 - Milky Chance - Blossom 2.mp3");
            Global.allSongs.Add(cancion1);
            panelMostrar.Visible = true;
            if (comboBoxFind.Text == "Song")
            {
                canciones= finder1.buscarCancion(textBoxFind.Text, Global.allSongs);
                foreach (Cancion cancion in canciones)
                {
                    listBoxPrueba.Items.Add(cancion.Titulo_Cancion);
                }
                
            }
            else if (comboBoxFind.Text == "Video")
            {
                List<Video> videos = finder1.buscarVideo(textBoxFind.Text, Global.allVideos);
                foreach(Video video in videos)
                {
                    listBoxPrueba.Items.Add(video.NameVideo);
                }
            }
            else if (comboBoxFind.Text == "Playlist")
            {
                List<Playlist> playlists = finder1.buscarPlaylist(textBoxFind.Text, Global.allPlaylists);
                foreach (Playlist playlist in playlists)
                {
                    listBoxPrueba.Items.Add(playlist);
                }
            }
            else if (comboBoxFind.Text == "Actor/Director")
            {

            }
            else if (comboBoxFind.Text == "Band")
            {

            }
            else if (comboBoxFind.Text == "Album")
            {
                
            }
            else if (comboBoxFind.Text == "Album")
            {
                canciones = finder1.searchAlbum(textBoxFind.Text, Global.allSongs);
                foreach (Cancion cancion in canciones)
                {
                    listBoxPrueba.Items.Add(cancion.Titulo_Cancion);
                }
            }
            else if (comboBoxFind.Text == "Top Streamed")
            {
                canciones = finder1.ratingReproducciones(Global.allSongs);
                foreach (Cancion cancion in canciones)
                {
                    listBoxPrueba.Items.Add(cancion.Titulo_Cancion);
                }
            }
            else if (comboBoxFind.Text == "Top Rated")
            {
                canciones = finder1.ordenarPorNota(Global.allSongs);
                foreach (Cancion cancion in canciones)
                {
                    listBoxPrueba.Items.Add(cancion.Titulo_Cancion);
                }
            }
            else if (comboBoxFind.Text == "User")
            {

            }
        }
    }
}
