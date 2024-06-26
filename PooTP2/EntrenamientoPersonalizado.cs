﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace PooTP2
{
    internal class EntrenamientoPersonalizado : ServiciosDeportivos
    {
        private string _TipoDeEntrenamiento;
        private const double PRECIOENTRENAMIENTO = 2000;

        public string TipoDeEntrenamiento { get => _TipoDeEntrenamiento; set => _TipoDeEntrenamiento = value; }

        public EntrenamientoPersonalizado(string tipoDeEntrenamiento, int _Duracion) 
            : base(_Duracion, PRECIOENTRENAMIENTO)
        {
            TipoDeEntrenamiento = tipoDeEntrenamiento;
        }

         public override double CalcularPrecio() {
            double precioClase = (PRECIOENTRENAMIENTO / 60) * Duracion;
            double precioFinal = precioClase += precioClase * 0.105;
            return precioFinal;
        }
        public override string ToString()
        {
            int horas = Duracion / 60;
            int minutos = Duracion % 60;
            string duracionEnHoras = $"{horas}:{minutos:D2}";
            double result = CalcularPrecio();
            return $"Tipo de entrenamiento: {TipoDeEntrenamiento} \nDuracion en Minutos: {Duracion} \nDuracion en Horas: {duracionEnHoras} \nValor por Hr es: ${PrecioLista} \nPrecio Total del entrenamiento: ${result.ToString("F2")}\n";
        }
    }
}