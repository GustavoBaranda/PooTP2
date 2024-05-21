using System;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

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
                Console.WriteLine("Menu");
                Console.WriteLine("1. Agregar un servicio");
                Console.WriteLine("2. Mostrar detalles de los servicio");
                Console.WriteLine("3. Salir del Programa");
                int opcion;

                while (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    break;
                }

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("opcion 1");
                        AgregarServicios(historial);
                        break;
                    case 2:
                        Console.WriteLine("opcion 2");
                        break;
                    case 3:
                        continuar = false;
                        break;
                    default:
                        Console.WriteLine("Ingrese un número válido mayor que cero entre 1 y 3.\n");
                        break;
                }
            }
            Console.WriteLine($"Monto totalfacturado: {historial.MontoTotalFacturado()}");
            Console.WriteLine($"Cantidad de servicios siemple: {historial.CantidadDeServiciosSimples()}");

            static void AgregarServicios(HistorialDeCierreDiario historial)
            {

                Console.WriteLine("Agregar Servicio");
                Console.WriteLine("1. Entrenamiento personalizado");
                Console.WriteLine("2. Clase Grupal");
                Console.WriteLine("3. Venta de suplemento");
                Console.WriteLine("4. Volver al menu");
                Console.WriteLine("Selecionar una opcion\n");

                int tipoDeServicio;

                while (!int.TryParse(Console.ReadLine(), out tipoDeServicio) || tipoDeServicio <= 0 || tipoDeServicio >= 5)
                {
                    Console.WriteLine("Agregar Servicio");
                    Console.WriteLine("1. Entrenamiento personalizado");
                    Console.WriteLine("2. Clase Grupal");
                    Console.WriteLine("3. Venta de suplemento");
                    Console.WriteLine("4. Volver al menu");
                    Console.WriteLine("Selecionar una opcion\n");
                }

                if (tipoDeServicio == 4) return;


                string tipo;
                while (true)
                {
                    Console.WriteLine("Ingrese el tipo de entrenamiento: ");
                    tipo = Console.ReadLine().Trim();
                    if (!string.IsNullOrEmpty(tipo))
                    {
                        break;
                    }
                }

                int duracion;
                while (!int.TryParse(Console.ReadLine(), out duracion) || duracion <= 0)
                { 
                    Console.WriteLine("Ingrese duracion en minutos: ");
                }

                if (tipoDeServicio == 1)
                {
                    historial.AgregarServicio(new EntrenamientoPersonalizado(tipo, duracion));
                    Console.WriteLine();
                }
                else if (tipoDeServicio == 2)
                {
                    int nroParticipante;
                    while (!int.TryParse(Console.ReadLine(), out nroParticipante) || nroParticipante <= 0)
                    {
                        Console.WriteLine("Ingrese el numero de participante");
                    }
                    historial.AgregarServicio(new ClaseGrupales(tipo, nroParticipante, duracion));
                }
                else if (tipoDeServicio == 3)
                {
                    Console.WriteLine("Ingrese nombre del suplemento");
                }
            }

        }
        
    }
}