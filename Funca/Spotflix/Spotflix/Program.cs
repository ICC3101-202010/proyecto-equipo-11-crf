using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Entrega2;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace Spotflix
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            List<string> nombre = new List<string>();
            string name = "";
            nombre.Add(name);
            IFormatter formatter1 = new BinaryFormatter();
            Stream stream1 = new FileStream("nombre.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            formatter1.Serialize(stream1, nombre);
            stream1.Close();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            //Console.WriteLine(Path.Combine(AppDomain.CurrentDomain.BaseDirectory));
            //Cancion cancion1 = new Cancion(@"C:\Users\corre\OneDrive\Escritorio\Entrega3Bien\proyecto-equipo-11-crf\Biblioteca\01 - Milky Chance - Blossom 2.mp3");
            //Global.allSongs.Add(cancion1);
        }
    }
}
