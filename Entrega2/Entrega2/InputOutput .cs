using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrega2.IO
{
    public static class InputOutput
    {
<<<<<<< HEAD

       
=======
        public static string ShowOptions(List<string> options)
        {
            int i = 0;
            Console.WriteLine("\n\nSelecciona una opcion:");
            foreach (string option in options)
            {
                Console.WriteLine(Convert.ToString(i) + ". " + option);
                i += 1;
            }
            return options[Convert.ToInt16(Console.ReadLine())];
        }
>>>>>>> 8ff71925ba76b98f108d4c6baefe8e5d2f2f1637
    }
}
