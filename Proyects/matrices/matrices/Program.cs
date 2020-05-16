﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrices
{
    class Program
    {
        static void Main(string[] args)
        {
            int salones = 0;
            int alumnos = 0;
            int i;//ciclo exterior(salones)
            int j;//ciclo interior(alumnos)

            double suma = 0.0;
            double promedio = 0.0;

            double calMinima = 10.0;
            double calMaxima = 0.0;

            //Pedir la cantidad de salones
            Console.Write("Dame la cantidad de salones: ");
            salones = Convert.ToInt32(Console.ReadLine());

            //Pedimos la cantidad de alumnos
            Console.Write("Dame la cantidad de alumnos por salón: ");
            alumnos = Convert.ToInt32(Console.ReadLine());

            //Creamos el arreglo
            double[,] calificaciones = new double[salones, alumnos];

            for (i = 0; i < salones; i++)
            {
                Console.WriteLine("Salón {0}", i + 1);
                for (j = 0; j < alumnos; j++)
                {
                    Console.Write("Dame la calificación del alumno {0}: ", j + 1);
                    calificaciones[i, j] = Convert.ToDouble(Console.ReadLine());
                }
            }

            //Calcular el promedio
            for (i = 0; i < salones; i++)
            {
                for (j = 0; j < alumnos; j++)
                {
                    suma += calificaciones[i, j];
                }
            }
            promedio = suma / (salones * alumnos);

            //Calificación mínima
            for (i = 0; i < salones; i++)
            {
                for (j = 0; j < alumnos; j++)
                {
                    if (calificaciones[i, j] < calMinima)
                    {
                        calMinima = calificaciones[i, j];
                    }
                }
            }

            //Calificación Máxima
            for (i = 0; i < salones; i++)
            {
                for (j = 0; j < alumnos; j++)
                {
                    if (calificaciones[i, j] > calMaxima)
                    {
                        calMaxima = calificaciones[i, j];
                    }
                }
            }

            //Mostramos los resultados
            Console.WriteLine("El promedio es: {0}", promedio);
            Console.WriteLine("La calificación mínima es: {0}", calMinima);
            Console.WriteLine("La calificación máxima es: {0}", calMaxima);
        }
    }
}
