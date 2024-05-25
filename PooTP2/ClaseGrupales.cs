using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooTP2
{
    internal class ClaseGrupales : ServiciosDeportivos
    {
        private string _TipoClase;
        private int _CantidadDeInscriptos;
        private const double PRECIOGRUPAL = 80;

        public string TipoClase { get => _TipoClase; set => _TipoClase = value; }
        public int CantidadDeInscriptos { get => _CantidadDeInscriptos; set => _CantidadDeInscriptos = value; }

        public ClaseGrupales(string tipoClase, int cantidadDeInscriptos, int _Duracion) 
            : base (_Duracion, PRECIOGRUPAL)
        {
            TipoClase = tipoClase;
            CantidadDeInscriptos = cantidadDeInscriptos;
        }
        public override double CalcularPrecio()
        {
            double precioClases = Duracion * PRECIOGRUPAL;
            precioClases = (CantidadDeInscriptos > 10 ) ? precioClases * 0.80 : precioClases;
            double precioClasesFinal = precioClases += precioClases*0.105;
            return Math.Round(precioClasesFinal,2);
        }

         public override string ToString()
        {
            int horas = Duracion / 60;
            int minutos = Duracion % 60;
            string duracionEnHoras = $"{horas}:{minutos:D2}";
            double result = CalcularPrecio();
            return $"Clase Grupal: {TipoClase}\nCant de Inscriptos: {CantidadDeInscriptos}\nDuracion de la clase en Min: {Duracion}\nDuracion en Horas: {duracionEnHoras}\nPrecio por minuto: ${PrecioLista}\nPrecio total de la clase: ${result.ToString("F2")}\n";
        }
    }
}
