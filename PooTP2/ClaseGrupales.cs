using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooTP2
{
    internal class ClaseGrupales : ServiciosDeportivos
    {
        public string _tipoClase;
        public int _CantidadDeInscriptos;

        public ClaseGrupales(string tipoClase, int cantidadDeInscriptos, int _Duracion ) 
            : base (_Duracion, 80)
        {
            _tipoClase = tipoClase;
            _CantidadDeInscriptos = cantidadDeInscriptos;
        }

        public override float CalcularPrecio()
        {
            float result = _Duracion * _PrecioLista;
            result = (_CantidadDeInscriptos > 10 ) ? result *0.80f : result ;
            // Console.WriteLine((_CantidadDeInscriptos > 10) ? 
            // "El precio de la clase cuenta con un descuento del 20% por superar los 10 inscriptos"
            // :
            // "El precio de la clase no posee descuentos ya que la cantidad de inscriptos no superan los 10."
            // );
            return result += result*0.105f;
        }

        public override string ToString()
        {
            float result = CalcularPrecio();
            return $"Clase: {_tipoClase}, Precio por minuto: ${_PrecioLista},Duracion de la clase en Min: {_Duracion}, Cant de Inscriptos: {_CantidadDeInscriptos}, Precio total de la clase: ${result}";
        }
    }
}
