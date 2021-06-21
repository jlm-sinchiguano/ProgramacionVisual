using System;

namespace Deber1
{
    
    class Program
    {
        static void Main(string[] args)
        {
            var luffy = new OnePiece();
            var light = new DeathNote();
            var sakura = new SakuraCardCaptor();
            var residentEvil2 = new ResidentEvil();
            var superMarioBros3 = new SuperMarioBros();
            while (true)
            {
                Console.WriteLine("Bienvenido \n Elija una opcion para ver la Información de: \n 1.Animes \n 2.Videojuegos \n 3.Salir");
                var opcion = Console.ReadLine();
                int opcion1 = int.Parse(opcion);
                if (opcion1 == 1)
                {
                    Console.WriteLine("--- Anime 1 ---");

                    luffy.reflejarNombreAnime();
                    luffy.reflejarAnoInicioEmision();
                    luffy.reflejarCreadorDelAnime();
                    luffy.reflejarNombrePersonaje();
                    luffy.reflejarObjetivo();
                    luffy.reflejarNombreBanda();
                    luffy.reflejarTotalIntegrantes();
                    luffy.reflejarNombresIntegrantesTripulacion();
                    luffy.reflejarQueEsFrutaDelDiablo();
                    luffy.reflejarFrutaDelDiablo();

                    Console.WriteLine ("--- Anime 2 ---");

                    light.reflejarNombreAnime();
                    light.reflejarAnoInicioEmision();
                    light.reflejarCreadorDelAnime();
                    light.reflejarNombrePersonaje();
                    light.reflejaralias();
                    light.reflejarObjetivo();
                    light.reflejarNombreRival();
                    light.reflejarAliados();
                    light.reflejarQueEsShinigami();
                    light.reflejarNombreShinigami();

                    Console.WriteLine("--- Anime 3 ---");

                    sakura.reflejarNombreAnime();
                    salura.reflejarAnoInicioEmision();
                    sakura.reflejarCreadorDelAnime();
                    sakura.reflejarGenero();
                    sakura.reflejarNombrePersonaje();
                    sakura.reflejarObjetivo();
                    sakura.reflejarTotalCartas();
                    sakura.reflejarNombresGuardianes();
                    sakura.reflejarCreadorCartasGuardianes();
                    sakura.reflejarAliados();

                }
                if (opcion1 == 2)
                {
                    Console.WriteLine("--- Videojuego 1 ---")

                    residentEvil2.reflejarNombreJuego();
                    residentEvil2.reflejarEmpresa();
                    residentEvil2.reflejarGeneroJuego();
                    residentEvil2.reflejarTotalJuegos();
                    residentEvil2.reflejarPersonajes();
                    residentEvil2.reflejarEnemigos();
                    residentEvil2.reflejarObjetivo();
                    residentEvil2.reflejarArmamento();
                    residentEvil2.reflejarCurasVacunas();
                    residentEvil2.reflejarNumeroEscenarios();

                    Console.WriteLine("--- Videojuego 2 ---")

                    superMarioBros3.reflejarNombreJuego();
                    superMarioBros3.reflejarEmpresa();
                    superMarioBros3.reflejarGeneroJuego();
                    superMarioBros3.reflejarTotalJuegos();
                    superMarioBros3.reflejarPersonaje();
                    superMarioBros3.reflejarEnemigos();
                    superMarioBros3.reflejarObjetivo();
                    superMarioBros3.reflejarPoderes();
                    superMarioBros3.reflejarCuras();
                    superMarioBros3.reflejarNumeroEscenarios();
                }
                
                }
                else
                {
                    Console.Write("Saliendo-----");
                    break;
                }
                Console.ReadKey();
            }

        }
    }
}
