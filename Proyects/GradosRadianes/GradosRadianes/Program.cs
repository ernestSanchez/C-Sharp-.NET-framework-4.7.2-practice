using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradosRadianes
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables

            double grados, radianes, pi = 3.1416;
            string valor = "";

            //pedir grados 
            Console.Write("cantidad de grados a convertir: ");
            valor = Console.ReadLine();
            grados = Convert.ToDouble(valor);

            radianes = gradosRadianes(grados, pi);

            //result
            Console.WriteLine("{0}° equivalen a {1} radianes", grados, radianes);


        }
       static double gradosRadianes(double n1,double n2)
        {
            //var a usar 
            double r = 0.0;

            r = (n1*n2)/180;
            return r;
        }
    }
}
