using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooTP2
{
    internal class EntrenamientoPersonalizado : ServiciosDeportivos
    {
        private string _TipoDeEntrenamiento;

        public EntrenamientoPersonalizado(string tipoDeEntrenamiento, int duracion, string tipoDeServicio) 
            : base(duracion, tipoDeServicio)
        {
            _TipoDeEntrenamiento = tipoDeEntrenamiento;
        }
    }
}
