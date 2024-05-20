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
            Console.WriteLine("Servicio agregado correctamente");
        }
        public void mostrarServicios()
        {
            _ListarServicios.ForEach((servicio) => {
                Console.WriteLine(servicio);
            });
        }
        public double MontoTotalFacturado()
        {
            double total = 0; 
            for (int i = 0; i < _ListarServicios.Count; i++)
            {
                total += _ListarServicios[i].CalcularPrecio();
            }
            return Math.Round(total,2); 
        }

        public int CantidadDeServiciosSimples() 
        {
           return _ListarServicios.OfType<ClaseGrupales>().Count(c => c._CantidadDeInscriptos < 10);
        }
    }
}