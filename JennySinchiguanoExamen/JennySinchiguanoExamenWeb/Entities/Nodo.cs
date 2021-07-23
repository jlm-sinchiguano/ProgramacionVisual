using System.Collections.Generic;

namespace JennySinchiguanoPregunta1
{
    public class Nodo
    {
        public double Valor { get; set; }
        public List<Nodo> NodosHijos { get; set; } = new List<Nodo>();
    }
}