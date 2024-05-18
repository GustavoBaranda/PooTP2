using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooTP2
{
    internal class HistorialDeCierreDiario
    {
        private List<ServiciosDeportivos> _ListarServicios;
        private List<Suplementos> _Suplementos;
        public HistorialDeCierreDiario(List<ServiciosDeportivos> listarServicios, List<Suplementos> suplementos)
        {
            _ListarServicios = listarServicios;
            _Suplementos = suplementos;
        }

        public void MontoTotalFacturado()
        {
            Console.WriteLine("Monto total");
        }

        public void CantidadDeServiciosSimples() 
        {
            Console.WriteLine("Cantidad de servivios simples");
        }
    }
}
