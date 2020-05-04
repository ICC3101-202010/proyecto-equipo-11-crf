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
                
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("Error: "+ex.Message);
            }
            

        }
     
    }
}
