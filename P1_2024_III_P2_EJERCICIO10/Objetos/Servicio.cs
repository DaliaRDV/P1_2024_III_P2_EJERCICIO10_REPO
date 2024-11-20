using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace P1_2024_III_P2_EJERCICIO10.Objetos
{
    internal class Servicio : EntidadBase

    {
        public string   Descripcion { get; set; }
        public decimal  Costo { get; set; }
        public int      TiempoEstimado { get; set; }
        public string   Garantia { get; set; }
        public string   DescripcionServicio { get; set; }
        public DateTime FechaUltimoServicio { get; set; }

        public override void Agregar()
        {
            base.Agregar();
            WriteLine("Ingrese la descripción del servicio: ");
            Descripcion = ReadLine();
            WriteLine("Ingrese el costo del servicio: ");
            Costo = decimal.Parse(ReadLine());
            WriteLine("Ingrese el tiempo estimado (en horas): ");
            TiempoEstimado = int.Parse(ReadLine());
            WriteLine("Ingrese la garantía del servicio: ");
            Garantia = ReadLine();
            WriteLine("Ingrese la descripción del servicio: ");
            DescripcionServicio = ReadLine();
            WriteLine("Ingrese la fecha del último servicio (dd/MM/yyyy): ");
            FechaUltimoServicio = DateTime.Parse(ReadLine());
            ReadLine();
        }
    }
}
