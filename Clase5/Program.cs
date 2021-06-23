using System;
using System.Collections.Generic;

namespace Clase5
{
    class Program
    {
        public static void Main(string[] args)
        {
            Pais pais1 = new Pais
            {
                Nombre = "Ecuador",
                PaisId = 1
            };
            
            pais1.Provincias = new List<Provincia>();
            
            var provincia1 = new Provincia();
            provincia1.Nombre = "Pichincha";
      
            pais1.Provincias = new List<Provincia>()
            {
                provincia1
            };
      
            var canton1 = new Canton();
            canton1.Nombre = "Quito";
      
            var canton2 = new Canton();
            canton2.Nombre = "Cayambe";
            provincia1.Cantones = new List<Canton>();
            provincia1.Cantones.Add(canton1);
            provincia1.Cantones.Add(canton2);
      
            var parroquia1 = new Parroquia();
            parroquia1.Nombre = "Nayón";
      
            var parroquia2 = new Parroquia();
            parroquia2.Nombre = "Mariscal Sucre";
      
            parroquia1.Habitantes = 1000 ;
            parroquia2.Habitantes = 1000;
      
            canton1.Parroquias = new List<Parroquia>();
            canton1.Parroquias.Add(parroquia1);
            canton1.Parroquias.Add(parroquia2);
      
            var parroquia3 = new Parroquia();
            parroquia3.Nombre = "Ayora";
      
            var parroquia4 = new Parroquia();
            parroquia4.Nombre = "Olmedo";
      
            parroquia3.Habitantes = 500;
            parroquia4.Habitantes = 600;
      
            canton2.Parroquias = new List<Parroquia>();
            canton2.Parroquias.Add(parroquia3);
            canton2.Parroquias.Add(parroquia4);
      
            Console.WriteLine($"El resultado total de habitantes es: {pais1.ObtenerNumeroDeHabitantes()}");
      
             /* pais1.Nombre = "Ecuador";
            pais1.Provincias = new List<string>();
            pais1.Provincias.Add("Galapagos");
            pais1.Provincias.Add("Loja");
            pais1.Provincias.Add("Pichincha");
      
            pais1.Provincias = new List<string>()
            {
                "Carchi",
                "Zamora",
                "Guayas"
            };*/
        }
    }
}

