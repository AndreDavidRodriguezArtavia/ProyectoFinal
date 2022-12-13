using Entidades;
using LogicadeJuego;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;

namespace ProyectoFinalAndreRodriguez
{
    internal class Program
    {
        static Logica LogicadeJuego = new Logica();




        static void Main(string[] args)
        {
            int SeleccionDelUsuario = 0;
            
            // Opcion para enseñar la portada
            MostrarlaPortada();

            // se va a mostrar las opciones que se va a tener para que el jugador eliga cual quiere

            Opciones();

            // Cliclo (Gameloop)
            while (SeleccionDelUsuario != 4)
            {
               // Indicador de gane para el jugador 
                if (LogicadeJuego.datosJuego.nivelActual == 12)
                {
                    Console.WriteLine("has alcanzado el nivel final y lo has superado felicidades has terminado el juego muchas gracias por participar");
                    Console.ReadLine();
                    MostrarlaPortada();
                    Opciones();
                }
  
                //Manera para obtener la escogencia del jugador 

                SeleccionDelUsuario = CapturarNumero();

                // selecciones posibles junto a las desiciones del jugador
                if (SeleccionDelUsuario == 1)
                {
                    // cuando se escoge 1 se comienza el juego
                    Console.WriteLine("Has escogido jugar seras enviado al nivel corresondiente");
                    Console.ReadLine();
                    Comienzodeljuego();
                }
                else if (SeleccionDelUsuario == 2)
                {
                    // cuando se escoge 2 se mostraran las instruciones
                    Instrucciones();
                }
                else if (SeleccionDelUsuario == 3)
                {
                    // cuando se escogue 3 se mostraran los creditos
                    Creditos();
                }
                else if (SeleccionDelUsuario == 4)
                {
                    // cuando el jugador escoge 4 sera para salir del juego
                    Console.WriteLine("  _   _   _     _   _   _   _   _   _   _   _     _   _   _   _   _     _   _   _     _   _   _   _   _  \r\n / \\ / \\ / \\   / \\ / \\ / \\ / \\ / \\ / \\ / \\ / \\   / \\ / \\ / \\ / \\ / \\   / \\ / \\ / \\   / \\ / \\ / \\ / \\ / \\ \r\n( h | a | s ) ( e | s | c | o | g | i | d | o ) ( s | a | l | i | r ) ( d | e | l ) ( j | u | e | g | o )\r\n \\_/ \\_/ \\_/   \\_/ \\_/ \\_/ \\_/ \\_/ \\_/ \\_/ \\_/   \\_/ \\_/ \\_/ \\_/ \\_/   \\_/ \\_/ \\_/   \\_/ \\_/ \\_/ \\_/ \\_/");
                    Console.ReadLine();
                }
            }
        }

        // metodo para mostrar las instruciones
        static public void Instrucciones()
        {
            Console.WriteLine("    ____           __                  _                              __     __     _                      \r\n   /  _/___  _____/ /________  _______(_)___  ____  ___  _____   ____/ /__  / /    (_)_  _____  ____ _____ \r\n   / // __ \\/ ___/ __/ ___/ / / / ___/ / __ \\/ __ \\/ _ \\/ ___/  / __  / _ \\/ /    / / / / / _ \\/ __ `/ __ \\\r\n _/ // / / (__  ) /_/ /  / /_/ / /__/ / /_/ / / / /  __(__  )  / /_/ /  __/ /    / / /_/ /  __/ /_/ / /_/ /\r\n/___/_/ /_/____/\\__/_/   \\__,_/\\___/_/\\____/_/ /_/\\___/____/   \\__,_/\\___/_/  __/ /\\__,_/\\___/\\__, /\\____/ \r\n                                                                             /___/           /____/ ");
            Console.WriteLine("1- Al empezar el juego se le mostrara al inicio una secuenica la cual le aparecera por un tempo definido, cuando este tiempo concluya se le quitara de la vista la secuencia");
            Console.WriteLine("una vez no se le muestre la secuencia sele solicitara ingresar la secuencia vista anteriormente de manera correcta siendo asi que se avanzara en al siguiente nivel");
            Console.WriteLine("de ser el caso contrario perdera el juego.");
            Console.WriteLine(" Al avanzar de nivel la secuencia durara menos tiempo en ser visible y en ciertos casos se llegara a ver de una manera parpadeada");
            Console.WriteLine(" 3- El juego le indicara cuando a pasado el nivel del mismo caso sucedera con terminar o perder el juego");
            Console.WriteLine(" 4- los niveles se representaran por la cantidad que va a tener la secuencia siendo asi que el nivel 3 se presentara como el nivel inicial");
            Console.ReadLine();
        }

        // Metodo para enseñar los creditos 

        static public void MostrarlaPortada()
        {
            Console.Clear();
            Console.WriteLine(" __ ) _)                           _)     |                                                       _)                 \r\n __ \\  |  _ \\ __ \\\\ \\   / _ \\ __ \\  |  _` |  _ \\   __|   _` |  __ `__ \\   _ \\ __ `__ \\   _ \\   __| | |   | __ `__ \\  \r\n |   | |  __/ |   |\\ \\ /  __/ |   | | (   | (   |\\__ \\  (   |  |   |   |  __/ |   |   | (   | |    | |   | |   |   | \r\n____/ _|\\___|_|  _| \\_/ \\___|_|  _|_|\\__,_|\\___/ ____/ \\__,_| _|  _|  _|\\___|_|  _|  _|\\___/ _|   _|\\__,_|_|  _|  _| ");
            Console.WriteLine("prueba tu capacidad de memorizar");
            Console.ReadLine();
        }

