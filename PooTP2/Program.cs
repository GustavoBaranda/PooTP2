using System;

namespace PooTP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Suplementos suplementos = new Suplementos("Proteinas", 20.00F, 80.00F);
            ServiciosDeportivos serviciosDeportivos = new ServiciosDeportivos(2, "Zumba");
            
            Console.WriteLine(suplementos.CalcularPrecio());
            Console.WriteLine(serviciosDeportivos.CalcularPrecio());
        }
    }
}