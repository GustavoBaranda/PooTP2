using System;
using System.Collections.Generic;
using System.Linq;

namespace PooTP2
{
    internal class Test
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\n\n +---- El proyecto fue creado por el grupo nro. 5 ---+");
            Console.WriteLine(" |                Marcelo Galimberti                 |");
            Console.WriteLine(" |                 Catriel Escobar                   |");
            Console.WriteLine(" |                 M. Eugenia Bava                   |");
            Console.WriteLine(" |                 Alejandro Abadi                   |");
            Console.WriteLine(" |                 Gustavo Baranda                   |");
            Console.WriteLine(" +---------------------------------------------------+");

            ClubDeportivo club = new ClubDeportivo();

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
                        AgregarServiciosClub(club);
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("\nOpcion 2");
                        Console.WriteLine("Detalles de los servicios\n");
                        club.MostrarServicios();
                        Console.WriteLine($"Monto total facturado: $ {club.MontoTotalFacturado().ToString("F2")}");
                        Console.WriteLine($"Cantidad de servicios simples: {club.CantidadDeServiciosSimples()}");
                        Console.WriteLine("Presione enter para volver al menu principal...");
                        Console.ReadKey();
                        break;
                    case 3:
                        continuar = false;
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        Console.WriteLine("Presione enter para continuar...");
                        Console.ReadKey();
                        break;
                }
            }
            MostrarResumen(club);

            static void AgregarServiciosClub(ClubDeportivo club)
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
                                new EntrenamientoPersonalizado("Calistenia", 0),
                                new EntrenamientoPersonalizado("Musculacion", 0),
                                new EntrenamientoPersonalizado("Crossfit", 0)
                            };
                            bool tipoEntrenamientoExistente = false;
                            while (!tipoEntrenamientoExistente)
                            {
                                Console.WriteLine("\nopcion 1");
                                Console.WriteLine("Entrenamiento personalizado");
                                List<string> tiposDeEntrenamientos = entrenamientoPersonalizado.Select(e => e.TipoDeEntrenamiento).ToList();
                                Console.WriteLine("Tipos de entrenamientos disponibles:\n");
                                tiposDeEntrenamientos.ForEach(tipo => Console.Write(tipo + " "));

                                string tipoEntrenamiento = ControlDeString("\n\nIngrese el tipo de entrenamiento: ");
                                bool existe = entrenamientoPersonalizado.Any(entrenamiento => entrenamiento.TipoDeEntrenamiento.Equals(tipoEntrenamiento, StringComparison.OrdinalIgnoreCase));

                                if (existe)
                                {
                                    int duracionEntrenamiento = ControlDeIntPositivoIntPositivo("Ingrese la duración en minutos: ");
                                    club.AgregarServicio(new EntrenamientoPersonalizado(tipoEntrenamiento, duracionEntrenamiento));

                                    Console.WriteLine("Entrenamiento personalizado agregado.\n");
                                    club.MostrarUltimoServicio();

                                    Console.WriteLine("¿Desea agregar otro entrenamiento?");
                                    Console.WriteLine("Presione enter para continuar...");
                                    Console.WriteLine("O escriba 'no' para volver al menu de agregar servivios");
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
                            Console.WriteLine("Clase Grupal");
                            List<string> tiposDeClases = clasesGrupales.Select(c => c.TipoClase).ToList();
                            Console.WriteLine("Tipos de clases disponibles:\n");
                            tiposDeClases.ForEach(tipo => Console.Write(tipo + " "));
                            string tipoClase = ControlDeString("\n\nIngrese el tipo de clase: ");
                            bool existe = clasesGrupales.Any(clase => clase.TipoClase.Equals(tipoClase, StringComparison.OrdinalIgnoreCase));
                            if (existe)
                            {
                                int duracionClase = ControlDeIntPositivoIntPositivo("Ingrese la duración en minutos: ");
                                int nroParticipantes = ControlDeIntPositivoIntPositivo("Ingrese el número de participantes: ");

                                club.AgregarServicio(new ClaseGrupales(tipoClase, nroParticipantes, duracionClase));

                                Console.WriteLine("Clase grupal agregada.\n");
                                club.MostrarUltimoServicio();

                                Console.WriteLine("¿Desea agregar otra clase?");
                                Console.WriteLine("Presione enter para continuar...");
                                Console.WriteLine("O escriba 'no' para volver al menu de agregar servivios");
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
                        break;

                    case 3:
                        List<Suplementos> suplementos = new List<Suplementos>
                        {
                            new Suplementos("Proteinas", 0,0),
                            new Suplementos("Hierro", 0,0),
                            new Suplementos("Magnesio", 0,0),
                            new Suplementos("Calcio", 0,0)
                        };

                        bool suplementoExistente = false;
                    
                        while (!suplementoExistente)
                        {
                            Console.WriteLine("\nopcion 3");
                            Console.WriteLine("Venta de suplemento");
                            List<string> tiposDeSuplemento = suplementos.Select(s => s.Nombre).ToList();
                            Console.WriteLine("Tipos de suplementos disponibles:\n");
                            tiposDeSuplemento.ForEach(tipo => Console.Write(tipo +" "));
                            string nombreSuplemento = ControlDeString("\n\nIngrese el nombre del suplemento: ");
                            bool existe = suplementos.Any(clase => clase.Nombre.Equals(nombreSuplemento, StringComparison.OrdinalIgnoreCase));
                            if (existe)
                            {
                                double porcentajeGanancia = ControlDeDublePositivo("Ingrese el porcentaje de ganancia: ");
                                double precioLista = ControlDeDublePositivo("Ingrese el precio de lista: ");

                                club.AgregarServicio(new Suplementos(nombreSuplemento, porcentajeGanancia, precioLista));

                                Console.WriteLine("Suplemento agregado.\n");
                                club.MostrarUltimoServicio();
                    
                                Console.WriteLine("¿Desea agregar otro Suplemento?");
                                Console.WriteLine("Presione enter para continuar...");
                                Console.WriteLine("O escriba 'no' para volver al menu de agregar servivios");
                                string respuesta = Console.ReadLine();
                                if (respuesta.Equals("no", StringComparison.OrdinalIgnoreCase))
                                {
                                    suplementoExistente = true;
                                }
                            }
                            else
                            {
                                Console.WriteLine($"El tipo de clase '{nombreSuplemento}' No existe en la lista.");
                            }
                        }
                        break;

                    default:
                        Console.WriteLine("Opción no válida.");
                        Console.WriteLine("Presione enter para continuar...");
                        Console.ReadKey();
                        break;
                    }
                }
            }

            static void MostrarResumen(ClubDeportivo club)
            {
                Console.WriteLine($"\nMonto total facturado: $ {club.MontoTotalFacturado().ToString("F2")}");
                Console.WriteLine($"Cantidad de servicios simples: {club.CantidadDeServiciosSimples()}");
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
                } while (!double.TryParse(Console.ReadLine().Replace('.',','), out valor) || valor <= 0);
                return valor;
            }
        }
    }
}