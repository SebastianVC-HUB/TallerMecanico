using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_14_09_2026
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ingrese el nombre del mecánico:");
            string nombreMecanico = Console.ReadLine();

            Console.WriteLine("Ingrese la edad del mecánico:");
            string edadMecanico = Console.ReadLine();

            Usuario mecanico1 = new Usuario(nombreMecanico);
            mecanico1.ModificarEdad(edadMecanico);

            Console.WriteLine();


            Automovil automovil1 = new Automovil();

            Console.WriteLine("Ingrese la marca del automóvil:");
            string marca = Console.ReadLine();

            Console.WriteLine("Ingrese el modelo del automóvil:");
            string modelo = Console.ReadLine();

            Console.WriteLine("Ingrese el color del automóvil:");
            string color = Console.ReadLine();

            Console.WriteLine("Ingrese la matrícula del automóvil:");
            string matricula = Console.ReadLine();

            Console.WriteLine("Ingrese en % el nivel de combustible del automóvil:");
            double nivelCombustible = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la descripción del problema:");
            string descripcionDelProblema = Console.ReadLine();


            automovil1.agregarInformacion(marca, modelo, color, matricula,
                                          nivelCombustible, mecanico1, descripcionDelProblema);


            Console.WriteLine();
            automovil1.MostrarInformacion();
        }
    }
}