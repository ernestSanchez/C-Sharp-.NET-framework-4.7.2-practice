using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arreglos
{
    class Program
    {
        static void Main(string[] args)
        {
            /////////////tipo[] nombre = new tipo[tamaño];/////////

            //int a = 8;

            //double[] calificaciones = new double [a];

            //calificaciones[4] = 7.5;


            //variable 
            int cantidadA = 0;
            int i = 0;

            double suma = 0.0;
            double promedio = 0.0;

            double calificacionMinima = 10.0;
            double calificacionMaxima = 0.0;

            Console.Write("cantidad de alumnos: ");
            cantidadA = Int32.Parse(Console.ReadLine());

            //creacion arreglo 
            double[] calificaciones = new double[cantidadA];

            for (i=0; i < cantidadA; i++)
            {
                Console.Write("dame la calificacion del alumno {0}: ", i);
                calificaciones[i] = Double.Parse(Console.ReadLine());
            }
            for (i = 0; i < cantidadA; i++)
            {
                suma += calificaciones[i];
            }

            promedio = suma / cantidadA;

            //calificacion minima 

            for (i = 0; i < calificaciones.Length; i++)
            {
                if (calificaciones[i] < calificacionMinima)
                {
                    calificacionMinima = calificaciones[i];
                }
            }

            //calificacion maxima 
            for (i = 0; i < calificaciones.Length; i++)
            {
                if (calificaciones[i] > calificacionMaxima)
                {
                    calificacionMaxima = calificaciones[i];
                }
            }

            //resultados
            Console.WriteLine("El promedio es: {0}", promedio);
            Console.WriteLine("la calificacion minima es: {0}", calificacionMinima);
            Console.WriteLine("la calificacion maxima es: {0}", calificacionMaxima);

        }
    }
}
