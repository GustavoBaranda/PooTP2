using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooTP2
{
    internal class Suplementos : Servicio
    {
        private string _Nombre;
        private double _PorcGanancia;

        public string Nombre { get => _Nombre; set => _Nombre = value; }

        public Suplementos(string nombre, double porcGanancia, double precioLista) 
            : base(precioLista)   
        {
            Nombre = nombre;
            _PorcGanancia = porcGanancia;
        }
        public override string ToString()
        {
            double precioTotal = CalcularPrecio();
            return $"Suplemento:{Nombre} \nPrecio de lista: ${_PrecioLista.ToString("F2")} \nPorcentaje de ganancia: {_PorcGanancia}% \nPrecio Total del suplemento: ${precioTotal.ToString("F2")}\n";
        }
        public override double CalcularPrecio()
        {
            double precioConGanancia =  _PrecioLista * (1+(_PorcGanancia / 100));
            double precioFinal = precioConGanancia * 1.21;
            return Math.Round(precioFinal,2);
        }
    }
}