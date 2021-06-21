using System;

namespace Deber1
{
    public class SakuraCardCaptor
    {
        public string nombreAnime;
        public int anoInicioEmision;
        public string creadorDelAnime;
        public string genero ;
        public string nombrePersonaje;
        public string objetivo; 
        public int totalCartas ;
        public string nombresGuardianes;
        public string creadorCartasGuardianes;
        public string aliados ;

        public void reflejarNombreAnime()
        {
            Console.Write("Nombre del Anime: Sakura Card Captor \n");
        }

        public void reflejarAnoInicioEmision()
        {
            Console.Write("Año de Emisión: Se empezó a emitir en el año 1998 \n");
        }

        public void reflejarCreadorDelAnime()
        {
            Console.Write("Creador: CLAMP \n");
        }

        public void reflejarGenero()
        {
            Console.Write("Genero: Aventura, Comedia y Romance \n");
        }

        public void reflejarNombrePersonaje()
        {
            Console.Write("Nombre del Personaje Principal: Sakura Kinomoto \n");
        }

        public void reflejarObjetivo()
        {
            Console.Write("Objetivo del Personaje Principal: \n Capturar y cuidar unas cartas con poderes mágicos llamadas cartas clow \n");
        }

        public void reflejarTotalCartas()
        {
            Console.Write("Total cartas Clow : 53 \n");
        }

        public void reflejarNombresGuardianes()
        {
            Console.Write("Nombres de los guardianes de las cartas Clow: \n Kerberus y Yue \n");
        }

        public void reflejarCreadorCartasGuardianes()
        {
            Console.Write("¿Quién creo las cartas clow y sus guardianes?\n Su creador es el Mago Reed Clow");
        }

        public void reflejarAliados()
        {
            Console.Write("Los aliados del Personaje Principal son: \n - Kerberus \n - Tomoyo Daidouji \n ");
        }

    }
}