using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace P1_2024_III_P2_EJERCICIO10.Objetos
{
internal abstract class EntidadBase
    {
        public int ID { get; set; }
        public string Nombre { get; set; }

        public virtual void Agregar()
        {
            WriteLine("Agregando entidad base...");
        }

        public virtual void Buscar()
        {
            WriteLine("Buscando entidad base...");
        }

        public virtual void Listar()
        {
            WriteLine("Listando entidades base...");
            ReadLine();
        }
    }

}
