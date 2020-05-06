using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using WMPLib;

namespace Entrega2
{
    class Reproductor
    {
        
        public void reproducirCancion(WindowsMediaPlayer sonido,Cancion cancion)
        {
            try
            {
                sonido.URL = cancion.Path;
                sonido.controls.play();
                string n = null;
                while (n != "3")
                {
                    Console.WriteLine("1-pausa 2-contiuar 3-salir");
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
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("Error: "+ex.Message);
            }
            

        }
        

    }
}
