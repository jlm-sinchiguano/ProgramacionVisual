using System;

namespace Deber1
{
    public class SuperMarioBros
    {
        public string nombreJuego;
        public string empresa;
        public string generoJuego;
        public int totalJuegos ;
        public string personaje;
        public string enemigo;
        public string objetivo; 
        public string poderes;
        public string curas;
        public int numeroEscenarios ;

        public void reflejarNombreJuego()
        {
            Console.Write("Nombre del Juego: Super Mario Bros 3 \n");
        }

        public void reflejarEmpresa()
        {
            Console.Write("Nombre de empresa: Nintendo \n");
        }

        public void reflejarGeneroJuego()
        {
            Console.Write("Genero: Aventura \n");
        }

        public void reflejarTotalJuegos()
        {
            Console.Write("Numero de juegos de Super Mario: 140 \n");
        }

        public void reflejarPersonaje()
        {
            Console.Write("Personajes de Super Mario Bros 3: Mario \n");
        }

        public void reflejarEnemigos()
        {
            Console.Write("Enemigos: \n -Goomba \n -Koopa \n -Bowser\n");
        }

        public void reflejarObjetivo()
        {
            Console.Write("Objetivo: Salvar a los siete reinos del Mundo Champiñón\n");
        }

        public void reflejarPoderes()
        {
            Console.Write("Items: \n -Flor de fuego \n -Hoja \n -Estrella \n -Disfraz de rana \n -Disfraz de Mapache \n -Disfraz de hermano martillo \n -Nube de Jugem");
        }

        public void reflejarCuras()
        {
            Console.Write("Cura : Hongo vida extra");
        }

        public void reflejarNumeroEscenarios()
        {
            Console.Write("Total de escenarios: 8 \n ");
        }

    }
}