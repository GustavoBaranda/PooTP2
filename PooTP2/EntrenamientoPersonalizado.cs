using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace PooTP2
{
    internal class EntrenamientoPersonalizado : ServiciosDeportivos
    {
        protected string _TipoDeEntrenamiento;
        private const double PRECIOENTRENAMIENTO = 2000;
        public EntrenamientoPersonalizado(string tipoDeEntrenamiento, int _Duracion) 
            : base(_Duracion, PRECIOENTRENAMIENTO)
        {
            _TipoDeEntrenamiento = tipoDeEntrenamiento;
        }

         public override double CalcularPrecio() {
            //calcula el precio de la clase.
            
            double precioClase = (PRECIOENTRENAMIENTO / 60) * _Duracion;
            double precioFinal = precioClase += precioClase * 0.105;
            return precioFinal;
        }
        public override string ToString()
        {
            double result = CalcularPrecio();
            return $"Tipo de entrenamiento: {_TipoDeEntrenamiento}, Duracion en Minutos: {_Duracion}, Valor por Hr es: {_PrecioLista}, Precio Final: ${result}";
        }
    }
}