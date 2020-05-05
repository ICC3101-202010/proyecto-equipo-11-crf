using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMPLib;


namespace Entrega2
{
    class Program
    {
        /*static void Main(string[] args)
        {
            Reproductor reproductor = new Reproductor();
            WindowsMediaPlayer sonido = new WindowsMediaPlayer();
            
            

            string path = @"C:\Users\corre\OneDrive\Escritorio\P.O.O. 20-01\WIN_20200428_18_11_26_Pro.mp4";
            sonido.URL = path;
            sonido.openPlayer(path);
            
            Cancion song = new Cancion(path);
            Caratula nueva = new Caratula();
            //nueva.Show_carat(song);
            //Console.WriteLine(song.Show_info(song));
            reproductor.reproducirCancion(sonido,song);
            Console.ReadLine();
            
            
            /*WindowsMediaPlayer sonido;
            

            try
            {
                sonido = new WindowsMediaPlayer();
             


                sonido.URL = @"C:\Users\corre\OneDrive\Escritorio\P.O.O. 20-01\Safaera-BadBunny.mp3";
                sonido.controls.play();
                
                string n = null;
                while (n != "5")
                {
                    Console.WriteLine("1-pausa 2-contiuar 5-salir");
                    n = Console.ReadLine();
                    if (n == "1")
                    {
                        sonido.controls.pause();

                    }
                    if (n == "2")
                    {
                        double tiempo = sonido.controls.currentPosition;
                        sonido.controls.currentPosition = tiempo;
                        sonido.controls.play();
                    }

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error. " + ex.Message);
            }*/

        }
    }
}
