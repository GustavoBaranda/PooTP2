using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooTP2
{
    internal class EntrenamientoPersonalizado : ServiciosDeportivos
    {
        protected string _TipoDeEntrenamiento;
        public EntrenamientoPersonalizado(string tipoDeEntrenamiento, int _Duracion  ) 
            : base(_Duracion,2000)
        {
            _TipoDeEntrenamiento = tipoDeEntrenamiento;
        }
        public override double CalcularPrecio() {
            //calcula el precio de la clase.
            double precioClase = _PrecioLista * (_Duracion/60);
             double precioFinal = precioClase += precioClase * 0.105;
            return Math.Round(precioFinal,2);
        }
        public override string ToString()
        {
            double result = CalcularPrecio();
            return $"Tipo de entrenamiento: {_TipoDeEntrenamiento}, Duracion en Minutos: {_Duracion}, Valor por Hr es: {_PrecioLista}, Precio Final: ${result}";
        }
    }
}