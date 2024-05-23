using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooTP2
{
    internal class Test
    {
        static void Main(string[] args)
        {
            HistorialDeCierreDiario historial = new HistorialDeCierreDiario();
            bool continuar = true;

            while (continuar)
            {
                Console.Clear();
                MostrarMenu();
                int opcion = ObtenerOpcion();

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("\nOpción 1: Agregar un servicio");
                        AgregarServicios(historial);
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("\nOpción 2: Mostrar detalles de los servicios");
                        Console.WriteLine();
                        historial.MostrarServicios();
                        Console.WriteLine("Presione cualquier tecla para continuar...");
                        Console.ReadKey();
                        break;
                    case 3:
                        continuar = false;
                        break;
                    default:
                        Console.WriteLine("\nIngrese un número válido entre 1 y 3.");
                        break;
                }
            }

            MostrarResumen(historial);
        }

        static void MostrarMenu()
        {
            Console.WriteLine("\nMenu");
            Console.WriteLine("1. Agregar un servicio");
            Console.WriteLine("2. Mostrar detalles de los servicios");
            Console.WriteLine("3. Salir del Programa");
        }

        static int ObtenerOpcion()
        {
            int opcion;
            while (true)
            {
                Console.Write("\nSeleccione una opción: ");
                string input = Console.ReadLine();
                if (int.TryParse(input, out opcion) && opcion >= 1 && opcion <= 3)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Entrada no válida. Por favor, ingrese un número entre 1 y 3.");
                }
            }
            return opcion;
        }

        static void AgregarServicios(HistorialDeCierreDiario historial)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("\nAgregar Servicio");
                Console.WriteLine("1. Entrenamiento personalizado");
                Console.WriteLine("2. Clase Grupal");
                Console.WriteLine("3. Venta de suplemento");
                Console.WriteLine("4. Volver al menú");
                Console.Write("\nSeleccionar una opción: ");

                int tipoDeServicio;
                while (!int.TryParse(Console.ReadLine(), out tipoDeServicio) || tipoDeServicio < 1 || tipoDeServicio > 4)
                {
                    Console.WriteLine("Opción inválida. Seleccione una opción válida:");
                    Console.WriteLine("1. Entrenamiento personalizado");
                    Console.WriteLine("2. Clase Grupal");
                    Console.WriteLine("3. Venta de suplemento");
                    Console.WriteLine("4. Volver al menú");
                }

                if (tipoDeServicio == 4) return;

                Console.Clear();
                switch (tipoDeServicio)
                {
                    case 1:
                        Console.WriteLine("\nOpción 1: Entrenamiento personalizado");
                        string tipoEntrenamiento = ControlDeString("Ingrese el tipo de entrenamiento: ");
                        int duracionEntrenamiento = ControlDeIntPositivo("Ingrese la duración en minutos: ");
                        historial.AgregarServicio(new EntrenamientoPersonalizado(tipoEntrenamiento, duracionEntrenamiento));
                        Console.WriteLine("Entrenamiento personalizado agregado.");
                        historial.MostrarUltimoServicio();
                        Console.WriteLine("Presione cualquier tecla para continuar...");
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.WriteLine("\nOpción 2: Clase Grupal");
                        string tipoClase = ControlDeString("Ingrese el tipo de clase: ");
                        int duracionClase = ControlDeIntPositivo("Ingrese la duración en minutos: ");
                        int nroParticipantes = ControlDeIntPositivo("Ingrese el número de participantes: ");
                        historial.AgregarServicio(new ClaseGrupales(tipoClase, nroParticipantes, duracionClase));
                        Console.WriteLine("Clase grupal agregada.");
                        historial.MostrarUltimoServicio();
                        Console.WriteLine("Presione cualquier tecla para continuar...");
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.WriteLine("\nOpción 3: Venta de suplemento");
                        string nombreSuplemento = ControlDeString("Ingrese el nombre del suplemento: ");
                        double porcentajeGanancia = ControlDeDoublePositivo("Ingrese el porcentaje de ganancia: ");
                        double precioLista = ControlDeDoublePositivo("Ingrese el precio de lista: ");
                        historial.AgregarServicio(new Suplementos(nombreSuplemento, porcentajeGanancia, precioLista));
                        Console.WriteLine("Suplemento agregado.");
                        historial.MostrarUltimoServicio();
                        Console.WriteLine("Presione cualquier tecla para continuar...");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        Console.WriteLine("Presione cualquier tecla para continuar...");
                        Console.ReadKey();
                        break;
                }
            }
        }

        static void MostrarResumen(HistorialDeCierreDiario historial)
        {
            Console.WriteLine($"\nMonto total facturado: $ {historial.MontoTotalFacturado().ToString("F2")}");
            Console.WriteLine($"Cantidad de servicios simples: {historial.CantidadDeServiciosSimples()}");
            Console.WriteLine("\nMuchas gracias por usar nuestra aplicación");
            Console.ReadKey();
        }

        static string ControlDeString(string mensaje)
        {
            string dato;
            do
            {
                Console.Write(mensaje);
                dato = Console.ReadLine().Trim();
            } while (string.IsNullOrEmpty(dato));
            return dato;
        }

        static int ControlDeIntPositivo(string mensaje)
        {
            int valor;
            do
            {
                Console.Write(mensaje);
            } while (!int.TryParse(Console.ReadLine(), out valor) || valor <= 0);
            return valor;
        }

        static double ControlDeDoublePositivo(string mensaje)
        {
            double valor;
            CultureInfo cultura = CultureInfo.GetCultureInfo("es-Es");
            do
            {
                Console.Write(mensaje);
            } while (!double.TryParse(Console.ReadLine().Replace('.',','),NumberStyles.Float,cultura, out valor) || valor <= 0);
            return valor;
        }
    }
}