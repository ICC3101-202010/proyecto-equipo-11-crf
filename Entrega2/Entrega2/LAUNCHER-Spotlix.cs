﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Entrega2.IO;
using WMPLib;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
namespace Entrega2
{
    
    /*class LAUNCHER_Spotlix
    {

        public LAUNCHER_Spotlix()
        {

        }
        public List<string> Loginlist { get; set; }

        public void Spotlix()
        {
            InputOutput.ConsoleWelcome();

            Reproductor reproductor = new Reproductor();
            RegistroUsuarios database = new RegistroUsuarios();
            server server = new server(database);
            EnvioMail mailSender = new EnvioMail();
            EnvioSMS smsSender = new EnvioSMS();
            Usuario user = new Usuario();

            
            WindowsMediaPlayer Player = new WindowsMediaPlayer();


            List<Cancion> todasLasCanciones = new List<Cancion>();
            todasLasCanciones = reproductor.Library();
            List<Video> todosVideos = new List<Video>();
            todosVideos = reproductor.Video_Library();
            List<Efecto> todosEfecto = new List<Efecto>();
            todosEfecto = reproductor.BibliotecaEfectos();
            List<Playlist> todasPlaylists = new List<Playlist>();
            List<Album> todosAlbum = new List<Album>();
            MediaDatabase media_database = new MediaDatabase();
            RegistroUsuarios data = new RegistroUsuarios();

            Playlist All_songs = new Playlist("Library", todasLasCanciones, null, null);
            Playlist All_videos = new Playlist("LibraryVideo", null, todosVideos, null);


            server.Registered += mailSender.OnRegistered;

            server.PasswordChanged += mailSender.OnPasswordChanged;

            server.UsernameChanged += mailSender.OnUsernameChanged;

            server.PasswordChanged += smsSender.OnPasswordChanged;

            server.UsernameChanged += smsSender.OnUsernameChanged;

            mailSender.EmailSent += user.OnEmailSent;

            user.EmailVerified += server.OnEmailVerified;


            bool exec = true;
            while (exec == true)
            {
                Console.WriteLine("1 --> Registrarse");
                Console.WriteLine("2 --> Log in");
                Console.WriteLine("3 --> Cerrar");

                string chosen = Console.ReadLine();


                if (chosen == "1")
                {
                    Console.Clear();
                    server.Registrarse();
                    exec = true;

                }




                else if (chosen == "2")
                {


                    Console.Clear();


                    try
                    {
                        List<string> server1 = server.LogIn();
                        if (server1[0] == null)
                        {

                            try
                            {
                                IFormatter formatter1 = new BinaryFormatter();
                                Stream stream1 = new FileStream("MyFile.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
                                Usuario usuario1 = formatter1.Deserialize(stream1) as Usuario;
                                stream1.Close();
                                string verificationLink = server.GenerateLink(usuario1.Username);
                                database.AddUser(new List<string>() { usuario1.Username, usuario1.Mail, usuario1.Contraseña, usuario1.privacidad, verificationLink, Convert.ToString(DateTime.Now), usuario1.Telefono, usuario1.Member, usuario1.followers });

                                Console.WriteLine("Spotflix ");
                                if (usuario1.Member == "true")
                                {
                                    string a = "0";
                                    while (a != "6")
                                    {

                                        InputOutput.Main_menu();
                                        Player.controls.stop();
                                        a = Console.ReadLine();
                                        if (a == "1")
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Home");
                                            All_songs.mostrarCanciones();
                                            Console.WriteLine("Select one");
                                            int option_chosen = Convert.ToInt32(Console.ReadLine());
                                            int count = 0;
                                            foreach (var song in All_songs.Canciones)
                                            {

                                                if (option_chosen == count)
                                                {
                                                    reproductor.reproducirCancion(Player, song);
                                                    //Action[] metodos = new Action[] { ()=>reproductor.reproducirCancion(Player, song),()=>reproductor.Show_lyrics(song,Player)};
                                                    //Parallel.Invoke(metodos);
                                                    reproductor.reproducirLista(Player, reproductor.Queue(song));
                                                    //Parallel.Invoke(() => reproductor.reproducirLista(Player, reproductor.Queue(song)), () => reproductor.Show_lyrics(song, Player));
                                                    {

                                                    }
                                                    Player.controls.pause();
                                                    break;
                                                }
                                                else
                                                {

                                                    count++;
                                                }

                                                Console.WriteLine(song.Titulo_Cancion);

                                            }



                                        }
                                        else if (a == "2")
                                        {
                                            List<Cancion> retornoBuscarCancion = new List<Cancion>();
                                            List<Video> retornoBuscarVideo = new List<Video>();

                                            Finder1 finder = new Finder1();
                                            string opcionB = "0";
                                            while (opcionB != "11")
                                            {

                                                retornoBuscarCancion.Clear();
                                                retornoBuscarVideo.Clear();
                                                InputOutput.Menu_finder();
                                                opcionB = Console.ReadLine();
                                                if (opcionB == "1")
                                                {
                                                    Console.WriteLine("Ingrese el nombre de la cancion");
                                                    string nombreCancion = Console.ReadLine();
                                                    //Cancion seleccionada = finder.buscarCancion(nombreCancion, todasLasCanciones);
                                                   // if (seleccionada != null)
                                                    {

                                                     //   retornoBuscarCancion.Add(seleccionada);


                                                    }
                                                }
                                                else if (opcionB == "2")
                                                {
                                                    Console.Write("[1]Nombre \n [2]Resolucion");
                                                    string opcionVid = Convert.ToString(Console.ReadLine());
                                                    if (opcionVid == "1")
                                                    {
                                                        Console.WriteLine("Ingrese nombre");
                                                        string nombreVideo = Console.ReadLine();
                                                        retornoBuscarVideo.Add(finder.buscarVideo(nombreVideo, todosVideos));

                                                    }
                                                    else if (opcionVid == "2")
                                                    {
                                                        Console.WriteLine("Ingrese resolucion");
                                                        string resolucion = Console.ReadLine();
                                                        finder.buscarVideoResolucion(resolucion, todosVideos);


                                                    }

                                                }
                                                else if (opcionB == "3")
                                                {
                                                    Console.WriteLine("Ingrese nombre playlist");
                                                    string nombrePlaylist = Console.ReadLine();
                                                    retornoBuscarCancion = finder.buscarPlaylist(nombrePlaylist, media_database.Playlists).Canciones;

                                                }
                                                else if (opcionB == "4")
                                                {
                                                    Console.WriteLine("Ingrese nombre Actor/Director");
                                                    string nombreActorDirector = Console.ReadLine();
                                                    retornoBuscarVideo = finder.buscarActorDirector(nombreActorDirector, todosVideos);
                                                }
                                                else if (opcionB == "5")
                                                {
                                                    Console.WriteLine("Ingrese nombre banda");
                                                    string nombreBanda = Console.ReadLine();
                                                    retornoBuscarCancion = finder.buscarArtista(nombreBanda, todasLasCanciones);
                                                    Thread.Sleep(5000);

                                                }
                                                else if (opcionB == "6")
                                                {
                                                    Console.WriteLine("Ingrese nombre Abum");
                                                    string nombreAlbum = Console.ReadLine();
                                                    retornoBuscarCancion = finder.searchAlbum(nombreAlbum, todasLasCanciones);

                                                }
                                                else if (opcionB == "7")
                                                {
                                                    Console.WriteLine("Mas reproducidas");
                                                    retornoBuscarCancion = finder.ratingReproducciones(todasLasCanciones);
                                                    Thread.Sleep(5000);
                                                }
                                                else if (opcionB == "8")
                                                {
                                                    Console.WriteLine("Mejor puntuadas");
                                                    retornoBuscarCancion = finder.ordenarPorNota(todasLasCanciones);
                                                    Thread.Sleep(5000);

                                                }
                                                else if (opcionB == "9")
                                                {
                                                    Console.WriteLine("Favoritas");
                                                    retornoBuscarCancion = user.Canciones_favoritas;
                                                    foreach (Cancion can in retornoBuscarCancion)
                                                    {
                                                        Console.WriteLine(can.Titulo_Cancion);
                                                    }
                                                }
                                                else if (opcionB == "10")
                                                {
                                                    List<string> datos = new List<string>();
                                                    Console.WriteLine("Ingrese Nombre de Usuario");
                                                    string username = Console.ReadLine();
                                                    datos = data.GetData(username);
                                                    if (username == datos[0])
                                                    {
                                                        Console.WriteLine("Te Gustaria seguir a este Usuario?");
                                                        Console.WriteLine("");
                                                        Console.WriteLine("1 --> Si ");
                                                        Console.WriteLine("2 --> No ");
                                                        string re = Console.ReadLine();
                                                        if (re == "1")
                                                        {
                                                            user.seguirUsuario(username);

                                                        }
                                                    }
                                                }

                                                if (opcionB != "11" && opcionB != "2" && opcionB != "3" && opcionB != "4")
                                                {
                                                    string op = "";
                                                    while (op != "6")
                                                    {
                                                        Console.WriteLine("1. Reproducir busqueda");
                                                        Console.WriteLine("2. Agregar a favoritos");
                                                        Console.WriteLine("3. Puntuar Cancion");
                                                        Console.WriteLine("4. Anadir a Lista");
                                                        Console.WriteLine("5. Descargar");
                                                        Console.WriteLine("6. Salir");
                                                        op = Console.ReadLine();
                                                        if (op == "1")
                                                        {
                                                            int index0 = 0;
                                                            foreach (Cancion can in retornoBuscarCancion)
                                                            {
                                                                Console.WriteLine(index0);
                                                                Console.WriteLine(can.Titulo_Cancion);
                                                                Console.WriteLine(can.Album);
                                                                Console.WriteLine(can.Banda);
                                                                index0++;
                                                            }
                                                            Console.WriteLine("Seleccione numero a reproducir");
                                                            int numero = System.Convert.ToInt32(Console.ReadLine());
                                                            reproductor.reproducirCancion(Player, retornoBuscarCancion[numero]);
                                                        }
                                                        else if (op == "2")
                                                        {
                                                            int index0 = 0;
                                                            foreach (Cancion can in retornoBuscarCancion)
                                                            {
                                                                Console.WriteLine(index0);
                                                                Console.WriteLine(can.Titulo_Cancion);
                                                                Console.WriteLine(can.Album);
                                                                Console.WriteLine(can.Banda);
                                                                index0++;
                                                            }
                                                            Console.WriteLine("Seleccione cual desea anadir a favoritos");
                                                            int numero = System.Convert.ToInt32(Console.ReadLine());
                                                            retornoBuscarCancion[numero].agregarFavoritos(user);

                                                        }
                                                        else if (op == "3")
                                                        {
                                                            int index0 = 0;
                                                            foreach (Cancion can in retornoBuscarCancion)
                                                            {
                                                                Console.WriteLine(index0);
                                                                Console.WriteLine(can.Titulo_Cancion);
                                                                Console.WriteLine(can.Album);
                                                                Console.WriteLine(can.Banda);
                                                                index0++;
                                                            }
                                                            Console.WriteLine("Seleccione cual desea puntuar");
                                                            int numero = System.Convert.ToInt32(Console.ReadLine());
                                                            retornoBuscarCancion[numero].valorarCancion();

                                                        }
                                                        else if (op == "4")
                                                        {
                                                            int index0 = 0;
                                                            foreach (Cancion can in retornoBuscarCancion)
                                                            {
                                                                Console.WriteLine(index0);
                                                                Console.WriteLine(can.Titulo_Cancion);
                                                                Console.WriteLine(can.Album);
                                                                Console.WriteLine(can.Banda);
                                                                index0++;
                                                            }
                                                            Console.WriteLine("Seleccione cual desea agregar");
                                                            int numero = System.Convert.ToInt32(Console.ReadLine());
                                                            int index = 0;
                                                            foreach (Playlist p in media_database.Playlists)
                                                            {
                                                                Console.WriteLine(index);
                                                                Console.WriteLine(p.NombrePlaylist);
                                                                index++;
                                                            }
                                                            Console.WriteLine("A que playlist la desea agregar");
                                                            int agregada = System.Convert.ToInt32(Console.ReadLine());
                                                            retornoBuscarCancion[numero].agregarAPlaylist(media_database.Playlists[agregada]);



                                                        }
                                                        else if (op == "5")
                                                        {
                                                            int index0 = 0;
                                                            foreach (Cancion can in retornoBuscarCancion)
                                                            {
                                                                Console.WriteLine(index0);
                                                                Console.WriteLine(can.Titulo_Cancion);
                                                                Console.WriteLine(can.Album);
                                                                Console.WriteLine(can.Banda);
                                                                index0++;
                                                            }
                                                            Console.WriteLine("Seleccione cual desea descargar");
                                                            int numero = System.Convert.ToInt32(Console.ReadLine());
                                                            retornoBuscarCancion[numero].descargarCancion(user);

                                                        }
                                                        else if (op == "6")
                                                        {

                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine("Opcion Invalida");
                                                        }
                                                    }




                                                }


                                            }

                                        }

                                        else if (a == "3")
                                        {
                                            Console.WriteLine("Biblioteca");
                                            string opcionC = "0";
                                            while (opcionC != "4")

                                            {
                                                InputOutput.Library_menu();
                                                opcionC = Console.ReadLine();

                                                if (opcionC == "1")
                                                {
                                                    Console.WriteLine("Ms canciones");
                                                    foreach (var song in media_database.Show_songs_by_user(todasLasCanciones, user))
                                                    {
                                                        Console.WriteLine(song.Titulo_Cancion);

                                                    }
                                                }

                                                else if (opcionC == "2")
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("Mis playlist");

                                                    foreach (var playlist in media_database.Show_playlist_by_user(todasPlaylists, user))
                                                    {
                                                        Console.WriteLine(playlist.NombrePlaylist);

                                                    }
                                                }

                                                else if (opcionC == "3")
                                                {
                                                    Console.Clear();
                                                    Console.Write("Crea tu playlist" + "\n" + "Elige un tipo" + "\n" + "[1] Canciones" + "\n" + "[2]  Video" + "\n" + "[0]  Salir");
                                                    int opcion_crear = Convert.ToInt32(Console.ReadLine());
                                                    if (opcion_crear == 1)
                                                    {
                                                        Console.Clear();

                                                        Playlist All_new_user = new Playlist("Library", todasLasCanciones, null, user.NamePerson);
                                                        reproductor.crearListaCanciones(All_new_user);
                                                        Console.WriteLine("Deseas agregar una imagen");
                                                        int image_otion = Convert.ToInt32(Console.ReadLine());
                                                        if (image_otion == 1)
                                                        {
                                                            reproductor.crearListaCanciones(All_new_user).addIamge();
                                                        }
                                                        else if (image_otion == 2)
                                                        {
                                                            continue;

                                                        }
                                                        else if (opcion_crear == 0)
                                                        {
                                                            break;
                                                        }
                                                    }





                                                }
                                                else if (opcionC == "4")
                                                {

                                                }
                                                else
                                                {
                                                    Console.WriteLine("Opcion Invalida");
                                                }
                                            }

                                        }
                                        else if (a == "4")
                                        {
                                            Console.WriteLine("Mi perfil");
                                            user.OpcionesUsuario();
                                        }
                                        else if (a == "5")
                                        {
                                            Console.WriteLine("Mixer");
                                            reproductor.mixer(todasLasCanciones, todosEfecto);

                                        }
                                        else if (a == "6")
                                        {
                                            Console.WriteLine("Log Out");
                                        }

                                        else
                                        {
                                            Console.WriteLine("Ingrese una opcion valida");
                                        }


                                    }
                                }

                                else
                                {
                                    string a = "0";
                                    while (a != "3")
                                    {
                                        if (usuario1.Member == "true")
                                        {
                                            break;
                                        }
                                        InputOutput.Main_Menu_No_Premium();
                                        Player.controls.stop();
                                        a = Console.ReadLine();
                                        if (a == "1")
                                        {
                                            Console.Clear();

                                            Console.WriteLine("Home");
                                            All_songs.mostrarCanciones();
                                            Console.WriteLine("Select one");
                                            int option_chosen = Convert.ToInt32(Console.ReadLine());
                                            int count = 0;
                                            foreach (var song in All_songs.Canciones)

                                            {

                                                if (option_chosen == count)
                                                {
                                                    reproductor.reproducirCancion(Player, song);
                                                    reproductor.reproducirLista(Player, reproductor.Queue(song));
                                                    Player.controls.pause();
                                                    break;
                                                }
                                                else
                                                {

                                                    count++;
                                                }
                                            }

                                        }
                                        else if (a == "2")
                                        {
                                            Console.WriteLine("Mi perfil");
                                            user.OpcionesUsuario();
                                        }
                                        else if (a == "3")
                                        {
                                            Console.WriteLine("Log Out");

                                        }

                                        else
                                        {
                                            Console.WriteLine("Ingrese una opcion valida");
                                        }

                                    }
                                }
                            }
                            catch (Exception ex)
                            {
                                IFormatter formatter = new BinaryFormatter();
                                Stream stream = new FileStream("MyFile.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
                                Usuario usuario1 = formatter.Deserialize(stream) as Usuario;
                                stream.Close();
                                string verificationLink = server.GenerateLink(usuario1.Username);
                                database.AddUser(new List<string>() { usuario1.Username, usuario1.Mail, usuario1.Contraseña, usuario1.privacidad, verificationLink, Convert.ToString(DateTime.Now), usuario1.Telefono, usuario1.Member, usuario1.followers });


                                Console.WriteLine("Spotflix ");
                                if (usuario1.Member == "true")
                                {
                                    string a = "0";
                                    while (a != "6")
                                    {

                                        InputOutput.Main_menu();
                                        Player.controls.stop();
                                        a = Console.ReadLine();
                                        if (a == "1")
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Home");
                                            All_songs.mostrarCanciones();
                                            Console.WriteLine("Select one");
                                            int option_chosen = Convert.ToInt32(Console.ReadLine());
                                            int count = 0;
                                            foreach (var song in All_songs.Canciones)
                                            {

                                                if (option_chosen == count)
                                                {
                                                    reproductor.reproducirCancion(Player, song);
                                                    //Action[] metodos = new Action[] { ()=>reproductor.reproducirCancion(Player, song),()=>reproductor.Show_lyrics(song,Player)};
                                                    //Parallel.Invoke(metodos);
                                                    reproductor.reproducirLista(Player, reproductor.Queue(song));
                                                    //Parallel.Invoke(() => reproductor.reproducirLista(Player, reproductor.Queue(song)), () => reproductor.Show_lyrics(song, Player));
                                                    {

                                                    }
                                                    Player.controls.pause();
                                                    break;
                                                }
                                                else
                                                {

                                                    count++;
                                                }

                                                Console.WriteLine(song.Titulo_Cancion);

                                            }



                                        }
                                        else if (a == "2")
                                        {
                                            List<Cancion> retornoBuscarCancion = new List<Cancion>();
                                            List<Video> retornoBuscarVideo = new List<Video>();

                                            Finder1 finder = new Finder1();
                                            string opcionB = "0";
                                            while (opcionB != "11")
                                            {

                                                retornoBuscarCancion.Clear();
                                                retornoBuscarVideo.Clear();
                                                InputOutput.Menu_finder();
                                                opcionB = Console.ReadLine();
                                                if (opcionB == "1")
                                                {
                                                    Console.WriteLine("Ingrese el nombre de la cancion");
                                                    string nombreCancion = Console.ReadLine();
                                                    /*Cancion seleccionada = finder.buscarCancion(nombreCancion, todasLasCanciones);
                                                    if (seleccionada != null)
                                                    {

                                                        retornoBuscarCancion.Add(seleccionada);


                                                    }*/
                                                /*}
                                                else if (opcionB == "2")
                                                {
                                                    Console.Write("[1]Nombre \n [2]Resolucion");
                                                    string opcionVid = Convert.ToString(Console.ReadLine());
                                                    if (opcionVid == "1")
                                                    {
                                                        Console.WriteLine("Ingrese nombre");
                                                        string nombreVideo = Console.ReadLine();
                                                        retornoBuscarVideo.Add(finder.buscarVideo(nombreVideo, todosVideos));

                                                    }
                                                    else if (opcionVid == "2")
                                                    {
                                                        Console.WriteLine("Ingrese resolucion");
                                                        string resolucion = Console.ReadLine();
                                                        finder.buscarVideoResolucion(resolucion, todosVideos);


                                                    }

                                                }
                                                else if (opcionB == "3")
                                                {
                                                    Console.WriteLine("Ingrese nombre playlist");
                                                    string nombrePlaylist = Console.ReadLine();
                                                    //retornoBuscarCancion = finder.buscarPlaylist(nombrePlaylist, media_database.Playlists).Canciones;

                                                }
                                                else if (opcionB == "4")
                                                {
                                                    Console.WriteLine("Ingrese nombre Actor/Director");
                                                    string nombreActorDirector = Console.ReadLine();

                                                    try
                                                    {
                                                        //retornoBuscarVideo = finder.buscarActorDirector(nombreActorDirector, todosVideos);
                                                    }
                                                    catch(Exception exep)
                                                    {
                                                        Console.WriteLine(exep.Message);
                                                    }
                                                    

                                                    //retornoBuscarVideo = finder.buscarActorDirector(nombreActorDirector, todosVideos);

                                                }
                                                else if (opcionB == "5")
                                                {
                                                    Console.WriteLine("Ingrese nombre banda");
                                                    string nombreBanda = Console.ReadLine();
                                                    retornoBuscarCancion = finder.buscarArtista(nombreBanda, todasLasCanciones);
                                                    Thread.Sleep(5000);

                                                }
                                                else if (opcionB == "6")
                                                {
                                                    Console.WriteLine("Ingrese nombre Abum");
                                                    string nombreAlbum = Console.ReadLine();
                                                    retornoBuscarCancion = finder.searchAlbum(nombreAlbum, todasLasCanciones);

                                                }
                                                else if (opcionB == "7")
                                                {
                                                    Console.WriteLine("Mas reproducidas");
                                                    retornoBuscarCancion = finder.ratingReproducciones(todasLasCanciones);
                                                    Thread.Sleep(5000);
                                                }
                                                else if (opcionB == "8")
                                                {
                                                    Console.WriteLine("Mejor puntuadas");
                                                    retornoBuscarCancion = finder.ordenarPorNota(todasLasCanciones);
                                                    Thread.Sleep(5000);

                                                }
                                                else if (opcionB == "9")
                                                {
                                                    Console.WriteLine("Favoritas");
                                                    retornoBuscarCancion = user.Canciones_favoritas;
                                                    foreach (Cancion can in retornoBuscarCancion)
                                                    {
                                                        Console.WriteLine(can.Titulo_Cancion);
                                                    }
                                                }
                                                else if (opcionB == "10")
                                                {
                                                    List<string> datos = new List<string>();
                                                    Console.WriteLine("Ingrese Nombre de Usuario");
                                                    string username = Console.ReadLine();
                                                    datos = data.GetData(username);
                                                    if (username == datos[0])
                                                    {
                                                        Console.WriteLine("Te Gustaria seguir a este Usuario?");
                                                        Console.WriteLine("");
                                                        Console.WriteLine("1 --> Si ");
                                                        Console.WriteLine("2 --> No ");
                                                        string re = Console.ReadLine();
                                                        if (re == "1")
                                                        {
                                                            user.seguirUsuario(username);

                                                        }
                                                    }
                                                }

                                                if (opcionB != "11" && opcionB != "2" && opcionB != "3" && opcionB != "4")
                                                {
                                                    string op = "";
                                                    while (op != "6")
                                                    {
                                                        Console.WriteLine("1. Reproducir busqueda");
                                                        Console.WriteLine("2. Agregar a favoritos");
                                                        Console.WriteLine("3. Puntuar Cancion");
                                                        Console.WriteLine("4. Anadir a Lista");
                                                        Console.WriteLine("5. Descargar");
                                                        Console.WriteLine("6. Salir");
                                                        op = Console.ReadLine();
                                                        if (op == "1")
                                                        {
                                                            int index0 = 0;
                                                            foreach (Cancion can in retornoBuscarCancion)
                                                            {
                                                                Console.WriteLine(index0);
                                                                Console.WriteLine(can.Titulo_Cancion);
                                                                Console.WriteLine(can.Album);
                                                                Console.WriteLine(can.Banda);
                                                                index0++;
                                                            }
                                                            Console.WriteLine("Seleccione numero a reproducir");
                                                            int numero = System.Convert.ToInt32(Console.ReadLine());
                                                            reproductor.reproducirCancion(Player, retornoBuscarCancion[numero]);
                                                        }
                                                        else if (op == "2")
                                                        {
                                                            int index0 = 0;
                                                            foreach (Cancion can in retornoBuscarCancion)
                                                            {
                                                                Console.WriteLine(index0);
                                                                Console.WriteLine(can.Titulo_Cancion);
                                                                Console.WriteLine(can.Album);
                                                                Console.WriteLine(can.Banda);
                                                                index0++;
                                                            }
                                                            Console.WriteLine("Seleccione cual desea anadir a favoritos");
                                                            int numero = System.Convert.ToInt32(Console.ReadLine());
                                                            retornoBuscarCancion[numero].agregarFavoritos(user);

                                                        }
                                                        else if (op == "3")
                                                        {
                                                            int index0 = 0;
                                                            foreach (Cancion can in retornoBuscarCancion)
                                                            {
                                                                Console.WriteLine(index0);
                                                                Console.WriteLine(can.Titulo_Cancion);
                                                                Console.WriteLine(can.Album);
                                                                Console.WriteLine(can.Banda);
                                                                index0++;
                                                            }
                                                            Console.WriteLine("Seleccione cual desea puntuar");
                                                            int numero = System.Convert.ToInt32(Console.ReadLine());
                                                            retornoBuscarCancion[numero].valorarCancion();

                                                        }
                                                        else if (op == "4")
                                                        {
                                                            int index0 = 0;
                                                            foreach (Cancion can in retornoBuscarCancion)
                                                            {
                                                                Console.WriteLine(index0);
                                                                Console.WriteLine(can.Titulo_Cancion);
                                                                Console.WriteLine(can.Album);
                                                                Console.WriteLine(can.Banda);
                                                                index0++;
                                                            }
                                                            Console.WriteLine("Seleccione cual desea agregar");
                                                            int numero = System.Convert.ToInt32(Console.ReadLine());
                                                            int index = 0;
                                                            foreach (Playlist p in media_database.Playlists)
                                                            {
                                                                Console.WriteLine(index);
                                                                Console.WriteLine(p.NombrePlaylist);
                                                                index++;
                                                            }
                                                            Console.WriteLine("A que playlist la desea agregar");
                                                            int agregada = System.Convert.ToInt32(Console.ReadLine());
                                                            retornoBuscarCancion[numero].agregarAPlaylist(media_database.Playlists[agregada]);



                                                        }
                                                        else if (op == "5")
                                                        {
                                                            int index0 = 0;
                                                            foreach (Cancion can in retornoBuscarCancion)
                                                            {
                                                                Console.WriteLine(index0);
                                                                Console.WriteLine(can.Titulo_Cancion);
                                                                Console.WriteLine(can.Album);
                                                                Console.WriteLine(can.Banda);
                                                                index0++;
                                                            }
                                                            Console.WriteLine("Seleccione cual desea descargar");
                                                            int numero = System.Convert.ToInt32(Console.ReadLine());
                                                            retornoBuscarCancion[numero].descargarCancion(user);

                                                        }
                                                        else if (op == "6")
                                                        {

                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine("Opcion Invalida");
                                                        }
                                                    }




                                                }


                                            }

                                        }

                                        else if (a == "3")
                                        {
                                            Console.WriteLine("Biblioteca");
                                            string opcionC = "0";
                                            while (opcionC != "4")

                                            {
                                                InputOutput.Library_menu();
                                                opcionC = Console.ReadLine();

                                                if (opcionC == "1")
                                                {
                                                    Console.WriteLine("Ms canciones");
                                                    foreach (var song in media_database.Show_songs_by_user(todasLasCanciones, user))
                                                    {
                                                        Console.WriteLine(song.Titulo_Cancion);

                                                    }
                                                }

                                                else if (opcionC == "2")
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("Mis playlist");

                                                    foreach (var playlist in media_database.Show_playlist_by_user(todasPlaylists, user))
                                                    {
                                                        Console.WriteLine(playlist.NombrePlaylist);

                                                    }
                                                }

                                                else if (opcionC == "3")
                                                {
                                                    Console.Clear();
                                                    Console.Write("Crea tu playlist" + "\n" + "Elige un tipo" + "\n" + "[1] Canciones" + "\n" + "[2]  Video" + "\n" + "[0]  Salir");
                                                    int opcion_crear = Convert.ToInt32(Console.ReadLine());
                                                    if (opcion_crear == 1)
                                                    {
                                                        Console.Clear();

                                                        Playlist All_new_user = new Playlist("Library", todasLasCanciones, null, user.NamePerson);
                                                        reproductor.crearListaCanciones(All_new_user);
                                                        Console.WriteLine("Deseas agregar una imagen");
                                                        int image_otion = Convert.ToInt32(Console.ReadLine());
                                                        if (image_otion == 1)
                                                        {
                                                            reproductor.crearListaCanciones(All_new_user).addIamge();
                                                        }
                                                        else if (image_otion == 2)
                                                        {
                                                            continue;

                                                        }
                                                        else if (opcion_crear == 0)
                                                        {
                                                            break;
                                                        }
                                                    }





                                                }
                                                else if (opcionC == "4")
                                                {

                                                }
                                                else
                                                {
                                                    Console.WriteLine("Opcion Invalida");
                                                }
                                            }

                                        }
                                        else if (a == "4")
                                        {
                                            Console.WriteLine("Mi perfil");
                                            user.OpcionesUsuario();
                                        }
                                        else if (a == "5")
                                        {
                                            Console.WriteLine("Mixer");
                                            reproductor.mixer(todasLasCanciones, todosEfecto);

                                        }
                                        else if (a == "6")
                                        {
                                            Console.WriteLine("Log Out");
                                        }

                                        else
                                        {
                                            Console.WriteLine("Ingrese una opcion valida");
                                        }


                                    }
                                }

                                else
                                {
                                    string a = "0";
                                    while (a != "3")
                                    {
                                        if (usuario1.Member == "true")
                                        {
                                            break;
                                        }
                                        InputOutput.Main_Menu_No_Premium();
                                        Player.controls.stop();
                                        a = Console.ReadLine();
                                        if (a == "1")
                                        {
                                            Console.Clear();

                                            Console.WriteLine("Home");
                                            All_songs.mostrarCanciones();
                                            Console.WriteLine("Select one");
                                            int option_chosen = Convert.ToInt32(Console.ReadLine());
                                            int count = 0;
                                            foreach (var song in All_songs.Canciones)

                                            {

                                                if (option_chosen == count)
                                                {
                                                    reproductor.reproducirCancion(Player, song);
                                                    reproductor.reproducirLista(Player, reproductor.Queue(song));
                                                    Player.controls.pause();
                                                    break;
                                                }
                                                else
                                                {

                                                    count++;
                                                }
                                            }

                                        }
                                        else if (a == "2")
                                        {
                                            Console.WriteLine("Mi perfil");
                                            user.OpcionesUsuario();
                                        }
                                        else if (a == "3")
                                        {
                                            Console.WriteLine("Log Out");

                                        }

                                        else
                                        {
                                            Console.WriteLine("Ingrese una opcion valida");
                                        }

                                    }
                                }
                            }
                        }
                        else
                        {

                            Console.WriteLine("[!] ERROR: " + server1 + "\n");

                        }
                    }
                    catch (Exception ex)
                    {
                        Console.Clear();
                        server.Registrarse();
                        exec = true;
                    }
                    


                }


                else if (chosen == "3")
                {
                    exec = false;
                    Console.Clear();
                    break;
                }

                else
                {
                    exec = true;
                    Console.WriteLine("Opcion Invalida");
                    Thread.Sleep(1000);
                }

            }

        }




    }*/
}


