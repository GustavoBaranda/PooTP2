using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace PooTP2
{
    internal class HistorialDeCierreDiario
    {
        private List<Servicio> _ListarServicios = new List<Servicio>();

        public void AgregarServicio(Servicio servicio)
        {
            _ListarServicios.Add(servicio);
            Console.WriteLine("\nServicio agregado correctamente");
        }
        public void MostrarServicios()
        {
            if (_ListarServicios.Count == 0)
            {
                Console.WriteLine("No hay servicios disponibles.");
            }
            else
            {
                _ListarServicios.ForEach((servicio) =>
                {
                    Console.WriteLine(servicio);
                });
            }
        }
        public void MostrarUltimoServicio()
        {
            if (_ListarServicios != null && _ListarServicios.Count > 0)
            {
                var ultimoServicio = _ListarServicios.Last();
                Console.WriteLine($"\n{ultimoServicio}");
            }
            else
            {
                Console.WriteLine("No hay servicios disponibles.");
            }
        }
        public double MontoTotalFacturado()
        {
            double total = 0;
            for (int i = 0; i < _ListarServicios.Count; i++)
            {
                total += _ListarServicios[i].CalcularPrecio();
            }
            return Math.Round(total, 2);
        }

        public int CantidadDeServiciosSimples()
        {
            return _ListarServicios.OfType<ClaseGrupales>().Count(c => c._CantidadDeInscriptos < 10);
        }
    }
}