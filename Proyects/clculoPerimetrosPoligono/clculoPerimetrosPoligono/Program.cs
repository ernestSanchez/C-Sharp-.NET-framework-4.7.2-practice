using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clculoPerimetrosPoligono
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa que calcular el perimetro de cualquier poligono regular

            //variables 

            int numeroLados;
            double tamañoLado, perimetro;

            //Pedir el numero de lados
            Console.Write("Dame el numero de lados: ");
            numeroLados = Convert.ToInt32(Console.ReadLine());

            // Pedir la medida de alguno de los lados 
            Console.Write("Dame el tamaño de uno de los lados: ");
            tamañoLado = Convert.ToDouble(Console.ReadLine());

            //Calcular el perimetro multiplicando la medida por el numero

            perimetro = numeroLados * tamañoLado;

            //Mostrar perimetro
            Console.WriteLine("EL perimetro es: {0}", perimetro);

        }
    }
}
