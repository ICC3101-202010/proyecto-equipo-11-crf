using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Entrega2;

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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            //Console.WriteLine(Path.Combine(AppDomain.CurrentDomain.BaseDirectory));
            Cancion cancion1 = new Cancion(@"C:\Users\corre\OneDrive\Escritorio\Entrega3Bien\proyecto-equipo-11-crf\Biblioteca\01 - Milky Chance - Blossom 2.mp3");

        }
    }
}
