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
                if (LogicadeJuego.datosJuego.nivelActual == 13)
                {
                    Console.WriteLine("has alcanzado el nivel final y lo has superado felicidades has terminado el juego muchas gracias por participar");
                    Console.ReadLine();
                    break;
                }
  
                //Manera para obtener la escogencia del jugador 

                SeleccionDelUsuario = CapturarNumero();

                // selecciones posibles junto a las desiciones del jugador
                if (SeleccionDelUsuario == 1)
                {
                    // cuando se escoge 1 se comienza el juego
                    Console.WriteLine("Has escogido iniciar el juego seras enviado al nivel de inicio del juego");
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
                Console.WriteLine("!Felicidades¡, has acertado avanzas al siguiente nivel");
                LogicadeJuego.AumentodeNivel();
                Opciones();
            }
            else
            {
                Console.WriteLine("Has fallo, vuelve a interlo");
                Console.ReadLine();
                Console.Clear();
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
            Console.WriteLine("1- Empezar juego");
            Console.WriteLine("2- Instruciones del juego");
            Console.WriteLine("3- Creditos");
            Console.WriteLine("4- salir");
            Console.WriteLine("Digite su opcion escogida:");
        }

    }
}
