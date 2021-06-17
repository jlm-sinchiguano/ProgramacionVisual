using System;

namespace miPrimeraApp.console
{
    class Persona
    {
        string nombre;
        int edad;
        bool mayoriaEdad;
        float medida;

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido");

            Console.Write("Ingresa tu Nombre: ");
            var nombre = Console.ReadLine();

            Console.WriteLine("¿Eres mayor de edad?");
            bool afirmacion = bool.Parse(afirmacion);

            Console.WriteLine("Ingresa tu edad");
            var edad = int.Parse(edad);

            Console.WriteLine("¿Cuál es tu estatura?");
            float medida = float.Parse(medida);

            var Persona = new Persona();
            persona.nombre = nombre;
            persona.edad = edad
            persona.mayoriaEdad = afirmacion;
            persona.medida = medida;
            Console.WriteLine("Usted a ingresado la siguiente Informacion");
            Console.Write ("Nombre:" + perosna.nombre);
            Console.Write ("Es mayor de edad: " + persona.mayoriaEdad);
            Console.Write("Su edad es: " + persona.edad) ;
            Console.Write("Su estatura es: " + persona.medida);
            Console.Write("Muchas gracias , digite cualquier tecla para salir")
            Console.Readkey();
            


        }
        public void Saludo (String[] args)
        {
            if (args.Length > 0 )
                Console.WriteLine("Hola {0} {1} {2} {3} " + args[0], args[1], args[2], args[3]);
            else
            {
                Console.WriteLine("Hola desconocido");

            }
            Console.Readkey();
        }
    }
}
