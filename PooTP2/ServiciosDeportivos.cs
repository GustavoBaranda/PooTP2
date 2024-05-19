using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooTP2
{
    internal class ServiciosDeportivos : Servicio
    {
        private int _Duracion;
        private string _TipoDeServicio;

        public ServiciosDeportivos(int duracion, string tipoDeServicio) 
        {
            _Duracion = duracion;
            _TipoDeServicio = tipoDeServicio;
        }

          public void AgregarServicio() 
        {
            Console.WriteLine("Se agrego un Servicio");
        }
        public override float CalcularPrecio()
        {
            float precio = _Duracion * 2000;
            float precioFinal = precio * 41.105F;   
            return precioFinal;
        }
    }
}
