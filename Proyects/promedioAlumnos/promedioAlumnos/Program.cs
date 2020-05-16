using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace promedioAlumnos
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0; //control del ciclo
            int cantidad; //Cantidad de alumnos
            float calif = 0.0f;
            float suma = 0.0f;
            float promedio = 0.0f;
            string valor = "";

            Console.Write("Dame la cantidad de alumnos: ");
            valor = Console.ReadLine();
            cantidad = Convert.ToInt32(valor);

            //ciclo
            for ( n = 1; n <= cantidad; n++)
            {
                Console.Write("Dame la calificación del alumno: ");
                valor = Console.ReadLine();
                calif = Convert.ToSingle(valor);

                //Llevamos a cabo la suma
                suma += calif;   //<--- en la suma se va quedando lo que pone el usuario de calificacion como si fuera un array y lo va sumando cada vez 
            }

            //calculamos el promedio
            promedio = suma / cantidad; //<----- la suma contiene todas la calificaciones sumadas y las divide por la cantidad para sacar el promedio

            //Mostramos el promedio
            Console.WriteLine("El promedio es: {0}", promedio);
        }
    }
}
