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
            textBoxFind.Text = textBoxFind.Text.ToLower();

            List<Cancion> canciones;

            panelMostrar.Visible = true;
            if (comboBoxFind.Text == "Song")
            {
                panelFinderUser.Visible = false;
                panelButttons.Visible = true;
                canciones = finder1.buscarCancion(textBoxFind.Text, Global.allSongs);
                List<Cancion> can = canciones.Distinct().ToList();
                foreach (Cancion cancion in can)
                {
                    comboBoxFound.Items.Add(cancion.Titulo_Cancion);
                }


            }
            else if (comboBoxFind.Text == "Video")
            {
                panelFinderUser.Visible = false;
                List<Video> videos = finder1.buscarVideo(textBoxFind.Text, Form1.Reproductor.Video_Library());
                videos = videos.Distinct().ToList();
                foreach (Video video in videos)
                {
                    comboBoxFound.Items.Add(video.NameVideo);
                }
                panelButttons.Visible = false;
            }
            else if (comboBoxFind.Text == "Playlist")
            {
                comboBoxUsuarios.Items.Clear();
                List<string> Repetidas = new List<string>();
                panelFinderUser.Visible = true;
                label2.Visible = false;
                panelMostrar.Visible = false;
                List<Playlist> playlists = finder1.buscarPlaylist(textBoxFind.Text, Global.allPlaylists);
                playlists = playlists.Distinct().ToList();
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
                panelMostrar.Visible = false;
                panelButttons.Visible = false;
                comboBoxUsuarios.Items.Clear();
                canciones = finder1.buscarArtista(textBoxFind.Text, Global.allSongs);
                canciones= canciones.Distinct().ToList();
                foreach (Cancion cancion in canciones)
                {
                    Repetidas.Add(cancion.Banda);
                }
                List<string> noRepetidas = Repetidas.Distinct().ToList();
                foreach (string can in noRepetidas)
                {
                    comboBoxUsuarios.Items.Add(can);
                }
            }

            else if (comboBoxFind.Text == "Album")
            {
                List<string> Repetidas = new List<string>();
                label2.Visible = false;
                panelFinderUser.Visible = true;
                panelButttons.Visible = false;
                panelMostrar.Visible = false;
                canciones = finder1.searchAlbum(textBoxFind.Text, Global.allSongs);
                canciones= canciones.Distinct().ToList();
                foreach (Cancion cancion in canciones)
                {
                    Repetidas.Add(cancion.Album);

                }
                List<string> noRepetidas = Repetidas.Distinct().ToList();
                foreach (string can in noRepetidas)
                {
                    comboBoxUsuarios.Items.Add(can);
                }
            }
            else if (comboBoxFind.Text == "Top Streamed")
            {
                panelFinderUser.Visible = false;
                panelButttons.Visible = true;
                canciones = finder1.ratingReproducciones(Global.allSongs);
                canciones= canciones.Distinct().ToList();
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
                canciones= canciones.Distinct().ToList();
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
                List<Usuario> registrados = formatter3.Deserialize(stream3) as List<Usuario>;
                stream3.Close();
                List<Usuario> usuarios = finder1.buscar_usuario(busqueda, registrados);
                usuarios = usuarios.Distinct().ToList();
                foreach (Usuario value in usuarios)
                {
                   comboBoxUsuarios.Items.Add(value.Username);
                }
                


                panelButttons.Visible = false;


                panelFinderUser.Visible = true;


            }
            else if (comboBoxFind.Text == "All")
            {
                panelFinderUser.Visible = false;
                panelButttons.Visible = true;
                canciones = finder1.buscarCancion(textBoxFind.Text, Global.allSongs);
                List<Cancion> can = canciones.Distinct().ToList();
                foreach (Cancion cancion in can)
                {
                    comboBoxFound.Items.Add(cancion.Titulo_Cancion);
                }
                List<Video> videos = finder1.buscarVideo(textBoxFind.Text, Form1.Reproductor.Video_Library());
                videos = videos.Distinct().ToList();
                foreach (Video video in videos)
                {
                    comboBoxFound.Items.Add(video.NameVideo);
                }
                List<Playlist> playlists = finder1.buscarPlaylist(textBoxFind.Text, Global.allPlaylists);
                playlists = playlists.Distinct().ToList();
                foreach (Playlist playlist in playlists)
                {
                    comboBoxFound.Items.Add(playlist.NombrePlaylist);
                }
                canciones = finder1.buscarArtista(textBoxFind.Text, Global.allSongs);
                canciones = canciones.Distinct().ToList();
                foreach (Cancion cancion in canciones)
                {
                    comboBoxFound.Items.Add(cancion.Titulo_Cancion);
                }
                canciones = finder1.searchAlbum(textBoxFind.Text, Global.allSongs);
                canciones = canciones.Distinct().ToList();
                foreach (Cancion cancion in canciones)
                {
                    comboBoxFound.Items.Add(cancion.Titulo_Cancion);

                }
                List<object> final = new List<object>();
                foreach (var item in comboBoxFound.Items)
                {
                    final.Add(item);
                }
                final = final.Distinct().ToList();
                comboBoxFound.Items.Clear();
                foreach (var item in final)
                {
                    comboBoxFound.Items.Add(item);
                }

            }
            else if (comboBoxFind.Text == "By Rating")
            {
                panelByRating.Visible = true;
                panelMostrar.Visible = true;
            }
            else if (comboBoxFind.Text == "By Size")
            {
                panelByRating.Visible = true;
                panelMostrar.Visible = true;
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
            foreach (Cancion cancion in Global.allSongs)
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
            if (panelRate.Visible == false)
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

            if (puntuation < 0 || puntuation > 5)
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
            if (panelMetadata.Visible == false)
            {
                panelMetadata.Visible = true;
                foreach (Cancion cancion in Global.allSongs)
                {
                    if (cancion.Titulo_Cancion == comboBoxFound.Text)
                    {
                        listBoxMetadata.Items.Add("Title: " + cancion.Titulo_Cancion);
                        listBoxMetadata.Items.Add("Band: " + cancion.Banda);
                        listBoxMetadata.Items.Add("Genre: " + cancion.Genero);
                        listBoxMetadata.Items.Add("Album: " + cancion.Album);
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
                List<Usuario> registrados = formatter3.Deserialize(stream3) as List<Usuario>;
                stream3.Close();
                IFormatter formatter2 = new BinaryFormatter();
                Stream stream2 = new FileStream("nombre.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
                List<string> nombre = formatter2.Deserialize(stream2) as List<string>;
                stream2.Close();
                string elegido = comboBoxUsuarios.Text;
                foreach (Usuario data in registrados)
                {
                    if (elegido == data.Username)
                    {
                        //Global.UserNow.SeguidosUsuarios.Add(data);
                        
                        int a = Convert.ToInt32(data.followers);
                        a += 1;
                        string b = Convert.ToString(a);
                        
                        data.followers = b;
                        foreach (Usuario value in registrados)
                        {
                            if (nombre[0] == value.Username)
                            {
                                //Global.UserNow.MeSiguenUsuarios1.Add(value);
                                a = Convert.ToInt32(value.following);
                                a += 1;

                                b = Convert.ToString(a);
                                
                                value.following = b;
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
            else if (comboBoxFind.Text == "Band")
            {
                Global.UserNow.seguidosBanda.Add(comboBoxUsuarios.Text);
                MessageBox.Show("You are now Following a new Band!");
            }
            else if (comboBoxFind.Text == "Playlist")
            {
                Global.UserNow.seguidosPlaylist.Add(comboBoxUsuarios.Text);
                MessageBox.Show("You are now Following a new Playlist!");
            }
            else if (comboBoxFind.Text == "Album")
            {
                try
                {
                    Global.UserNow.seguidosAlbum.Add(comboBoxUsuarios.Text);
                }
                catch(Exception ex)
                {

                }
                Global.UserNow.seguidosAlbum.Add(comboBoxUsuarios.Text);
                MessageBox.Show("You are now Following a new Album!");
            }
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            Form1.VideoPlayer.Show();
            Form1.Finderr.Hide();
        }

        private void buttonPlay_Click_1(object sender, EventArgs e)
        {
            foreach(Cancion can in Form1.Reproductor.Library())
            {
                if (comboBoxFound.Text == can.Titulo_Cancion)
                {
                    Form1.Player.URL = can.path;
                    Form1.Player.controls.play();
                }
            }

        }

        private void buttonMayor_Click(object sender, EventArgs e)
        {
            if (comboBoxFind.Text == "By Rating")
            {
                comboBoxFound.Items.Clear();
                List<Cancion> ByRating = new List<Cancion>();
                foreach (Cancion can in Global.allSongs)
                {
                    if (can.Rating > Int32.Parse(textBoxFind.Text))
                    {
                        ByRating.Add(can);
                        comboBoxFound.Items.Add(can.Titulo_Cancion);
                    }
                }
            }
            else
            {
                comboBoxFound.Items.Clear();
                List<Cancion> BySize = new List<Cancion>();
                List<Video> BySize2 = new List<Video>();
                foreach (Cancion can in Global.allSongs)
                {
                    long size = new System.IO.FileInfo(can.path).Length;
                    if (size > Int32.Parse(textBoxFind.Text))
                    {
                        BySize.Add(can);
                        comboBoxFound.Items.Add(can.Titulo_Cancion);
                    }
                }
                foreach (Video vid in Global.allVideos)
                {
                    long size = new System.IO.FileInfo(vid.Path).Length;
                    if (size > Int32.Parse(textBoxFind.Text))
                    {
                        BySize2.Add(vid);
                        comboBoxFound.Items.Add(vid.NameVideo);
                    }
                }


            }

        }

        private void buttonIgual_Click(object sender, EventArgs e)
        {
            comboBoxFound.Items.Clear();
            if (comboBoxFind.Text == "By Rating")
            {
                List<Cancion> ByRating = new List<Cancion>();
                foreach (Cancion can in Global.allSongs)
                {
                    if (can.Rating == Int32.Parse(textBoxFind.Text))
                    {
                        ByRating.Add(can);
                        comboBoxFound.Items.Add(can.Titulo_Cancion);
                    }
                }
            }
            else
            {
                comboBoxFound.Items.Clear();
                List<Cancion> BySize = new List<Cancion>();
                List<Video> BySize2 = new List<Video>();
                foreach (Cancion can in Global.allSongs)
                {
                    long size = new System.IO.FileInfo(can.path).Length;
                    if (size == Int32.Parse(textBoxFind.Text))
                    {
                        BySize.Add(can);
                        comboBoxFound.Items.Add(can.Titulo_Cancion);
                    }
                }
                foreach (Video vid in Global.allVideos)
                {
                    long size = new System.IO.FileInfo(vid.Path).Length;
                    if (size == Int32.Parse(textBoxFind.Text))
                    {
                        BySize2.Add(vid);
                        comboBoxFound.Items.Add(vid.NameVideo);
                    }
                }


            }

        }

        private void buttonMenor_Click(object sender, EventArgs e)
        {
            comboBoxFound.Items.Clear();
            if (comboBoxFind.Text == "By Rating")
            {
                List<Cancion> ByRating = new List<Cancion>();
                foreach (Cancion can in Global.allSongs)
                {
                    if (can.Rating < Int32.Parse(textBoxFind.Text))
                    {
                        ByRating.Add(can);
                        comboBoxFound.Items.Add(can.Titulo_Cancion);
                    }
                }
            }
            else
            {
                comboBoxFound.Items.Clear();
                List<Cancion> BySize = new List<Cancion>();
                List<Video> BySize2 = new List<Video>();
                foreach (Cancion can in Global.allSongs)
                {
                    long size = new System.IO.FileInfo(can.path).Length;
                    if (size < Int32.Parse(textBoxFind.Text))
                    {
                        BySize.Add(can);
                        comboBoxFound.Items.Add(can.Titulo_Cancion);
                    }
                }
                foreach(Video vid in Global.allVideos)
                {
                    long size = new System.IO.FileInfo(vid.Path).Length;
                    if (size < Int32.Parse(textBoxFind.Text))
                    {
                        BySize2.Add(vid);
                        comboBoxFound.Items.Add(vid.NameVideo);
                    }
                }

            }
            
        }

        private void buttonLyrics_Click(object sender, EventArgs e)
        {
            foreach (Cancion cancion in Global.allSongs)
            {
                if (cancion.Titulo_Cancion == comboBoxFound.Text)
                {
                    if (cancion.Letra != null)
                    {
                        MessageBox.Show(cancion.Letra);
                    }

                    else
                    {
                        MessageBox.Show("No Lyrics added to the Song");
                    }

                }
            }

        }
    }
}
