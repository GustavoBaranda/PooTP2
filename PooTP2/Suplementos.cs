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
        private float _PorcGanancia;
        public Suplementos(string nombre, float porcGanancia, float precioLista) 
            : base(precioLista)   
        {
            _Nombre = nombre;
            _PorcGanancia = porcGanancia;
        }

        public override float CalcularPrecio()
        {
            float precioConGanancia =  _PrecioLista + (_PrecioLista * (_PorcGanancia / 100));
            float precioFinal = precioConGanancia * 1.21F;
            return precioFinal;
        }
    }
}
