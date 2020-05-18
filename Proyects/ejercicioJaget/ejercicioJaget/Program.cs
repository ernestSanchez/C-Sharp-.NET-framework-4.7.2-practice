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

            //mostrar info 
            Console.WriteLine("\n\ninformacion\n");

            for (i = 0; i < salones; i++)
            {
                Console.WriteLine("salon {0} ", i + 1);

                for (j = 0; j < calificaciones[i].GetLength(0); j++)
                {
                    Console.WriteLine("el alumno {0},tiene {1} de calificacion", j + 1,calificaciones[i][j]);
                }
            }
        }
    }
}
