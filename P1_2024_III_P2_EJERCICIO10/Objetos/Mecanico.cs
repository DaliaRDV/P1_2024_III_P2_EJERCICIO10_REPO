using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace P1_2024_III_P2_EJERCICIO10.Objetos
{
    internal class Mecanico : EntidadBase, IPersona, IEmpleado
    {
        public DateTime FechaContratacion { get; set; }
        public string Especialidad { get; set; }
        public bool Disponibilidad { get; set; }
        public int Experiencia { get; set; }
        public decimal CostoPorHora { get; set; }
        public string Horario { get; set; }
        public decimal Salario { get; set; }

        public override void Agregar()
        {
            base.Agregar();
            WriteLine("Ingrese la especialidad del mecánico:    ");
            Especialidad = ReadLine();
            WriteLine("¿El mecánico está disponible? (si/no):  ");
            Disponibilidad = bool.Parse(ReadLine());
            WriteLine("Ingrese los años de experiencia del mecánico:  ");
            Experiencia = int.Parse(ReadLine());
            WriteLine("Ingrese el costo por hora del mecánico:  ");
            CostoPorHora = decimal.Parse(ReadLine());
            WriteLine("Ingrese el horario del mecánico:  ");
            Horario = ReadLine();
            WriteLine("Ingrese el salario del mecánico:  ");
            Salario = decimal.Parse(ReadLine());
        }

        public decimal CalcularSalario()
        {
            throw new NotImplementedException();
        }

        public void MostrarInformacion()
        {
            WriteLine($"Mecánico: {Nombre}, Fecha de Contratación: {FechaContratacion.ToShortDateString()}");
        }

        public void RealizarTarea()
        {
            WriteLine($"{Nombre} está realizando una tarea.");
        }
    }
}
