using System;

namespace PooTP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Suplementos suplementos = new Suplementos("Proteinas", 20.00F, 55.00F);
            ClaseGrupales claseZumba = new ClaseGrupales("Zumba",15, 45);
            EntrenamientoPersonalizado musculacion = new EntrenamientoPersonalizado("Pesas",90);
            HistorialDeCierreDiario historial = new HistorialDeCierreDiario();
            historial.AddService(claseZumba);
            historial.AddService(suplementos);
            historial.AddService(musculacion);
            historial.mostrarServicios();
        }
    }
}