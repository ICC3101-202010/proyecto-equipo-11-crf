using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

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
            Console.Clear();
            Console.WriteLine("1- HOME");
            Console.WriteLine("2- Buscar");
            Console.WriteLine("3- Biblioteca");
            Console.WriteLine("4- Mi perfil");
            Console.WriteLine("5- Log Out");

        }

        public static void Main_Menu_No_Premium()
        {
            Console.WriteLine("Aun No eres un Miembro Premium de Spotflix!");
            Console.WriteLine("");
            Console.WriteLine("Por el Momento solo podras reproducir canciones Aleatoriamente...");
            Console.WriteLine("");
            Console.WriteLine("Hazte Premium en la seccion (Mi Perfil) para disfrutar de las canciones que quieres!");
            Thread.Sleep(6000);
            Console.Clear();
            Console.WriteLine("1- Reproductor");
            Console.WriteLine("2- Mi perfil");
            Console.WriteLine("3- Log Out");
        }

        public static void Menu_finder() 
        {
            Console.Clear();
            Console.WriteLine("Buscar");
            Console.WriteLine("1-Cancion");
            Console.WriteLine("2-Video");
            Console.WriteLine("3-Playlist");
            Console.WriteLine("4-Actor/Director");
            Console.WriteLine("5-Banda");
            Console.WriteLine("6-Album");
            Console.WriteLine("7-Mas escuchadas");
            Console.WriteLine("8-Mejor puntuadas");
            Console.WriteLine("9-Favoritas");
            Console.WriteLine("10.Salir");
                
              


        }
        public static void Library_menu()
        {
            Console.Clear();
            Console.WriteLine("1- Ver mis playlist");
            Console.WriteLine("2- Ver mis canciones");
            Console.WriteLine("3- Crear playlist");
            Console.WriteLine("4- Retroceder");
            

        }
    }   
}
