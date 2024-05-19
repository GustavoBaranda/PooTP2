using System;

namespace PooTP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Servicio suplementos = new Suplementos("Proteinas", 20.00F, 55.00F);
            ServiciosDeportivos claseZumba = new ClaseGrupales("Zumba",15, 45);
            ServiciosDeportivos musculacion = new EntrenamientoPersonalizado("Pesas",325);
            HistorialDeCierreDiario historial = new HistorialDeCierreDiario();
            historial.AddService(claseZumba);
            historial.AddService(suplementos);
            historial.AddService(musculacion);
            historial.mostrarServicios();
        }
    }
}