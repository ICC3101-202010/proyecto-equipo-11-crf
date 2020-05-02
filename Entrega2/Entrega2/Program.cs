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
        static void Main(string[] args)
        {
            
            string path = @"C:\Users\Francisco\Desktop\proyecto-equipo-11-crf\14. Bad Bunny Ft. Jowell & Randy, Nengo Flow - Safaera.mp3";
            Cancion song = new Cancion(path);
            Caratula nueva = new Caratula();
            nueva.Show_carat();
            Console.WriteLine(song.Show_info(song));
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
