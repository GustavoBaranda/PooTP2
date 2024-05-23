using System;
using System.Collections.Generic;
using System.Linq;

namespace PooTP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HistorialDeCierreDiario historial = new HistorialDeCierreDiario();

            bool continuar = true;

            while (continuar)
            {
                Console.WriteLine("\nMenu");
                Console.WriteLine("1. Agregar un servicio");
                Console.WriteLine("2. Mostrar detalles de los servicios");
                Console.WriteLine("3. Salir del Programa\n");
                int opcion;

                while (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    break;
                }

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("\nOpcion 1");
                        AgregarServicios(historial);
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("\nOpcion 2");
                        Console.WriteLine("Detalles de los servicios\n");
                        historial.MostrarServicios();
                        Console.WriteLine("\nContinuar");
                        Console.ReadKey();
                        break;
                    case 3:
                        continuar = false;
                        break;
                    default:
                        Console.WriteLine("\nIngrese un número válido mayor que cero entre 1 y 3.\n");
                        break;
                }
            }
            Console.WriteLine($"\nMonto total facturado: {historial.MontoTotalFacturado()}");
            Console.WriteLine($"Cantidad de servicios siemple: {historial.CantidadDeServiciosSimples()}\n");
            Console.WriteLine("\nMuchas gracias por usar nuestra aplicacion");
            Console.ReadKey();

            static void AgregarServicios(HistorialDeCierreDiario historial)
            {
                while (true)
                {
                    Console.WriteLine("\nAgregar Servicio");
                    Console.WriteLine("1. Entrenamiento personalizado");
                    Console.WriteLine("2. Clase Grupal");
                    Console.WriteLine("3. Venta de suplemento");
                    Console.WriteLine("4. Volver al menu");
                    Console.WriteLine("Seleccionar una opcion\n");

                    int tipoDeServicio;
                    while (!int.TryParse(Console.ReadLine(), out tipoDeServicio))
                    {
                        Console.WriteLine("Opción inválida. Seleccionar una opción válida: \n");
                        Console.WriteLine("1. Entrenamiento personalizado");
                        Console.WriteLine("2. Clase Grupal");
                        Console.WriteLine("3. Venta de suplemento");
                        Console.WriteLine("4. Volver al menu\n");
                    }

                    if (tipoDeServicio == 4) return;
                    Console.Clear();
                    switch (tipoDeServicio)
                    {
                        case 1:
                            List<EntrenamientoPersonalizado> entrenamientoPersonalizado = new List<EntrenamientoPersonalizado>
                            {
                                new EntrenamientoPersonalizado("Pesas", 0),
                                new EntrenamientoPersonalizado("Calestenia", 0),
                                new EntrenamientoPersonalizado("Musculacion", 0),
                                new EntrenamientoPersonalizado("Crossfit", 0)
                            };
                            bool tipoEntrenamientoExistente = false;
                            while (!tipoEntrenamientoExistente)
                            {
                                Console.WriteLine("\nopcion 1");
                                Console.WriteLine("Entrenamiento personalizado\n");
                                List<string> tiposDeEntrenamientos = entrenamientoPersonalizado.Select(e => e._TipoDeEntrenamiento).ToList();
                                Console.WriteLine("Tipos de entrenamientos disponibles:");
                                tiposDeEntrenamientos.ForEach(tipo => Console.Write(tipo + " "));

                                string tipoEntrenamiento = ControlDeString("\nIngrese el tipo de entrenamiento: ");
                                bool existe = entrenamientoPersonalizado.Any(entrenamiento => entrenamiento._TipoDeEntrenamiento.Equals(tipoEntrenamiento, StringComparison.OrdinalIgnoreCase));

                                if (existe)
                                {
                                    int duracionEntrenamiento = ControlDeIntPositivoIntPositivo("Ingrese la duración en minutos: ");
                                    historial.AgregarServicio(new EntrenamientoPersonalizado(tipoEntrenamiento, duracionEntrenamiento));

                                    Console.WriteLine("Entrenamiento personalizado agregado.\n");
                                    historial.MostrarUltimoServicio();

                                    Console.WriteLine("¿Desea agregar otro entrenamiento?");
                                    Console.WriteLine("Escriba 'no' si no quiere agregar mas entrenamientos");
                                    string respuesta = Console.ReadLine();
                                    if (respuesta.Equals("no", StringComparison.OrdinalIgnoreCase))
                                    {
                                        tipoEntrenamientoExistente = true;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine($"El tipo de entrenamiento '{tipoEntrenamiento}' no existe en la lista.");
                                }
                            }
                            Console.WriteLine("Continuar");
                            Console.ReadKey();
                            break;

                        case 2:
                        List<ClaseGrupales> clasesGrupales = new List<ClaseGrupales>
                            {
                                new ClaseGrupales("Yoga", 0, 0),
                                new ClaseGrupales("Zumba", 0, 0),
                                new ClaseGrupales("Salsa", 0, 0),
                                new ClaseGrupales("Spinning", 0, 0)
                            };
                        bool tipoClaseExistente = false;

                        while (!tipoClaseExistente)
                        {
                            Console.WriteLine("\nopcion 2");
                            Console.WriteLine("Clase Grupal\n");
                            List<string> tiposDeClases = clasesGrupales.Select(c => c._tipoClase).ToList();
                            Console.WriteLine("Tipos de clases disponibles:");
                            tiposDeClases.ForEach(tipo => Console.Write(tipo + " "));
                            string tipoClase = ControlDeString("\nIngrese el tipo de clase: ");
                            bool existe = clasesGrupales.Any(clase => clase._tipoClase.Equals(tipoClase, StringComparison.OrdinalIgnoreCase));
                            if (existe)
                            {
                                int duracionClase = ControlDeIntPositivoIntPositivo("Ingrese la duración en minutos: ");
                                int nroParticipantes = ControlDeIntPositivoIntPositivo("Ingrese el número de participantes: ");

                                historial.AgregarServicio(new ClaseGrupales(tipoClase, nroParticipantes, duracionClase));

                                Console.WriteLine("\nClase grupal agregada.\n");
                                historial.MostrarUltimoServicio();

                                Console.WriteLine("¿Desea agregar otra clase?");
                                Console.WriteLine("Escriba 'no' si no quiere agregar mas clases grupales");
                                string respuesta = Console.ReadLine();
                                if (respuesta.Equals("no", StringComparison.OrdinalIgnoreCase))
                                {
                                    tipoClaseExistente = true;
                                }
                            }
                            else
                            {
                                Console.WriteLine($"El tipo de clase '{tipoClase}' No existe en la lista.");
                            }
                        }
                        Console.WriteLine("Continuar");
                        Console.ReadKey();
                        break;

                    case 3:
                        Console.WriteLine("\nopcion 3");
                        Console.WriteLine("Venta de suplemento\n");
                        string nombreSuplemento = ControlDeString("Ingrese el nombre del suplemento: ");
                        double porcentajeGanancia = ControlDeDublePositivo("Ingrese el porcentaje de ganancia: ");
                        double precioLista = ControlDeDublePositivo("Ingrese el precio de lista: ");
                        historial.AgregarServicio(new Suplementos(nombreSuplemento, porcentajeGanancia, precioLista));
                        Console.WriteLine("Suplemento agregado.\n");
                        historial.MostrarUltimoServicio();
                        Console.WriteLine("Continuar");
                        Console.ReadKey();
                        break;

                    default:
                        Console.WriteLine("Opción no válida.");
                        Console.WriteLine("\nContinuar");
                        Console.ReadKey();
                        break;
                    }
                }
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

            static int ControlDeIntPositivoIntPositivo(string mensaje)
            {
                int valor;
                do
                {
                    Console.Write(mensaje);
                } while (!int.TryParse(Console.ReadLine(), out valor) || valor <= 0);
                return valor;
            }

            static double ControlDeDublePositivo(string mensaje)
            {
                double valor;
                do
                {
                    Console.Write(mensaje);
                } while (!double.TryParse(Console.ReadLine(), out valor) || valor <= 0);
                return valor;
            }
        }
    }
}