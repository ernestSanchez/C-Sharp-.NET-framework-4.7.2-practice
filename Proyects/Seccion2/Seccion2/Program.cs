using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seccion2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Realizar un programa de computadora que haga el calculo 
            // del area y perimetro de un rectangulo

            //Variables:

            double altura, ancho, area, perimetro;

            //Pedimos la altura y convertimos a tipo double 
            Console.Write("Dame la altura: ");
            altura = Convert.ToDouble(Console.ReadLine());

            //Pedimos el ancho  y convertimos a tipo double 
            Console.Write("Dame el ancho: ");
            ancho = Convert.ToDouble(Console.ReadLine());

            //calculamos el area
            area = altura * ancho;

            //calculamos el perimtro 
            perimetro = 2 * (altura + ancho);

            //Mostramos resultados pantalla
            Console.WriteLine("El area es: {0}", area);
            Console.WriteLine("El perimetro es: {0}", perimetro);

        }
    }
}
 
 
 