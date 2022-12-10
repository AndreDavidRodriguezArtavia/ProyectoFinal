using Entidades;
using System.Security.Cryptography.X509Certificates;

namespace LogicadeJuego
{
    public class Logica
    {
        //Propiedades:

        public Datos datosJuego;
        Random generadordenumerosaleatorios;


        // Metodo constructor

        public Logica()
        {
            datosJuego = new Datos();
            datosJuego.secuenciaJugador = new int[3];
            datosJuego.secuenciaComputadora = new int[3];
            datosJuego.nivelActual = 3;
            generadordenumerosaleatorios = new Random();

        }

        // Metodo llenar la secuencia de la computadora con numeros aleatorio

         public void llenarSecuenciacomputadora(int nivel)
        {

            Console.WriteLine("entro a llenar secuencia de computadora con nivel "+ nivel);
            // para llenar se necesia los arreglos 
            // numero aleatorio (0,9)
            // crear los campos del nivel actual
            for (int i = 0; i<nivel;i++)
            {
  
                datosJuego.secuenciaComputadora[i] = generadordenumerosaleatorios.Next(0, 10);
                
            }

        }

        // metodo para aumentar el nivel del juego 

        public void AumentodeNivel()
        {
            datosJuego.nivelActual += 1;
        }

        //metodo para resetear
        public void Reinicio()
        {
            datosJuego.nivelActual = 3;
        }

 
        // metodo que compara casilla por casilla la secuencia de la computadora con la respuesta del jugador para saber si es correcta

        public bool Comparaciondecasillas(int[]jugador, int[]computadora)
        {
            bool  comparacion = true;
            for (int i = 0; i < jugador.Length; i++)
            {
                if (jugador[i] != computadora[i])
                {
                    comparacion = false;
                    break;
                }
            }
            return comparacion; 

            
            //if (jugador[0] == computadora[0])
               // return true;

            /*else if jugador[1] == computadora[1])
                return true;
            else if (jugador[2] == computadora[2])
                return true;
            else
                return false;*/
        }

        public int dificultadactual()
        {
            return datosJuego.nivelActual;
        }

        // metodo para el tiempo de respuesta 

        // metodo para aumentar la cantidad de numeros de la secuencia 
        // metodo para obtener la respuesta del jugador 

        
        // metodo para mostrar la secuecnia numeral 

        // metodo para de tiempo para mostrar la secuencia
        // metodo para dejar de mostrar la secuencia
      
       
       
      
        // metodo para entregar la secuencia 
        //  metodo para el aumento de numero en la secuencia 
        // metodo  obtener  la secuencia de la computadora en la dificultad actual 
        // metodo para el parpadeo de una una secuencia 
        


    }
}