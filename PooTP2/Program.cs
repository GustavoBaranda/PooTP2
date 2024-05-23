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
                            Console.WriteLine("\nopcion 1");
                            Console.WriteLine("Entrenamiento personalizado\n");
                            string tipoEntrenamiento = ControlDeString("Ingrese el tipo de entrenamiento: ");
                            int duracionEntrenamiento = ControlDeIntPositivoIntPositivo("Ingrese la duración en minutos: ");
                            historial.AgregarServicio(new EntrenamientoPersonalizado(tipoEntrenamiento, duracionEntrenamiento));
                            Console.WriteLine("Entrenamiento personalizado agregado.\n");
                            historial.MostrarUltimoServicio();
                            Console.WriteLine("Continuar");
                            Console.ReadKey();
                            break;

                        case 2:
                            Console.WriteLine("\nopcion 2");
                            Console.WriteLine("Clase Grupal\n");
                            string tipoClase = ControlDeString("\nIngrese el tipo de clase: ");
                            int duracionClase = ControlDeIntPositivoIntPositivo("Ingrese la duración en minutos: ");
                            int nroParticipantes = ControlDeIntPositivoIntPositivo("Ingrese el número de participantes: ");
                            historial.AgregarServicio(new ClaseGrupales(tipoClase, nroParticipantes, duracionClase));
                            Console.WriteLine("\nClase grupal agregada.\n");
                            historial.MostrarUltimoServicio();
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