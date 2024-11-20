using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using P1_2024_III_P2_EJERCICIO10.Objetos;
using static System.Console;

namespace P1_2024_III_P2_EJERCICIO10 

{
    class Program
    {
        static void Main(string[] arg)
        {
            int opcion;
            do
            {
                Clear();
                WriteLine("===== Menú de Opciones =====");
                WriteLine     ("1. Agregar"    );
                WriteLine     ("2. Buscar"     );
                WriteLine     ("3. Actualizar");
                WriteLine     ("4. Eliminar"  );
                WriteLine     ("5. Listar"    );
                WriteLine     ("6. Salir"     );
                WriteLine("Seleccione una opción: ");
                if (!int.TryParse(ReadLine(), out opcion))
                {
                    WriteLine("Entrada inválida. Por favor, ingrese un número.");
                    continue;
                }

                switch (opcion)
                {
                    case 1:
                        AgregarEntidad();
                        break;
                    case 2:
                        BuscarEntidad();
                        break;
                    case 3:
                        ActualizarEntidad();
                        break;
                    case 4:
                        EliminarEntidad();
                        break;
                    case 5:
                        ListarEntidades();
                        break;
                    case 6:
                        WriteLine("Saliendo del programa...");
                        break;
                    default:
                        WriteLine("Opción inválida. Intente de nuevo.");
                        break;
                }

                WriteLine("Presione cualquier tecla para continuar...");
                ReadKey();
            } while (opcion != 6);
        }

        static void AgregarEntidad()
        {
            WriteLine("Seleccione la clase para agregar:");
            WriteLine("1-Cliente, 2-Mecánico, 3-Vehículo, 4-Repuestos, 5-Servicio, 6-Factura");
            if (!int.TryParse(ReadLine(), out int clase))
            {
                WriteLine("Entrada inválida.");
                return;
            }

            switch (clase)
            {
                case 1:
                    Cliente cliente = new Cliente();
                    cliente.Agregar();
                    GuardarEnJson(cliente, "clientes.json");
                    break;
                case 2:
                    Mecanico mecanico = new Mecanico();
                    mecanico.Agregar();
                    GuardarEnJson(mecanico, "mecanicos.json");
                    break;
                case 3:
                    Vehiculo vehiculo = new Vehiculo();
                    vehiculo.Agregar();
                    GuardarEnJson(vehiculo, "vehiculos.json");
                    break;
                case 4:
                    Repuestos repuestos = new Repuestos();
                    repuestos.Agregar();
                    GuardarEnJson(repuestos, "repuestos.json");
                    break ;
                case 5:
                    Servicio servicio = new Servicio();
                    servicio.Agregar();
                    GuardarEnJson(servicio, "servicios.json");
                    break;
                case 6:
                    Factura factura = new Factura();
                    factura.Agregar();
                    GuardarEnJson(factura, "facturas.json");

                    break;
                default:
                    WriteLine("Clase no reconocida.");
                    break;
            }
        }

        static void BuscarEntidad()
        {
            WriteLine("Seleccione la clase para buscar:");
            WriteLine("1-Cliente, 2-Mecánico, 3-Vehículo, 4-Repuestos, 5-Servicio, 6-Factura");
            if (!int.TryParse(ReadLine(), out int clase))
            {
                WriteLine("Entrada inválida.");
                return;
            }

            Write("Ingrese el ID a buscar: ");
            if (!int.TryParse(ReadLine(), out int id))
            {
                WriteLine("Entrada inválida.");
                return;
            }

            switch (clase)
            {
                case 1:
                    BuscarEnJson<Cliente>("clientes.json", id);
                    break;
                case 2:
                    BuscarEnJson<Mecanico>("mecanicos.json", id);
                    break;
                case 3:
                    BuscarEnJson<Vehiculo>("vehiculos.json", id);
                    break;
                case 4:
                    BuscarEnJson<Repuestos>("repuestos.json", id);
                    break;
                case 5:
                    BuscarEnJson<Servicio>("servicios.json", id);
                    break;
                case 6:
                    BuscarEnJson<Factura> ("facturas.json", id);
                    break;
                default:
                    WriteLine("Clase no reconocida.");
                    break;
            }
        }

        static void ActualizarEntidad()
        {
            WriteLine("Seleccione la clase para actualizar:");
            WriteLine("1-Cliente, 2-Mecánico, 3-Vehículo, 4-Repuestos, 5-Servicio, 6-Factura");
            if (!int.TryParse(ReadLine(), out int clase))
            {
                WriteLine("Entrada inválida.");
                return;
            }

            Write("Ingrese el ID a actualizar: ");
            if (!int.TryParse(ReadLine(), out int id))
            {
                WriteLine("Entrada inválida.");
                return;
            }

            switch (clase)
            {
                case 1:
                    ActualizarEnJson<Cliente>("clientes.json", id);
                    break;
                case 2:
                    ActualizarEnJson<Mecanico>("mecanicos.json", id);
                    break;
                case 3:
                    ActualizarEnJson<Vehiculo>("vehiculos.json", id);
                    break;
                case 4:
                    ActualizarEnJson<Repuestos>("repuestos.json", id);
                    break;
                case 5:
                    ActualizarEnJson<Servicio>("servicios.json", id);
                    break;
                case 6:
                    ActualizarEnJson<Factura>("facturas.json", id);
                    break;
                default:
                    WriteLine("Clase no reconocida.");
                    break;
            }
        }

