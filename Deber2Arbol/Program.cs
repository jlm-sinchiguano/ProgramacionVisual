using System;

namespace Deber2Arbol
{
    class Program
    {
        static void Main(string [] args)
        {
            var raiz = new Nodo()
            {
                Valor = "/",
                Hijos =
                {
                    new Nodo
                    {
                        Valor = "*",
                        Hijos =
                        {
                            new Nodo
                            {
                                Valor = "1"
                            },
                            new Nodo
                            {
                                Valor = "2"
                            }
                        }
                    },
                    new Nodo
                    {
                        Valor = "+",
                        Hijos =
                        {
                            new Nodo
                            {
                                Valor = "5"
                            },
                            new Nodo
                            {
                                Valor = "-",
                                Hijos=
                                {
                                    new Nodo
                                    {
                                        Valor = "3"
                                    },
                                    new Nodo
                                    {
                                        Valor = "2"
                                    }
                                }
                            }
                        }
                    }
                }
            };   
            ManejadorArbol manejadorArbol = new ManejadorArbol();
            Console.WriteLine($"Notación Infija: {(manejadorArbol.MostrarArbol(raiz, Notacion.Infijo))}");
            Console.WriteLine($"Notación Prefija: {(manejadorArbol.MostrarArbol(raiz, Notacion.Prefijo))}");
            Console.WriteLine($"Notación Postfija: {(manejadorArbol.MostrarArbol(raiz, Notacion.Postfijo))}");
            Console.ReadKey();
        }
    }
}

