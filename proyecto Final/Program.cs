using LogicadeJuego;

namespace ProyectoFinalAndreRodriguez
{
    internal class Program
    {
        // metodo para enseñar la portada del juego 

        static void MostrarlaPortada()
        {
            Console.Clear();
            Console.WriteLine("Bienvenidos a memorium");
            Console.WriteLine("prueba tu capacidad de memorizar");
            Console.ReadLine();
        }


        // metodo para mostrar las instruciones 

        static void Instruciones()
        {
            Console.WriteLine("1- Al empezar el juego se le mostrara al inicio una secuenica la cual le aparecera por un tempo definido, cuando este tiempo concluya se le quitara de la vista la secuencia");
            Console.WriteLine("una vez no se le muestre la secuencia sele solicitara ingresar la secuencia vista anteriormente de manera correcta siendo asi que se avanzara en al siguiente nivel");
            Console.WriteLine("de ser el caso contrario perdera el juego.");
            Console.WriteLine("2- Al avanzar de nivel la secuencia durara menos tiempo en ser visibli y en ciertos casos se llegara a ver de una manera parpadeada");
            Console.WriteLine("3- El juego le indicara cuando a pasado el nivel del mismo caso sucedera con terminar o perder el juego");
            Console.ReadLine();
        }

        // Metodo para enseñar los creditos 

        static void Creditos()
        {
            Console.WriteLine("Creado por André Rodríguez");
            Console.WriteLine("Arte ASCII por: ascii-art-generator.org");
            Console.ReadLine();
        }

        //Metodo para poder iniciar el juego 
        static void Comienzodeljuego()
        {

        }

        // metodo para que se enseñen las opciones 
        static void Opciones()
        {
            Console.WriteLine("1- Empezar juego");
            Console.WriteLine("2- Instruciones del juego");
            Console.WriteLine("3- Creditos");
            Console.WriteLine("4- salir");
            Console.WriteLine("Digite su opcion escogida:");
            Console.ReadLine();
        }

        // Funcion que transforma el texto y regresa por el error a -1

        static int CapturarRespuesta()
        {
            try
            {
                string Textoqueescribioelusuario;
                Textoqueescribioelusuario = Console.ReadLine();
                return int.Parse(Textoqueescribioelusuario);
            }
            catch
            {
                Console.WriteLine("error al digitar su selección ");
                Console.WriteLine("Solo se pude digar un numero del 1 al 4 con sus respectivas aclaraciones de las opciones");
                return -1;
            }
        }
        static void Main(string[] args)
        {
            int SelecciondelUsuario = 0;

            // Ciclo (Gameloop)

            while (SelecciondelUsuario != 4)
            {
                //Opción para enseñar la portada  

                MostrarlaPortada();

                // se va a mostrar las opciones que se va a tener para que el jugador eliga cual quiere

                Opciones();

                //Manera para obtener la escogencia del jugador 

                SelecciondelUsuario = CapturarRespuesta();

                if (SelecciondelUsuario == 1)
                {
                    // cuando se escoge 1 se comienza el juego

                    Console.WriteLine("Has escogido iniciar el juego seras enviado al nivel de inicio del juego");
                    Console.ReadLine();
                }
                else if (SelecciondelUsuario == 2)
                {
                    // cuando se escoge 2 se mostraran las instruciones 

                    Instruciones();
                }
                else if (SelecciondelUsuario == 3)
                {
                    // cuando se escogue 3 se mostraran los creditos 

                    Creditos();
                }
                else if (SelecciondelUsuario == 4)
                {
                    // cuando el jugador escoge 4 sera para salir del juego
                    Console.WriteLine("has escogido salir del juego");
                    Console.ReadLine();
                }




            }
        } 
    }
}   
    