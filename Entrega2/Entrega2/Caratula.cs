using System;
using TagLib;
using System.Drawing;
using System.IO;
using System.Drawing.Imaging;


namespace Entrega2
{
    public class Caratula
    {
        private string direccion;
        private Bitmap imagen;
        
        public string Direccion { get => direccion; set => direccion = value; }
        public Bitmap Imagen { get => imagen; set => imagen = value; }

        public Caratula(Cancion song)
        {
            
            var mStream = new MemoryStream();
            var firstPicture = song.Pre_caratula;
            if (firstPicture != null)
            {
                Console.WriteLine("Caarataula");
                byte[] pData = firstPicture.Data.Data;
                mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
                var bm = new Bitmap(mStream, false);
                Image foto = bm;
                foto.Save(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "../../../../Biblioteca/lala.jpeg"), ImageFormat.Jpeg);
            }
            else
            {
                // set "no cover" image
            }


        }

        public void Show_carat(Cancion cancion) 
        {
            TagLib.File song = TagLib.File.Create(cancion.Path);

            //falta implementar para que muestre imagen
            
        }
    }
}
