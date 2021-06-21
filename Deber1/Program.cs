using System;

namespace Deber1
{
    class Program
    {
        static void Main (string[]args)
        {
            Console.WriteLine("Bienvenido Se le presentara Informacion sobre Anime y Videojuegos \n");
            
            Console.WriteLine ("--- Anime 1 ---" \n);
            
            OnePiece luffy = new OnePiece ();
            
            luffy.reflejarNombreAnime ();
            luffy.reflejarAnoInicioEmision ();
            luffy.reflejarCreadorDelAnime ();
            luffy.reflejarNombrePersonaje ();
            luffy.reflejarObjetivo ();
            luffy.reflejarNombreBanda ();
            luffy.reflejarTotalIntegrantes ();
            luffy.reflejarNombresIntegrantesTripulacion ();
            luffy.reflejarQueEsFrutaDelDiablo ();
            luffy.reflejarFrutaDelDiablo ();

            Console.WriteLine ("--- Anime 2 ---" \n);

            DeathNote light = new DeathNote ();
            
            light.reflejarNombreAnime ();
            light.reflejarAnoInicioEmision ();
            light.reflejarCreadorDelAnime ();
            light.reflejarNombrePersonaje ();
            light.reflejaralias ();
            light.reflejarObjetivo ();
            light.reflejarNombreRival ();
            light.reflejarAliados ();
            light.reflejarQueEsShinigami ();
            light.reflejarNombreShinigami ();

            Console.WriteLine ("--- Anime 3 ---" \n);

            SakuraCardCaptor sakura = new SakuraCardCaptor ();
            
            sakura.reflejarNombreAnime ();
            sakura.reflejarAnoInicioEmision ();
            sakura.reflejarCreadorDelAnime ();
            sakura.reflejarGenero ();
            sakura.reflejarNombrePersonaje ();
            sakura.reflejarObjetivo ();
            sakura.reflejarTotalCartas ();
            sakura.reflejarNombresGuardianes ();
            sakura.reflejarCreadorCartasGuardianes ();
            sakura.reflejarAliados ();


            Console.WriteLine ("--- Videojuego 1 ---" \n);
      
            ResidentEvil residentEvil2 = new ResidentEvil ();
            
            residentEvil2.reflejarNombreJuego ();
            residentEvil2.reflejarEmpresa ();
            residentEvil2.reflejarGeneroJuego ();
            residentEvil2.reflejarTotalJuegos ();
            residentEvil2.reflejarPersonajes ();
            residentEvil2.reflejarEnemigos ();
            residentEvil2.reflejarObjetivo ();
            residentEvil2.reflejarArmamento ();
            residentEvil2.reflejarCurasVacunas ();
            residentEvil2.reflejarNumeroEscenarios ();

            Console.WriteLine ("--- Videojuego 2 ---" \n);
      
            SuperMarioBros superMarioBros3 = new SuperMarioBros();
            
            superMarioBros3.reflejarNombreJuego ();
            superMarioBros3.reflejarEmpresa ();
            superMarioBros3.reflejarGeneroJuego ();
            superMarioBros3.reflejarTotalJuegos ();
            superMarioBros3.reflejarPersonaje ();
            superMarioBros3.reflejarEnemigos ();
            superMarioBros3.reflejarObjetivo ();
            superMarioBros3.reflejarPoderes ();
            superMarioBros3.reflejarCuras ();
            superMarioBros3.reflejarNumeroEscenarios ();
      
            Console.ReadKey();

  }

}
   
}
