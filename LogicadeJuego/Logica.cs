using Entidades;
using System.Security.Cryptography.X509Certificates;

namespace LogicadeJuego
{
    public class Logica
    {
        //Propiedades:

        public Datos datosJuego;
        Random generadordenumerosaleatorios;
        int secuenciaComputadadora;
        int niveldedificultad;

        // Metodo constructor

        public Logica()
        {
            datosJuego = new Datos();
            datosJuego.secuenciaJugador = new int[10];
            datosJuego.secuenciaComputadora = new int[10];
            datosJuego.nivelActual = 3;
            generadordenumerosaleatorios = new Random();
            secuenciaComputadadora = generadordenumerosaleatorios.Next(0,10);
        }
            
        // Metodo llenar la secuencia de la computadora con numeros aleatorio
      
        public void llenarSecuencia()
        {
            datosJuego.secuenciaComputadora[0] = 2;
            datosJuego.secuenciaComputadora[1] = 3;
            datosJuego.secuenciaComputadora[2] = 0;
            datosJuego.secuenciaComputadora[3] = 1;
            datosJuego.secuenciaComputadora[4] = 4;
            datosJuego.secuenciaComputadora[5] = 9;
            datosJuego.secuenciaComputadora[6] = 8;
            datosJuego.secuenciaComputadora[7] = 5;
            datosJuego.secuenciaComputadora[8] = 6;
            datosJuego.secuenciaComputadora[9] = 7;
        
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
            niveldedificultad += 1;
            secuenciaComputadadora = generadordenumerosaleatorios.Next(0, 9);
        }

        // metodo de gane   
        // metodo que compara casilla por casilla la secuencia de la computadora con la respuesta del jugador para saber si es correcta
        // metodo para mostrar y restar vidas
        // metodo para el tiempo de respuesta 
        // metodo para la aleotioridad 
        // "metodo para fallo o acierto acierto del jugador"
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