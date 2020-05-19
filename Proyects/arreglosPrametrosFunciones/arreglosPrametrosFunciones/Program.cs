using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arreglosPrametrosFunciones
{
    class Program
    {
        static void Main(string[] args)
        {

            int i = 0;

            double[] calificaciones = new double[4];

            for(i = 0; i < calificaciones.Length; i++)
            {
                Console.Write("dame la calificacion: ");
                calificaciones[i] = Convert.ToDouble(Console.ReadLine());
            }

            ImprimirArreglo(calificaciones);
            PromedioArreglo(calificaciones);
        }

        static void ImprimirArreglo(double [] arregloRecibe)
        {
            int i = 0;
            for (i=0; i < arregloRecibe.Length ; i++)
            {
                Console.WriteLine("la calificacion es: {0}", arregloRecibe[i]);
            }
        }

        static void PromedioArreglo(double [] arregloPromedio)
        {
            int i = 0;
            double sumaCalificaciones = 0;
            double promedio = 0;

            for (i=0;i< arregloPromedio.Length; i++)
            {
                sumaCalificaciones += arregloPromedio[i];
            }
            promedio = sumaCalificaciones / arregloPromedio.Length;

            Console.WriteLine("el promedio es: {0}", promedio);
        }
    }
}
