using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parametrosDefault
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables que necesitamos 
            double costo = 50.0;
            double imp = 0.0;
            double total = 0.0;

            //haremos uso de la funcion de forma tradicional 

            imp = CalculaImpuesto(costo, 0.25);
            total = costo + imp;

            //resultado

            Console.WriteLine("El resultado es ${0}", total);

            //Haremos uso de la funcion con parametro de default 
            //notese que unicamente pasararemos un parametro, y el otro usa un valor predeterminado

            imp = CalculaImpuesto(costo);
            total = costo + imp;

            //resultado 
            Console.WriteLine("El total es: ${0}", total);
        }
            public static double CalculaImpuesto(double cantidad, double impuesto = 5)
        {
            double impuestoCalculado;

            impuestoCalculado = cantidad + impuesto;
            return impuestoCalculado;

        }
    }
}
