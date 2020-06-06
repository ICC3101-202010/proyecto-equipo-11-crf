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
using System.Threading;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;


namespace Spotflix
{
    [Serializable]
    public partial class Finderr : UserControl
    {
        Finder1 finder1 = new Entrega2.Finder1();

        
        
        
        
        public Finderr()
        {
            InitializeComponent();
            
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            comboBoxFound.Items.Clear();
            labelDonload.Visible = false;
            labelFavorite.Visible = false;

            
            List<Cancion> canciones;
            
            panelMostrar.Visible = true;
            if (comboBoxFind.Text == "Song")
            {
                canciones= finder1.buscarCancion(textBoxFind.Text, Global.allSongs);
                foreach (Cancion cancion in canciones)
                {
                    comboBoxFound.Items.Add(cancion.Titulo_Cancion);
                }
                
                
            }
            else if (comboBoxFind.Text == "Video")
            {
                List<Video> videos = finder1.buscarVideo(textBoxFind.Text, Global.allVideos);
                foreach(Video video in videos)
                {
                    comboBoxFound.Items.Add(video.NameVideo);
                }
            }
            else if (comboBoxFind.Text == "Playlist")
            {
                List<Playlist> playlists = finder1.buscarPlaylist(textBoxFind.Text, Global.allPlaylists);
                foreach (Playlist playlist in playlists)
                {
                    comboBoxFound.Items.Add(playlist);
                }
            }
            else if (comboBoxFind.Text == "Actor/Director")
            {

            }
            else if (comboBoxFind.Text == "Band")
            {
                
                canciones = finder1.buscarArtista(textBoxFind.Text, Global.allSongs);
                foreach (Cancion cancion in canciones)
                {
                    comboBoxFound.Items.Add(cancion.Titulo_Cancion);

                }
            }
           
            else if (comboBoxFind.Text == "Album")
            {
                canciones = finder1.searchAlbum(textBoxFind.Text, Global.allSongs);
                foreach (Cancion cancion in canciones)
                {
                    comboBoxFound.Items.Add(cancion.Titulo_Cancion);
                    
                }
            }
            else if (comboBoxFind.Text == "Top Streamed")
            {
                canciones = finder1.ratingReproducciones(Global.allSongs);
                foreach (Cancion cancion in canciones)
                {
                    comboBoxFound.Items.Add(cancion.Titulo_Cancion);
                }
            }
            else if (comboBoxFind.Text == "Top Rated")
            {
                canciones = finder1.ordenarPorNota(Global.allSongs);
                foreach (Cancion cancion in canciones)
                {
                    comboBoxFound.Items.Add(cancion.Titulo_Cancion);
                }
            }
            else if (comboBoxFind.Text == "User")
            {

            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Form1.MainMenu.Show();
            Form1.Finderr.Hide();
            Form1.Register.Hide();
            Form1.Login.Hide();
            Form1.Preferences.Hide();
            Form1.MailVerified.Hide();
            Form1.Profile.Hide();
            
        }

        private void ButtonFavorite_Click(object sender, EventArgs e)
        {
            

            Cancion seleccionada;
            foreach(Cancion cancion in Global.allSongs)
            {
                if (cancion.Titulo_Cancion == comboBoxFound.Text)
                {
                    seleccionada = cancion;
                    seleccionada.agregarFavoritos(Global.UserNow);
                    
                    labelFavorite.Visible = true;
                    /*Usuario usuario1 = Global.UserNow;
                    IFormatter formatter = new BinaryFormatter();
                    Stream stream = new FileStream("MyFile.bin", FileMode.Create, FileAccess.Write, FileShare.None);
                    formatter.Serialize(stream, usuario1);
                    stream.Close();*/


                }
            }

        }

        private void buttonRate_Click(object sender, EventArgs e)
        {
            panelMetadata.Visible = false;
            if(panelRate.Visible == false)
            {
                panelRate.Visible = true;
            }
            else
            {
                panelRate.Visible = false;
            }
            

        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            int puntuation = Int32.Parse(textBoxRate.Text);
            List<Cancion> canciones = Global.allSongs;
            Cancion seleccionada;
            
            if (puntuation<0 || puntuation > 5)
            {
                labelRate.Visible = true;
            }
            else
            {
                labelRate.Visible = false;
                foreach (Cancion cancion in canciones)
                {
                    if (cancion.Titulo_Cancion == comboBoxFound.Text)
                    {
                        seleccionada = cancion;
                        seleccionada.Rating = puntuation;
                    }
                }
                Thread.Sleep(1000);
                panelRate.Visible = false;
            }
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonDownload_Click(object sender, EventArgs e)
        {

            Cancion seleccionada;
            List<Cancion> canciones = Global.allSongs;
            foreach (Cancion cancion in canciones)
            {
                if (cancion.Titulo_Cancion == comboBoxFound.Text)
                {
                    seleccionada = cancion;
                    seleccionada.descargarCancion();
                    labelDonload.Visible = true;
                    
                }
            }
        }

        private void buttonMetadata_Click(object sender, EventArgs e)
        {
            panelRate.Visible = false;
            listBoxMetadata.Items.Clear();
            if(panelMetadata.Visible == false)
            {
                panelMetadata.Visible = true;
                foreach (Cancion cancion in Global.allSongs)
                {
                    if (cancion.Titulo_Cancion == comboBoxFound.Text)
                    {
                        listBoxMetadata.Items.Add("Title: "+cancion.Titulo_Cancion);
                        listBoxMetadata.Items.Add("Band: "+cancion.Banda);
                        listBoxMetadata.Items.Add("Genre: "+cancion.Genero);
                        listBoxMetadata.Items.Add("Album: "+cancion.Album);
                        listBoxMetadata.Items.Add("Release date: " + cancion.Fecha_Lanzamiento);
                        listBoxMetadata.Items.Add("Duration" + cancion.Duration.ToString());
                        
                    }
                }
            }
            else
            {
                panelMetadata.Visible = false;
            }
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelMostrar_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
