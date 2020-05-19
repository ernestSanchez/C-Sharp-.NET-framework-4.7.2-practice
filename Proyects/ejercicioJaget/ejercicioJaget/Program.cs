using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioJaget
{
    class Program
    {
        static void Main(string[] args)
        {
            int salones = 0;
            int alumnos = 0;
            
            double promedio = 0.0;
            double sumaCalificaciones = 0.0;
            int sumaAlumnos = 0; //acumulador para la suma de alumnos

            double caliMaxima = 0.0;
            double caliMinima = 10.0;

            int i; //ciclo exterior (SALONES)
            int j; //ciclo interior (alumnos)

            //pedir la cantidad de salones 
            Console.Write("Dame la cantidad de salones: ");
            salones = Convert.ToInt32(Console.ReadLine());

            //crear arreglo jaget 
            double[][] calificaciones = new double[salones][];

            Console.WriteLine();//espacio de linea 

            //pedir alumnos por salon

            for (i = 0; i < salones; i++)
            {
                Console.WriteLine("salon {0} ", i + 1);
                Console.Write("Dame la cantidad de alumnos: ");
                alumnos = Convert.ToInt32(Console.ReadLine());

                sumaAlumnos += alumnos;

                //asignar los alumnos (instanciar el arreglo)
                calificaciones[i] = new double[alumnos];               
            }
            Console.WriteLine();

            //pedir calificaciones
            for (i = 0; i < salones;  i++)
            {
                Console.WriteLine("salon {0} ", i + 1);
                
                for (j = 0; j < calificaciones[i].GetLength(0); j++)
                {
                    Console.Write("dame la calificacion del alumno {0}: ", j+1);
                    calificaciones[i][j] = Convert.ToDouble(Console.ReadLine());
                }
            }

            //calculamos promedio

            for (i = 0; i < salones; i++)
            {
                for (j = 0; j < calificaciones[i].GetLength(0); j++)
                {
                    sumaCalificaciones += calificaciones[i][j];
                }
            }
            promedio = sumaCalificaciones / sumaAlumnos;

            //calculando la calificacion Minima 
            for (i = 0; i < salones; i++)
            {
                for (j = 0; j < calificaciones[i].GetLength(0); j++)
                {
                    if (calificaciones[i][j] < caliMinima)
                    {
                        caliMinima = calificaciones[i][j];
                    }
                }
            }
            //calculando la calificacion Maxima 
            for (i = 0; i < salones; i++)
            {
                for (j = 0; j < calificaciones[i].GetLength(0); j++)
                {
                    if (calificaciones[i][j] > caliMaxima)
                    {
                        caliMaxima = calificaciones[i][j];
                    }
                }
            }


            //mostrar info 
            Console.WriteLine("\n\ninformacion\n");

            for (i = 0; i < salones; i++)
            {
                Console.WriteLine("\n\nsalon {0}\n ", i + 1);

                for (j = 0; j < calificaciones[i].GetLength(0); j++)
                {
                    Console.WriteLine("el alumno {0} , tiene {1} de calificacion", j + 1,calificaciones[i][j]);
                }
            }

            //mostramos info adicional
           
            Console.WriteLine("\nel promedio total es de: {0}", promedio);
            Console.WriteLine("la calificacion minima es: {0}", caliMinima);
            Console.WriteLine("la calificacion maxima es: {0}\n", caliMaxima);

        }
     }
}