        // Metodo para enseñar los creditos

        static public void Creditos()
        {
            Console.WriteLine("   ______              ___ __            \r\n  / ____/_______  ____/ (_) /_____  _____\r\n / /   / ___/ _ \\/ __  / / __/ __ \\/ ___/\r\n/ /___/ /  /  __/ /_/ / / /_/ /_/ (__  ) \r\n\\____/_/   \\___/\\__,_/_/\\__/\\____/____/");
            Console.WriteLine("Creados por: André Rodríguez Artavia");
            Console.WriteLine("Arte ASCII por: ascii-art-generator.org");
            Console.ReadLine();
        }

        //Metodo para poder iniciar el juego

        static public void Comienzodeljuego()
        {
            //Se llena la secuencia de la computadora

            LogicadeJuego.llenarSecuenciacomputadora(LogicadeJuego.datosJuego.nivelActual);

            //Manera de Mostrar la secuencia de la computadora
            Console.WriteLine("los numeros a memorizar son:");
            for (int i = 0; i < LogicadeJuego.datosJuego.nivelActual; i++)
            {
                Console.Write(LogicadeJuego.datosJuego.secuenciaComputadora[i]);
            }
            Console.ReadLine();

            // se quita la secuencia de la computadora de la vista del jugador

            Console.Clear();

            // segundo se le pedira al jugador escrbir la secuencia 
            // Para obtener la respuesta
            Console.WriteLine("para poder escribir los numeros memorizados, escribir de uno en uno, en renglones aparte");
            Console.WriteLine("Digitar los numeros en el orden en el que salio en la secuencia");
           
           /* LogicadeJuego.LlenarSecuenciaJugador(LogicadeJuego.datosJuego.nivelActual);borrar*/
            for (int i = 0; i < LogicadeJuego.datosJuego.nivelActual; i++)
            {
                int respuestaescritaporeljugador = CapturarRespuesta();
                // da una nueva oportunidad de no cometer el error
                if ( respuestaescritaporeljugador == -1)
                {
                    respuestaescritaporeljugador = CapturarRespuesta();
                }
                LogicadeJuego.datosJuego.secuenciaJugador[i] = respuestaescritaporeljugador;
            }


            // se indicara si gano o no 
            if (LogicadeJuego.Comparaciondecasillas(LogicadeJuego.datosJuego.secuenciaJugador, LogicadeJuego.datosJuego.secuenciaComputadora) == true)
            {
                // si la respuesta es correcta se avanza al siguiente nivel 
                Console.WriteLine(" _                                                       \r\n|__ |o _o _| _. _| _  _  |_  _. _  _. _ _ .__|_ _. _| _  \r\n|(/_||(_|(_|(_|(_|(/__>o | |(_|_> (_|(_(/_|  |_(_|(_|(_) \r\n                       / ");
                LogicadeJuego.AumentodeNivel();
                Console.WriteLine("Escoge si quieres continuar");
                Opciones();
            }
            else
            {
                Console.WriteLine("           _                                            \r\n|_| _. _ _|__.|| _         _ |   _   _. o.__|_ _ ._| _  \r\n| |(_|_>  |(_|||(_)o \\/|_|(/_|\\/(/_ (_| || ||_(/_| |(_) \r\n                   /   ");
                Console.ReadLine();
                Console.Clear();
                LogicadeJuego.Reinicio();
                MostrarlaPortada();
                Opciones();

            }
        }

        // funcion para transformar el texto y mostrar error -1
        static public int CapturarRespuesta()
        {
            try
            {
                Console.Write("digite el siguiente numero de la se la secuencia: ");
                int respuestaescritaporeljugador;
                respuestaescritaporeljugador = int.Parse(Console.ReadLine());
                if(respuestaescritaporeljugador <= 9)
                {
                    return respuestaescritaporeljugador;
                }
                else
                {
                    Console.WriteLine("error al digitar su respuesta");
                    Console.WriteLine("porfavor solo digitar numeros del 0 al 9");
                    Console.ReadLine();
                    return -1;
                }
            }
            catch
            {
                Console.WriteLine("error al digitar su respuesta");
                Console.WriteLine("porfavor solo digitar numeros del 0 al 9");
                Console.ReadLine();
                return -1;  
            }
        }
        // Funcion que transforma el texto y regresa por el error a -1
        static public int CapturarNumero()
        {
            try
            {
                string textoEscritoPorElUsuario;
                textoEscritoPorElUsuario = Console.ReadLine();
                return int.Parse(textoEscritoPorElUsuario);
            }
            catch
            {
                Console.WriteLine("Error al escrbir");
                Console.WriteLine("solo se aceptan numeros del 1 al 4 ");
                Console.ReadLine();
                return -1;
            }
        }

        // metodo para que se enseñen las opciones 

        static public void Opciones()
        { 
            Console.WriteLine("1- Empezar juego o continuar juego");
            Console.WriteLine("2- Instruciones del juego");
            Console.WriteLine("3- Creditos");
            Console.WriteLine("4- salir");
            Console.WriteLine("Digite su opcion escogida:");
        }

    }
}
