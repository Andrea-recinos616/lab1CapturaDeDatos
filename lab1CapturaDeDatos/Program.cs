using System;
namespace Laboratorio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int MAX_MATERIAS = 6;

            Console.WriteLine("===== REGISTRO DE ESTUDIANTE =====");

            Console.Write("Nombre completo: ");
            string nombre = Console.ReadLine();

            Console.Write("Edad: ");
            int edad = Convert.ToInt32(Console.ReadLine());

            Console.Write("Carrera: ");
            string carrera = Console.ReadLine();

            Console.Write("Carné o código de estudiante: ");
            string carne = Console.ReadLine();

            Console.Write("Correo electrónico: ");
            string correo = Console.ReadLine();

            Console.Write("Número de teléfono: ");
            string telefono = Console.ReadLine();

            Console.Write("Promedio actual: ");
            double promedio = Convert.ToDouble(Console.ReadLine());

            Console.Write("Número de materias inscritas: ");
            int materias = Convert.ToInt32(Console.ReadLine());

            int edadFutura = edad + 5;

            Console.WriteLine();
            Console.WriteLine("¡Bienvenido/a), " + nombre + "!");

            Console.WriteLine("Dentro de 5 años tendrás aproximadamente " + edadFutura + " años.");

            if (materias < MAX_MATERIAS)
            {
                Console.WriteLine("Aún puedes inscribir más materias.");
            }
            else
            {
                Console.WriteLine("Ya alcanzaste el máximo de materias permitidas.");
            }

            Console.WriteLine();
            Console.WriteLine("===== RESUMEN DEL ESTUDIANTE =====");
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Edad: " + edad);
            Console.WriteLine("Carrera: " + carrera);
            Console.WriteLine("Carné: " + carne);
            Console.WriteLine("Correo: " + correo);
            Console.WriteLine("Teléfono: " + telefono);
            Console.WriteLine("Promedio: " + promedio);
            Console.WriteLine("Materias inscritas: " + materias);

            Console.WriteLine();
            Console.WriteLine("Presione cualquier tecla para salir");
            Console.ReadKey();
            Console.WriteLine("Gracias por utilizar nuestro sistema :)");
        }
    }
}
