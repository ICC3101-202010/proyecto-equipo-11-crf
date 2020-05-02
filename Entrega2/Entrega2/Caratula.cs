using System;
using TagLib;
using System.Drawing;
using System.IO;
using TagLib;
using System.Drawing.Imaging;

namespace Entrega2
{
    public class Caratula
    {
        private string direccion;
        private Bitmap imagen;
        
        public string Direccion { get => direccion; set => direccion = value; }
        public Bitmap Imagen { get => imagen; set => imagen = value; }

        public Caratula()
        {
            


        }

        public void Show_carat() 
        {
            TagLib.File song = TagLib.File.Create(@"C:\Users\Francisco\Desktop\proyecto-equipo-11-crf\14. Bad Bunny Ft. Jowell & Randy, Nengo Flow - Safaera.mp3");
            
            MemoryStream ms = new MemoryStream(song.Tag.Pictures[0].Data.Data);
            System.Drawing.Image image = System.Drawing.Image.FromStream(ms);
            image.Save("lala.jpg", ImageFormat.Png);
            
        }
    }
}
