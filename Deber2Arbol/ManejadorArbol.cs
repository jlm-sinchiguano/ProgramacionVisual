using System;
using System.Linq;

namespace Deber2Arbol
{
    public class ManejadorArbol
    {
        public string MostrarArbol (Nodo nodo, Notacion notacion)
        {
            if (!nodo.Hijos.Any())
                return nodo.Valor;
                switch (notacion)
                {
                    case Notacion.Infijo:
                        return $" ({MostrarArbol(nodo.Hijos[0], notacion)} {nodo.Valor} {MostrarArbol(nodo.Hijos[1], notacion)}) ";
                    case Notacion.Prefijo:
                        return $" ( {nodo.Valor} {MostrarArbol(nodo.Hijos[0], notacion)}  {MostrarArbol(nodo.Hijos[1], notacion)} )";
                    case Notacion.Postfijo:
                        return $" ( {MostrarArbol(nodo.Hijos[0], notacion)} {MostrarArbol(nodo.Hijos[1], notacion)} {nodo.Valor} ) ";
                    default:
                        return "Notación no implementada";
                };
        }

        public int TotalHojas(Nodo nodo)
        {
            if (SoyHoja(nodo))
                return 1;
           
            int totalHojas = 0;
            foreach(Nodo hijoActual in nodo.Hijos)
            {
                totalHojas += TotalHojas(hijoActual);
            }
            return totalHojas;
        }
    
        public int TotalNodos (Nodo nodo)
        {
            if (SoyHoja(nodo))
                return 1;
        
            int totalNodos = 0;
            foreach(Nodo nodoActual in nodo.Hijos)
            {
                totalNodos += TotalNodos(nodoActual);
            }
            return totalNodos + 1;
        }
    
        public int TotalNiveles (Nodo nodo)
        {
            if (nodo == null)
                return 0;
            
            var nivel = 0;
            foreach(Nodo nodoActual in nodo.Hijos)
            {
                var nivelActual = TotalNiveles(nodoActual);
                if(nivel < nivelActual)
                   nivel = nivelActual;
            }
            return ++nivel;
        }
    
        private bool SoyHoja (Nodo nodo)
        {
            return !nodo.Hijos.Any();
        }
    } 

    public enum Notacion
    {
        Infijo,
        Prefijo,
        Postfijo
    }
}
