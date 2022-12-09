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
            //secuenciaComputadadora = generadordenumerosaleatorios.Next(0,10);
        }
            
        // Metodo llenar la secuencia de la computadora con numeros aleatorio
      
        public void llenarSecuencia()
        {
            datosJuego.secuenciaComputadora[0] = generadordenumerosaleatorios.Next(0, 10);
            datosJuego.secuenciaComputadora[1] = generadordenumerosaleatorios.Next(0, 10);
            datosJuego.secuenciaComputadora[2] = generadordenumerosaleatorios.Next(0, 10);

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

        // metodo de progresar juego

        public void progresodeljuego()
        {
            datosJuego.nivelActual += 1;
        }

        // metodo que compara casilla por casilla la secuencia de la computadora con la respuesta del jugador para saber si es correcta

        public bool Comparaciondecasillas()
        {
            if (datosJuego.secuenciaJugador[0] == datosJuego.secuenciaComputadora[0])
                return true;

            else if (datosJuego.secuenciaJugador[1] == datosJuego.secuenciaComputadora[1])
                return true;
            else if (datosJuego.secuenciaJugador[2] == datosJuego.secuenciaComputadora[2])
                return true;
            else
                return false;
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
        // metodo de incio de juego 
        // metodo de instruciones 
        // metodo de cerditos
        // metodo para salir del juego
        // metodo para la dificultad actual
        // metodo de perdida
        // metodo para entregar la secuencia 
        //  metodo para el aumento de numero en la secuencia 
        // metodo  obtener  la secuencia de la computadora en la dificultad actual 
        // metodo para el parpadeo de una una secuencia 
        // 


    }
}