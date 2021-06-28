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
    } 

    public enum Notacion
    {
        Infijo,
        Prefijo,
        Postfijo
    }
}