        static void EliminarEntidad()
        {
            WriteLine("Seleccione la clase para eliminar:");
            WriteLine("1-Cliente, 2-Mecánico, 3-Vehículo, 4-repuestos, 5-Servicio, 6-Factura");
            if (!int.TryParse(ReadLine(), out int clase))
            {
                WriteLine("Entrada inválida.");
                return;
            }

            Write("Ingrese el ID a eliminar: ");
            if (!int.TryParse(ReadLine(), out int id))
            {
                WriteLine("Entrada inválida.");
                return;
            }

            switch (clase)
            {
                case 1:
                    EliminarEnJson<Cliente>("clientes.json", id);
                    break;
                case 2:
                    EliminarEnJson<Mecanico>("mecanicos.json", id);
                    break;
                case 3:
                    EliminarEnJson<Vehiculo>("vehiculos.json", id);
                    break;
                case 4:
                    EliminarEnJson<Repuestos>("repuestos.json", id);
                    break;
                case 5:
                    EliminarEnJson<Servicio>("servicios.json", id);
                    break;
                case 6:
                    EliminarEnJson<Factura>("facturas.json", id);
                    break;
                default:
                    WriteLine("Clase no reconocida.");
                    break;
            }
        }

        static void ListarEntidades()
        {
            WriteLine("Seleccione la clase para listar:");
            WriteLine("1-Cliente, 2-Mecánico, 3-Vehículo, 4-repuestos, 5-Servicio, 6-Factura");
            if (!int.TryParse(ReadLine(), out int clase))
            {
                WriteLine("Entrada inválida.");
                return;
            }

            switch (clase)
            {
                case 1:
                    ListarDesdeJson<Cliente>("clientes.json");
                    break;
                case 2:
                    ListarDesdeJson<Mecanico>("mecanicos.json");
                    break;
                case 3:
                    ListarDesdeJson<Vehiculo>("vehiculos.json");
                    break;
                case 4:
                    ListarDesdeJson<Repuestos>("repuestos.json");
                    break;
                case 5:
                    ListarDesdeJson<Servicio>("servicios.json");
                    break;
                case 6:
                    ListarDesdeJson<Factura>("facturas.json");
                    break;
                default:
                    WriteLine("Clase no reconocida.");
                    break;
            }
        }

        // Métodos para manipular JSON
        static void GuardarEnJson<T>(T entidad, string archivo)
        {
            List<T> lista = CargarDesdeJson<T>(archivo);
            if (lista.Count >= 100)
            {
                WriteLine("No se pueden agregar más registros. Límite alcanzado.");
                return;
            }

            lista.Add(entidad);
            File.WriteAllText(archivo, JsonConvert.SerializeObject(lista, Formatting.Indented));
            WriteLine("Entidad guardada correctamente.");
        }

        static List<T> CargarDesdeJson<T>(string archivo)
        {
            if (File.Exists(archivo))
            {
                var contenido = File.ReadAllText(archivo);
                return JsonConvert.DeserializeObject<List<T>>(contenido) ?? new List<T>();
            }
            return new List<T>();
        }

        static void BuscarEnJson<T>(string archivo, int id) where T : EntidadBase
        {
            var lista = CargarDesdeJson<T>(archivo);
            var entidad = lista.Find(e => e.ID == id);
            if (entidad != null)
            {
                WriteLine("Entidad encontrada:");
                WriteLine(JsonConvert.SerializeObject(entidad, Formatting.Indented));
            }
            else
            {
                WriteLine("Entidad no encontrada.");
            }
        }

        static void ActualizarEnJson<T>(string archivo, int id) where T : EntidadBase, new()
        {
            var lista = CargarDesdeJson<T>(archivo);
            var indice = lista.FindIndex(e => e.ID == id);

            if (indice != -1)
            {
                WriteLine("Actualizando entidad...");
                T nuevaEntidad = new T();
                nuevaEntidad.Agregar();
                lista[indice] = nuevaEntidad;
                File.WriteAllText(archivo, JsonConvert.SerializeObject(lista, Formatting.Indented));
                WriteLine("Entidad actualizada correctamente.");
            }
            else
            {
                WriteLine("Entidad no encontrada.");
            }
        }

        static void EliminarEnJson<T>(string archivo, int id) where T : EntidadBase
        {
            var lista = CargarDesdeJson<T>(archivo);
            var entidad = lista.Find(e => e.ID == id);

            if (entidad != null)
            {
                lista.Remove(entidad);
                File.WriteAllText(archivo, JsonConvert.SerializeObject(lista, Formatting.Indented));
                WriteLine("Entidad eliminada correctamente.");
            }
            else
            {
                WriteLine("Entidad no encontrada.");
            }
        }

        static void ListarDesdeJson<T>(string archivo)
        {
            var lista = CargarDesdeJson<T>(archivo);
            if (lista.Count > 0)
            {
                WriteLine("Listado de entidades:");
                foreach (var entidad in lista)
                {
                    WriteLine(JsonConvert.SerializeObject(entidad, Formatting.Indented));
                }
            }
            else
            {
                WriteLine("No hay entidades para listar.");
            }
        }
    }
}