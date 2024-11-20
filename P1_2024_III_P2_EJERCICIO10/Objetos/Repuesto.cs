using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace P1_2024_III_P2_EJERCICIO10.Objetos
{
    internal class Repuestos : EntidadBase
    {
        public string   Codigo { get; set; }
        public decimal  Costo { get; set; }
        public string   Proveedor { get; set; }
        public DateTime FechaCompra { get; set; }
        public int      Stock { get; set; }
        public string   Categoria { get; set; }

        public override void Agregar()
        {
            base.Agregar();
            WriteLine("Ingrese el código del repuesto: ");
            Codigo = ReadLine();
            WriteLine("Ingrese el costo del repuesto: ");
            Costo = decimal.Parse(ReadLine());
            WriteLine("Ingrese el proveedor del repuesto: ");
            Proveedor = ReadLine();
            WriteLine("Ingrese la fecha de compra (dd/MM/yyyy): ");
            FechaCompra = DateTime.Parse(ReadLine());
            WriteLine("Ingrese la cantidad en stock: ");
            Stock = int.Parse(ReadLine());
            WriteLine("Ingrese la categoría del repuesto: ");
            Categoria = ReadLine();
            ReadLine();
        }
    }
}
