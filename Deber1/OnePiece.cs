using System;

namespace Deber1
{
    public class OnePiece
    {
        public string nombreAnime;
        public int anoInicioEmision;
        public string creadorDelAnime;
        public string nombrePersonaje;
        public string objetivo;
        public string nombreBanda;
        public int totalIntegrantes;
        public string nombresIntegrantesTripulacion;
        public string queEsFrutaDelDiablo; 
        public string frutaDelDiablo;


        public void reflejarNombreAnime()
        {
            Console.Write("Nombre del Anime: One Piece \n");
        }

        public void reflejarAnoInicioEmision()
        {
            Console.Write("Año de Emisión: Se empezó a emitir en el año 1999 \n");
        }

        public void reflejarCreadorDelAnime()
        {
            Console.Write("Creador: Eiichirō Oda \n");
        }

        public void reflejarNombrePersonaje()
        {
            Console.Write("Nombre del Personaje Principal: Monkey D. Luffy \n");
        }

        public void reflejarObjetivo()
        {
            Console.Write("Objetivo del Personaje Principal: Convertirse en el Rey de los piratas \n");
        }

        public void reflejarNombreBanda()
        {
            Console.Write("Nombre de la tripulación: Piratas de Sombrero de Paja \n");
        }

        public void reflejarTotalIntegrantes()
        {
            Console.Write("Número de Integrantes: 10 \n");
        }

        public void reflejarNombresIntegrantesTripulacion()
        {
            Console.Write("Nombres de los Integrantes de la Banda: \n - Roronoa Zoro \n - Nami \n - Usopp \n - Sanji \n - Tony Tony Chopper \n - Nico Robin \n - Franky \n - Brook \n - Jinbe \n");
        }

        public void reflejarQueEsFrutaDelDiablo()
        {
            Console.Write("¿Qué es la Fruta del Diablo? \n son unos frutos místicos que se encuentran en el mundo de One Piece y otorgan al consumidor una habilidad determinada en función de la fruta que se coma.\n");
        }

        public void reflejarFrutaDelDiablo()
        {
            Console.Write("Fruta del Diablo del Personaje Principal: Fruta Gomu Gomu \n");
        }

    }
}