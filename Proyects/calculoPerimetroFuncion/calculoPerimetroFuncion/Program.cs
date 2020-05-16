using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace calculoPerimetroFuncion
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables perimetro
            int perimetro;

            //invocar funcion y obtener el resultado 
            perimetro = Perimetro();

            //resultado
            Console.WriteLine("el perimetro de tu poligono es: {0}", perimetro);


        }
        static int Perimetro()
        {
            int lado, p, numLados;
            string valor = "";

            Console.Write("¿cuantos lados tiene tu poligono?: ");
            valor = Console.ReadLine();
            numLados = Convert.ToInt32(valor);

            Console.Write("dame el valor de uno de los lados: ");
            valor = Console.ReadLine();
            lado = Convert.ToInt32(valor);

            p = lado * numLados;
            return p;
        }
    }
}
