using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrega2.IO
{
    public static class InputOutput
    {
    
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
        public static void ConsoleWelcome()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("\n--S P O T L I X--");
            Console.ResetColor();
        }
        public static void ConsoleExit()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("\nGoodbye!");
            Console.ResetColor();
      
        
        }

        public static void Main_menu()
        {
            Console.WriteLine("1- Reproductor");
            Console.WriteLine("2- Buscar");
            Console.WriteLine("3- Biblioteca");
            Console.WriteLine("4- Mi perfil");
            Console.WriteLine("5- Salir");

        }

        public static void Menu_finder() 
        {
            Console.WriteLine("Buscar");
            Console.WriteLine("1-Cancion");
            Console.WriteLine("2-Video");
            Console.WriteLine("3-Playlist");
            Console.WriteLine("4-Actor/Director");
            Console.WriteLine("5-Banda");
            Console.WriteLine("6-Album");
            Console.WriteLine("7-Mas escuchadas");
            Console.WriteLine("8-Mejor puntuadas");
            Console.WriteLine("9-Salir");

        }

    }   
}
