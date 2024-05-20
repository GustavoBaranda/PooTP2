﻿using System;
using System.Security.Cryptography.X509Certificates;

namespace PooTP2
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //Suplementos suplementos = new Suplementos("Proteinas", 20, 55);
            HistorialDeCierreDiario historial = new HistorialDeCierreDiario();
            //ClaseGrupales claseZumba = new ClaseGrupales("Zumba", 5, 45);
            //ClaseGrupales claseZumba1 = new ClaseGrupales("Zumba", 9, 45);
            //EntrenamientoPersonalizado musculacion = new EntrenamientoPersonalizado("Pesas", 90);
            //historial.AddService(claseZumba);
            //historial.AddService(suplementos);
            //historial.AddService(musculacion);
            //historial.AddService(claseZumba1);
            //historial.mostrarServicios();
            //Console.WriteLine(historial.MontoTotalFacturado());
            //Console.WriteLine(historial.CantidadDeServiciosSimples());

            Console.WriteLine(2000*1.5);
                       bool continuar = true;

            while (continuar)
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1. Agregar un servicio");
                Console.WriteLine("2. Mostrar detalles de los servicio");
                Console.WriteLine("3. Salir del Programa");
                int opcion = int.Parse(Console.ReadLine());

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
                        Console.WriteLine("Opcion no valida, intente nuevamente trolo");
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
                Console.WriteLine("Selecionar una opcion trolo");
                int tipoDeServivio = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese el tipo de entrenamiento: ");
                string tipo = Console.ReadLine();
                if (string.IsNullOrEmpty(tipo))
                {
                    return;
                }

                Console.WriteLine("Ingrese duracion en minutos: ");
                int duracion = int.Parse(Console.ReadLine());

                if (tipoDeServivio == 1)
                {
                    historial.AgregarServicio(new EntrenamientoPersonalizado(tipo, duracion));
                    Console.WriteLine();
                }
                else if (tipoDeServivio == 2)
                {
                    Console.WriteLine("Ingrese el numero de participante");
                    int nroParticipante = int.Parse(Console.ReadLine());
                    historial.AgregarServicio(new ClaseGrupales(tipo, nroParticipante, duracion));
                }
            }

        }
        
    }
}