using System;

namespace primerPrograma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido Estudiante");

            Console.Write("Ingrese su Nombre: ");
            string nombre = Console.ReadLine();

            int edad = IngresarEdad();

            Console.Write("Ingrese su Fecha de Nacimiento: ");
            string fechaCumpleanos = Console.ReadLine();
            DateTime fechaCumpleanos1 = DateTime.Parse(fechaCumpleanos);

            float estatura = IngresarEstatura();

            Console.Write("¿ Tiene mas de 18 años ? ");
            bool esMayorEdad = Console.ReadLine().ToUpper() == "SI";

            Console.Write("Ingrese su nota Parcial 1:  ");
            string notaParcial = Console.ReadLine();
            double notaParcial1 = double.Parse(notaParcial);

            Console.Write("Ingrese su color favorito: ");
            string colorFavorito = Console.ReadLine();

            Console.Write("Ingrese su Cedula: ");
            string cedula = Console.ReadLine();

            Console.Write("Ingrese su Talla de zapato: ");
            string tallaZapato = Console.ReadLine();
            float tallaZapato1 = float.Parse(tallaZapato);

            Console.Write("¿ Cual es su animal favorito ? ");
            string animalFavorito = Console.ReadLine();

            var persona =
                new Persona {
                    nombre = nombre,
                    edad = edad,
                    fechaCumpleanos = fechaCumpleanos1,
                    estatura = estatura,
                    esMayorEdad = esMayorEdad,
                    notaParcial = notaParcial1,
                    colorFavorito = colorFavorito,
                    cedula = cedula,
                    tallaZapato = tallaZapato1,
                    animalFavorito = animalFavorito
                };

            Console.WriteLine("La información ingresada fue : ");
            Console.Write($"Su Nombre es: {persona.nombre} ");
            Console.Write($"Su Edad es: {persona.edad} ");
            Console.Write($"Su Fecha de cumpleaños es: {persona.fechaCumpleanos} ");
            Console.Write($"Su Estatura es: {persona.estatura} ");
            Console.Write($"Mayoria de edad: {persona.esMayorEdad} ");
            Console.Write($"Su Nota parcial 1 es: {persona.notaParcial} ");
            Console.Write($"Su color favorito es: {persona.colorFavorito} ");
            Console.Write($"Su cedula es: {persona.cedula} ");
            Console.Write($"Su talla de zapato es: {persona.tallaZapato} ");
            Console.Write($"Su animal favorito es: {persona.animalFavorito} ");
            Console.WriteLine("Gracias por su Participación");
            Console.ReadKey();
        }

        static int IngresarEdad()
        {
            Console.Write("Ingrese su Edad: ");
            int edad1;
            while (true)
            {
                string edad = Console.ReadLine();
                if (!int.TryParse(edad, out edad1))
                {
                    Console.Write("Ingrese un numero entero: ");
                }
                else
                {
                    break;
                }
            }
            return edad1;
        }

        static float IngresarEstatura()
        {
            Console.Write("Ingrese su Estatura: ");
            float estatura1;
            while (true)
            {
                string estatura = Console.ReadLine();
                if (!float.TryParse(estatura, out estatura1))
                {
                    Console.Write("Ingrese un numero decimal: ");
                }
                else
                {
                    break;
                }
            }
            return estatura1;
        }
    }
}
