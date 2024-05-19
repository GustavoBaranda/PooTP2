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
        public override float CalcularPrecio() {
            //calcula el precio de la clase.
            float precioClase = _PrecioLista * (_Duracion/60);
             
            return precioClase += precioClase * 0.105f;
        }
        public override string ToString()
        {
            float result = CalcularPrecio();
            return $"Tipo de entrenamiento: {_TipoDeEntrenamiento}, Duracion : {_Duracion/60}:{_Duracion % 60}hs ,Valor por Hr es: {_PrecioLista}, Precio Final: ${result}";
        }
    }
}