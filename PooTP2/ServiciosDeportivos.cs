using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooTP2
{
    abstract class ServiciosDeportivos : Servicio
    {
        protected int _Duracion;
        public ServiciosDeportivos(int duracion,float _PrecioLista ) : base(_PrecioLista)
        {
            _Duracion = duracion;
        }
          public void AgregarServicio() 
        {
            Console.WriteLine("Se agrego un Servicio");
        }        
    }
}