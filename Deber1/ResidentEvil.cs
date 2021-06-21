using System;

namespace Deber1
{
    public class ResidentEvil
    {
        public string nombreJuego;
        public string empresa;
        public string generoJuego;
        public int totalJuegos ;
        public string personajes;
        public string enemigos;
        public string objetivo; 
        public string armamento;
        public string curasVacunas;
        public int numeroEscenarios ;

        public void reflejarNombreJuego()
        {
            Console.Write("Nombre del Juego: Resident evil 2 \n");
        }

        public void reflejarEmpresa()
        {
            Console.Write("Nombre de empresa: CAPCOM \n");
        }

        public void reflejarGeneroJuego()
        {
            Console.Write("Genero: Horror de supervivencia \n");
        }

        public void reflejarTotalJuegos()
        {
            Console.Write("Numero de juegos de Resident Evil: 32 \n");
        }

        public void reflejarPersonajes()
        {
            Console.Write("Personajes de Resident evil 2: Leon Scott Kennedy y Claire Redfield \n");
        }

        public void reflejarEnemigos()
        {
            Console.Write("Enemigos: \n - Tyrant T-103 \n - Williem Birkin \n - Tyrant \n - Licker\n");
        }

        public void reflejarObjetivo()
        {
            Console.Write("Objetivo: Lograr salir de Raccoon City\n");
        }

        public void reflejarArmamento()
        {
            Console.Write("Armamento: pistolas, escopetas, magnums y artillería pesada \n");
        }

        public void reflejarCurasVacunas()
        {
            Console.Write("Curas y Vacunas: hierba verde, hierba roja, herba azul, Cura tipo-E, Cura virus-T ");
        }

        public void reflejarNumeroEscenarios()
        {
            Console.Write("Total de escenarios: 4 \n ");
        }

    }
}