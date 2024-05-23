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
        public string _TipoDeEntrenamiento;
        private const double PRECIOENTRENAMIENTO = 2000;
        public EntrenamientoPersonalizado(string tipoDeEntrenamiento, int _Duracion) 
            : base(_Duracion, PRECIOENTRENAMIENTO)
        {
            _TipoDeEntrenamiento = tipoDeEntrenamiento;
        }

         public override double CalcularPrecio() {
            double precioClase = (PRECIOENTRENAMIENTO / 60) * _Duracion;
            double precioFinal = precioClase += precioClase * 0.105;
            return precioFinal;
        }
        public override string ToString()
        {
            int horas = _Duracion/60;
            string minutos = _Duracion % 60 == 0 ? "00" : (_Duracion % 60).ToString();
            string duracionEnHoras = $"{horas}:{minutos}";
            double result = CalcularPrecio();
            return $"Tipo de entrenamiento: {_TipoDeEntrenamiento}, \nDuracion en Minutos: {_Duracion},\nDuracion en Horas: {duracionEnHoras}, \nValor por Hr es: ${_PrecioLista}, \nPrecio Final: ${result}\n";
        }
    }
}