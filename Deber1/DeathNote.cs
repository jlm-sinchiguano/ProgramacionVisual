using System;

namespace Deber1
{
    public class DeathNote
    {
        public string nombreAnime;
        public int anoInicioEmision;
        public string creadorDelAnime;
        public string nombrePersonaje;
        public string alias;
        public string objetivo;
        public string nombreRival;
        public string aliados ;
        public string queEsShinigami ; 
        public string nombreShinigami;

        public void reflejarNombreAnime()
        {
            Console.Write("Nombre del Anime: Death Note \n");
        }

        public void reflejarAnoInicioEmision()
        {
            Console.Write("Año de Emisión: Se empezó a emitir en el año 2006 \n");
        }

        public void reflejarCreadorDelAnime()
        {
            Console.Write("Creador: Tsugumi Ōba \n");
        }

        public void reflejarNombrePersonaje()
        {
            Console.Write("Nombre del Personaje Principal: Light Yagami \n");
        }

        public void reflejaralias()
        {
            Console.Write("Alias del Personaje Principal: Kira \n");
        }

        public void reflejarObjetivo()
        {
            Console.Write("Objetivo del Personaje Principal: \n Convertirse en la justicia que cambie el mundo y la historia, creando una sociedad libre de toda gente malvada \n");
        }

        public void reflejarNombreRival()
        {
            Console.Write("Nombre del Rival del Personaje Principal: L \n");
        }

        public void reflejarAliados()
        {
            Console.Write("Los aliados del Personaje Principal son: \n - Misa Amane \n - Kiyomi Takada \n - Teru Mikami \n ");
        }

        public void reflejarQueEsShinigami()
        {
            Console.Write("¿Qué es un Shinigami? \n Dios de la muerte, son dioses o seres sobrenaturales que invitan a los seres humanos hacia la muerte, o inducen sentimientos de querer morir. \n");
        }

        public void reflejarNombreShinigami()
        {
            Console.Write("Shinigami del Personaje Principal: Ryuk \n");
        }

        

    }
}