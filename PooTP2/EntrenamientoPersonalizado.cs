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

        public override double CalcularPrecio()
        {
            double precioClase = (PRECIOENTRENAMIENTO / 60) * _Duracion;
            double precioFinal = precioClase += precioClase * 0.105;
            return precioFinal;
        }
        public override string ToString()
        {
            int horas = _Duracion / 60;
            int minutos = _Duracion % 60;
            string duracionEnHoras = $"{horas}:{minutos:D2}";
            double result = CalcularPrecio();
            return $"Tipo de entrenamiento: {_TipoDeEntrenamiento} \nDuracion en Minutos: {_Duracion} \nDuracion en Horas: {duracionEnHoras} \nValor por Hr es: ${_PrecioLista} \nPrecio Total del entrenamiento: ${result.ToString("F2")}\n";
        }
    }
}