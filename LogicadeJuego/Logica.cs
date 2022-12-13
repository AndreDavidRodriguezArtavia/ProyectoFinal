using Entidades;
using System.Security.Cryptography.X509Certificates;

namespace LogicadeJuego
{
    public class Logica
    {
        //Propiedades:

        public Datos datosJuego;
        Random generadordenumerosaleatorios;
        private int Respuestadeljugador;


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
            Console.WriteLine("Usted se encuentra en el nivel : " + nivel);
            for (int i = 0; i < nivel; i++)
            {

                datosJuego.secuenciaComputadora[i] = generadordenumerosaleatorios.Next(0, 10);

            }

        }

        // metodo para aumentar el nivel del juego 

        public void AumentodeNivel()
        {
            datosJuego.nivelActual += 1;
            datosJuego.secuenciaJugador = new int[datosJuego.nivelActual];
            datosJuego.secuenciaComputadora = new int[datosJuego.nivelActual];


        }

        //metodo para resetear
        public void Reinicio()
        {
            datosJuego.nivelActual = 3;
            datosJuego.secuenciaJugador = new int[datosJuego.nivelActual];
            datosJuego.secuenciaComputadora = new int[datosJuego.nivelActual];
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
        }

        public int dificultadactual()
        {
            return datosJuego.nivelActual;
        }
    }
}