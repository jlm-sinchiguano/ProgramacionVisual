using System.Collections.Generic;

namespace Deber2Arbol
{
    public class Nodo
    {
        public string Valor {get; set;}
        public List<Nodo> Hijos {get; set;} = new List<Nodo>();
    }
}