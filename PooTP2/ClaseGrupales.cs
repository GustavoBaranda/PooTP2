﻿using System;
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
        private const double PRECIOGRUPAL = 80;

        public ClaseGrupales(string tipoClase, int cantidadDeInscriptos, int _Duracion) 
            : base (_Duracion, PRECIOGRUPAL)
        {
            _tipoClase = tipoClase;
            _CantidadDeInscriptos = cantidadDeInscriptos;
        }
        public override double CalcularPrecio()
        {
            double precioClases = _Duracion * PRECIOGRUPAL;
            precioClases = (_CantidadDeInscriptos > 10 ) ? precioClases * 0.80 : precioClases;
            double precioClasesFinal = precioClases += precioClases*0.105;
            return Math.Round(precioClasesFinal,2);
        }

        public override string ToString()
        {
            int horas = _Duracion / 60;
            string minutos = _Duracion % 60 == 0 ? "00" : (_Duracion % 60).ToString();
            string duracionEnHoras = $"{horas}:{minutos}";
            double result = CalcularPrecio();
            return $"Clase: {_tipoClase},\nCant de Inscriptos: {_CantidadDeInscriptos},\nDuracion de la clase en Min: {_Duracion},\nDuracion en Horas: {duracionEnHoras},\nPrecio por minuto: ${_PrecioLista},\nPrecio total de la clase: ${result}\n";
        }
    }
}
