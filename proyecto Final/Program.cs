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

            // Cliclo (Gameloop)
            while (SeleccionDelUsuario != 4)
            {

                //Opción para enseñar la portada 

                MostrarlaPortada();

                // se va a mostrar las opciones que se va a tener para que el jugador eliga cual quiere

                Opciones();

                //Manera para obtener la escogencia del jugador 

                SeleccionDelUsuario = CapturarNumero();


                if (SeleccionDelUsuario == 1)
                {
                    // cuando se escoge 1 se comienza el juego
                    Console.WriteLine("Has escogido iniciar el juego seras enviado al nivel de inicio del juego");
                    Console.ReadLine();
                    Comienzodeljuego();
                    Console.ReadLine();
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
                    Console.WriteLine("has escogido salir del juego");
                    Console.ReadLine();
                }
            }
        }

        // metodo para mostrar las instruciones
        static public void Instrucciones()
        {
            Console.WriteLine("Instruciones del juego");
            Console.WriteLine("1- Al empezar el juego se le mostrara al inicio una secuenica la cual le aparecera por un tempo definido, cuando este tiempo concluya se le quitara de la vista la secuencia");
            Console.WriteLine("una vez no se le muestre la secuencia sele solicitara ingresar la secuencia vista anteriormente de manera correcta siendo asi que se avanzara en al siguiente nivel");
            Console.WriteLine("de ser el caso contrario perdera el juego.");
            Console.WriteLine(" Al avanzar de nivel la secuencia durara menos tiempo en ser visible y en ciertos casos se llegara a ver de una manera parpadeada");
            Console.WriteLine(" 3- El juego le indicara cuando a pasado el nivel del mismo caso sucedera con terminar o perder el juego");
            Console.ReadLine();
        }

        // Metodo para enseñar los creditos 

        static public void MostrarlaPortada()
        {
            Console.Clear();
            Console.WriteLine("Bienvenidos a memorium");
            Console.WriteLine("prueba tu capacidad de memorizar");
            Console.ReadLine();
        }

        // Metodo para enseñar los creditos

        static public void Creditos()
        {
            Console.WriteLine("Creados por: André Rodríguez Artavia");
            Console.WriteLine("Arte ASCII por: ascii-art-generator.org");
            Console.ReadLine();
        }

        //Metodo para poder iniciar el juego

        static public void Comienzodeljuego()
        {
            int Respuestadeljugador;



            // primer paso se llena la secuencia de la computadora
            Console.WriteLine("llamado a llenar secuencia");
            LogicadeJuego.llenarSecuenciacomputadora(LogicadeJuego.datosJuego.nivelActual);

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
            Console.Write("Los numeros que se memorizaron son: ");
            LogicadeJuego.LlenarSecuenciaJugador(LogicadeJuego.datosJuego.nivelActual);
            for (int i = 0; i < LogicadeJuego.datosJuego.nivelActual; i++)
            {
                Respuestadeljugador = CapturarRespuesta();
            }

            
            // se indicara si gano o no 
            if (LogicadeJuego.evaluacionderespuesta() == true)
            {
                // si la respuesta es correcta se avanza al siguiente nivel 
                Console.WriteLine("!Felicidades¡, has acertado avanzas al siguiente nivel");
                LogicadeJuego.AumentodeNivel();
            }
            else
            {
                Console.WriteLine("Has fallo, vuelve a interlo");
                Console.ReadLine();

            }






            
            // se aumenta y llena la secuencia 
            // se quita de la vista del jugador 
            // se pedira la respuesta 
            // se llenara la secuencia del jugador 
            // se compararan las secuencia 
            
        }

        // funcion para transformar el texto y mostrar error -1
        static public int CapturarRespuesta()
        {
            try
            {
                string respuestaescritaporeljugador;
                respuestaescritaporeljugador = Console.ReadLine();
                return int.Parse(respuestaescritaporeljugador);
            }
            catch
            {
                Console.WriteLine("error al digitar su respuesta");
                Console.WriteLine("porfavor solo digitar numeros del 0 al 9");
                Console.ReadLine();
                return 0;  
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

        // metodo para la capturar la respuesta del jugador
        /*static public int CapturarlaRespuestaJugador()
        {
            try
            {
                string respuestaescritaporeljugador;
                respuestaescritaporeljugador = Console.ReadLine();
                return  respuestaescritaporeljugador;
            }
            catch
            {
                Console.WriteLine("Error al escribir la respuesta");
                Console.WriteLine("solo se acepta los numeros del 0 al 9");
                Console.WriteLine("Vuelva a digitar la secuencia memorizada");
                Console.ReadLine();
                return -1;
            }
        }*/
        // metodo para que se enseñen las opciones 

        static public void Opciones()
        { 
            Console.WriteLine("1- Empezar juego");
            Console.WriteLine("2- Instruciones del juego");
            Console.WriteLine("3- Creditos");
            Console.WriteLine("4- salir");
            Console.WriteLine("Digite su opcion escogida:");
        }
    }
}
