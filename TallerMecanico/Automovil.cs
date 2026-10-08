using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_14_09_2026
{
    internal class Automovil
    {
        private string marca;
        private string modelo;
        private string color;
        private string matricula;
        private double nivelCombustible;
        private Usuario mecanico;
        private string descripcionDelProblema;

        public Automovil() { }

        public Automovil(string marca, string modelo, string color, string matricula,
                         double nivelCombustible, Usuario mecanico, string descripcionDelProblema)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.color = color;
            this.matricula = matricula;
            this.nivelCombustible = nivelCombustible;
            this.mecanico = mecanico;
            this.descripcionDelProblema = descripcionDelProblema;
        }

        public void agregarInformacion(string marca, string modelo, string color, string matricula,
                                       double nivelCombustible, Usuario mecanico, string descripcionDelProblema)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.color = color;
            this.matricula = matricula;
            this.nivelCombustible = nivelCombustible;
            this.mecanico = mecanico;
            this.descripcionDelProblema = descripcionDelProblema;
        }

        public void MostrarInformacion()
        {
            Console.WriteLine("================================");
            Console.WriteLine("Información del Automóvil:");
            Console.WriteLine($"Marca: {marca}");
            Console.WriteLine($"Modelo: {modelo}");
            Console.WriteLine($"Color: {color}");
            Console.WriteLine($"Matrícula: {matricula}");
            Console.WriteLine($"Nivel de Combustible: {nivelCombustible} %");
            Console.WriteLine($"Descripción del Problema: {descripcionDelProblema}");

            if (mecanico != null)
                Console.WriteLine($"Mecánico: {mecanico.nombre}");
            else
                Console.WriteLine("Mecánico: Sin asignar");

            Console.WriteLine("================================");
        }
    }
}