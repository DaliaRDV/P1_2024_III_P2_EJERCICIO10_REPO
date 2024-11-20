using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace P1_2024_III_P2_EJERCICIO10.Objetos
{
    internal class Cliente : EntidadBase, IPersona, IContacto
    {
        public string   Telefono { get; set; }
        public string   Id { get; set; }
        public string   Direccion { get; set; }
        public string   CorreoElectronico { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string   TipoCliente { get; set; }

        public override void Agregar()
        {
            base.Agregar();
            WriteLine("Ingrese el nombre del cliente: ");
            Nombre = ReadLine();
            WriteLine("Ingrese el Id del cliente: ");
            Id = ReadLine();
            WriteLine("Ingrese el teléfono del cliente: ");
            Telefono = ReadLine();
            WriteLine("Ingrese la dirección del cliente: ");
            Direccion = ReadLine();
            WriteLine("Ingrese el correo electrónico del cliente: ");
            CorreoElectronico = ReadLine();
            WriteLine("Ingrese la fecha de registro del cliente (dd/MM/yyyy): ");
            FechaRegistro = DateTime.Parse(ReadLine());
        }

        public void MostrarInformacion()
        {
            WriteLine($"Cliente: {Nombre}, Id {Id}, Teléfono: {Telefono}, Dirección: {Direccion}, Correo: {CorreoElectronico}");
        }
    }
}
