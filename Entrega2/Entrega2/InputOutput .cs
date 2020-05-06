using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrega2
{
    class InputOutput
    {
        public Playlist crearListaCanciones(Playlist todasCanciones)
        {

            string nombreLista;
            List<Cancion> nuevaLista = new List<Cancion>();
            Console.WriteLine("Ingrese el nombre de la nueva lista");
            nombreLista = Console.ReadLine();

            int i = 0;
            while (i != 1)
            {
                todasCanciones.mostrarCanciones();
                Console.WriteLine("Ingrese el numero de la cancion que desea agregar");
                int agregada = Convert.ToInt32(Console.ReadLine());
                nuevaLista.Add(todasCanciones.Canciones[agregada]);
                Console.WriteLine("Ingrese 1 para terminar, otro numero para continuar");
                i = Convert.ToInt32(Console.ReadLine());
            }
            Playlist nuevaPlaylist = new Playlist(nombreLista, nuevaLista, null);
            return nuevaPlaylist;

        }
    }
}
