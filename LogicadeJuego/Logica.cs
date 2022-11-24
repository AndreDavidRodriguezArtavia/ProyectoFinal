using Entidades;
using System.Security.Cryptography.X509Certificates;

namespace LogicadeJuego
{
    public class Logica
    {
        //Propiedades:

        public Datos datosJuego;

        // Metodo constructor
        public Logica()
        {
            datosJuego = new Datos();
            datosJuego.secuenciaJugador = new int[10];
            datosJuego.secuenciaComputadora = new int[10];
            datosJuego.nivelActual = 3;
        }
            
       
        // Metodo llenar la secuencia de la computadora con numeros aleatorio
      
        public void llenarSecuencia()
        {
            
        }

        // metodo para aumentar el nivel del juego 
        // metodo de gane y perdida  
        // metodo que compara casilla por casilla la secuencia de la computadora con la respuesta del jugador para saber si es correcta

    }
}