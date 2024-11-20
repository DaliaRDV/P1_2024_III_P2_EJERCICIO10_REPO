using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace P1_2024_III_P2_EJERCICIO10.Objetos
{
    internal sealed class Vehiculo : EntidadBase
    {
        public string  Marca { get; set; }
        public string  Modelo { get; set; }
        public int     Año { get; set; }
        public string  Placa { get; set; }
        public int     Kilometraje { get; set; }
        public string TipoCombustible { get; set; }
        public override void Agregar()

        {
            base.Agregar();
            WriteLine("Ingrese la marca del vehículo: ");
            Marca = ReadLine();
            WriteLine("Ingrese el modelo del vehículo: ");
            Modelo = ReadLine();
            WriteLine("Ingrese el año del vehículo: ");
            Año = int.Parse(ReadLine());
            WriteLine("Ingrese la placa del vehículo: ");
            Placa = ReadLine();
            WriteLine("Ingrese el kilometraje del vehículo: ");
            Kilometraje = int.Parse(ReadLine());
            WriteLine("Ingrese el tipo de combustible del vehículo: ");
            TipoCombustible = ReadLine();
            ReadLine();

        }
    }
}
