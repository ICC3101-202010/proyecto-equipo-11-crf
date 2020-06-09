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
using SporflixWF;

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
                panelFinderUser.Visible = false;
                panelButttons.Visible = true;
                canciones= finder1.buscarCancion(textBoxFind.Text, Global.allSongs);
                foreach (Cancion cancion in canciones)
                {
                    comboBoxFound.Items.Add(cancion.Titulo_Cancion);
                }
                
                
            }
            else if (comboBoxFind.Text == "Video")
            {
                panelFinderUser.Visible = false;
                List<Video> videos = finder1.buscarVideo(textBoxFind.Text, Global.allVideos);
                foreach(Video video in videos)
                {
                    comboBoxFound.Items.Add(video.NameVideo);
                }
                panelButttons.Visible = false;
            }
            else if (comboBoxFind.Text == "Playlist")
            {
                panelFinderUser.Visible = true;
                label2.Visible = false;
                List<Playlist> playlists = finder1.buscarPlaylist(textBoxFind.Text, Global.allPlaylists);
                foreach (Playlist playlist in playlists)
                {
                    comboBoxUsuarios.Items.Add(playlist.NombrePlaylist);
                }
                panelButttons.Visible = false;
            }
            else if (comboBoxFind.Text == "Actor/Director")
            {
                panelFinderUser.Visible = false;
                panelButttons.Visible = false;
            }
            else if (comboBoxFind.Text == "Band")
            {
                List<string> Repetidas = new List<string>();
                label2.Visible = false;
                panelFinderUser.Visible = true;
                panelButttons.Visible = true;
                canciones = finder1.buscarArtista(textBoxFind.Text, Global.allSongs);
                
                foreach (Cancion cancion in canciones)
                {
                    Repetidas.Add(cancion.Banda);
                }
                List<string> noRepetidas = Repetidas.Distinct().ToList();
                foreach(string can in noRepetidas)
                {
                    comboBoxUsuarios.Items.Add(can);
                }
            }
           
            else if (comboBoxFind.Text == "Album")
            {
                panelFinderUser.Visible = false;
                panelButttons.Visible = true;
                canciones = finder1.searchAlbum(textBoxFind.Text, Global.allSongs);
                foreach (Cancion cancion in canciones)
                {
                    comboBoxFound.Items.Add(cancion.Titulo_Cancion);
                    
                }
            }
            else if (comboBoxFind.Text == "Top Streamed")
            {
                panelFinderUser.Visible = false;
                panelButttons.Visible = true;
                canciones = finder1.ratingReproducciones(Global.allSongs);
                foreach (Cancion cancion in canciones)
                {
                    comboBoxFound.Items.Add(cancion.Titulo_Cancion);
                }
            }
            else if (comboBoxFind.Text == "Top Rated")
            {
                panelFinderUser.Visible = false;
                panelButttons.Visible = true;
                canciones = finder1.ordenarPorNota(Global.allSongs);
                foreach (Cancion cancion in canciones)
                {
                    comboBoxFound.Items.Add(cancion.Titulo_Cancion);
                }
            }
            else if (comboBoxFind.Text == "User")
            {
                panelMostrar.Visible = false;
                comboBoxUsuarios.Items.Clear();
                string busqueda = textBoxFind.Text;
                panelFinderUser.Visible = true;
                IFormatter formatter3 = new BinaryFormatter();
                Stream stream3 = new FileStream("Registrados.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
                Dictionary<int, List<string>> registrados = formatter3.Deserialize(stream3) as Dictionary<int, List<string>>;
                stream3.Close();
                foreach (List<string> value in registrados.Values)
                {
                    if (value[0].Contains(busqueda) == true)
                    {
                        
                        comboBoxUsuarios.Items.Add(value[0]);
                        
                    }
                }


                panelButttons.Visible = false;


                panelFinderUser.Visible = true;


            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Form1.MainMenu.Show();
            panelFinderUser.Visible = false;
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
                        listBoxMetadata.Items.Add("Launching date: " + cancion.Fecha_Lanzamiento);
                        
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

        private void buttonFollow_Click(object sender, EventArgs e)
        {
            if (comboBoxFind.Text == "User")
            {


                IFormatter formatter3 = new BinaryFormatter();
                Stream stream3 = new FileStream("Registrados.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
                Dictionary<int, List<string>> registrados = formatter3.Deserialize(stream3) as Dictionary<int, List<string>>;
                stream3.Close();
                IFormatter formatter2 = new BinaryFormatter();
                Stream stream2 = new FileStream("nombre.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
                List<string> nombre = formatter2.Deserialize(stream2) as List<string>;
                stream2.Close();
                string elegido = comboBoxUsuarios.Text;
                foreach (List<string> data in registrados.Values)
                {
                    if (elegido == data[0])
                    {
                        int a = Convert.ToInt32(data[8]);
                        a += 1;
                        string b = Convert.ToString(a);
                        data[8] = b;
                        foreach (List<string> value in registrados.Values)
                        {
                            if (nombre[0] == value[0])
                            {
                                a = Convert.ToInt32(value[10]);
                                a += 1;

                                b = Convert.ToString(a);
                                value[10] = b;

                            }
                        }
                        MessageBox.Show("You are now Following a new User!");
                    }
                }
                IFormatter formatter1 = new BinaryFormatter();
                Stream stream1 = new FileStream("Registrados.bin", FileMode.Create, FileAccess.Write, FileShare.None);
                formatter1.Serialize(stream1, registrados);
                stream1.Close();
            }
            else if (comboBoxFind.Text == "Playlist")
            {
                Global.UserNow.seguidosBanda.Add(comboBoxUsuarios.Text);
            }
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            Form1.VideoPlayer.Show();
            Form1.Finderr.Hide();
        }

        private void buttonPlay_Click_1(object sender, EventArgs e)
        {
            Form1.VideoPlayer.Show();
            Form1.Finderr.Hide();
        }
    }
}
