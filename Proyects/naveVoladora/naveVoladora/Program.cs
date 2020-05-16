using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace naveVoladora
{
    class Program
    {
        static void Main(string[] args)
        {
            double energia;
            bool propulsorIzquierdo = false;
            bool propulsorDerecho = false;

            Console.Write("cuanta energia tenemos?: ");
            energia = Convert.ToDouble(Console.ReadLine());

            Console.Write("El propulsor IZQ esta en buen estado?(TRUE/FALSE): ");
            propulsorIzquierdo = Convert.ToBoolean(Console.ReadLine());


            Console.Write("El propulsor drch esta en buen estado?(TRUE/FALSE): ");
            propulsorDerecho = Convert.ToBoolean(Console.ReadLine());

            if (((( propulsorIzquierdo && propulsorDerecho ) == true ) && energia >= 75 ) ||
                    (((propulsorIzquierdo || propulsorDerecho) == true) && ( energia == 100 )))
            {
                Console.WriteLine("Permiso para despegar");
            }
            else
            {
                Console.WriteLine("no tienes permiso para despegar");
            }
        }
    }
}
