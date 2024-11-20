using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace P1_2024_III_P2_EJERCICIO10.Objetos
{
    internal class Factura : EntidadBase
    {
        List<Servicio> ListaServicios = new List<Servicio>();
        List<Repuestos> ListaRepuestos = new List<Repuestos>();

        public string    NumeroFactura { get; set; }
        public DateTime FechaEmision { get; set; }
        public int     ClienteID { get; set; }
        public string  RTN { get; set; }
        public decimal Subtotal { get; set; }
        public decimal Impuesto { get; set; }
        public decimal Total { get; set; }

        public override void Agregar()
        {
            base.Agregar();
            WriteLine("Ingrese el número de factura: ");
            NumeroFactura = ReadLine();
            WriteLine("Ingrese la fecha de emisión (dd/MM/yyyy): ");
            FechaEmision = DateTime.Parse(ReadLine());
            WriteLine("Ingrese el RTN del cliente: ");
            RTN = ReadLine();

            Subtotal = ObtenerSubtotal();
            Impuesto = Subtotal * 0.15m;
            Total = Subtotal + Impuesto;

            MostrarFactura();
        }

        private decimal ObtenerSubtotal()
        {
            decimal subtotalServicios = 0;
            decimal subtotalRepuestos = 0;

            if (ListaServicios != null && ListaServicios.Count > 0)
            {
                foreach (var servicio in ListaServicios)
                {
                    subtotalServicios += servicio.Costo;
                }
            }

            if (ListaRepuestos != null && ListaRepuestos.Count > 0)
            {
                foreach (var repuesto in ListaRepuestos)
                {
                    subtotalRepuestos += repuesto.Costo;
                }
            }

            return subtotalServicios + subtotalRepuestos;
        }

        public void AgregarServicio(Servicio servicio)
        {
            ListaServicios.Add(servicio);
        }

        public void AgregarRepuesto(Repuestos repuesto)
        {
            ListaRepuestos.Add(repuesto);
        }

        public void MostrarFactura()
        {
            WriteLine("\n--- Factura ---");
            WriteLine($"Número de Factura: {NumeroFactura}");
            WriteLine($"Fecha de Emisión:  {FechaEmision:dd/MM/yyyy}");
            WriteLine($"Subtotal:          {Subtotal:C}");
            WriteLine($"Impuesto (15%):    {Impuesto:C}");
            WriteLine($"Total:             {Total:C}");

            ReadLine();
        }
    }
}
