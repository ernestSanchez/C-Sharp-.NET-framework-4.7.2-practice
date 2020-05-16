using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodos
{
    class Program
    {
        //esta es la funcion principal del programa 
        //Aqui inicia la aplicacion
        static void Main(string[] args)
        {
            //variables 
            int a = 5;
            int b = 3;
            //valor antes de la funcion
            Console.WriteLine("valor antes de la funcion:a = {0} y b = {1}", a, b);

            //invocamos funcion 
            Cambiar(ref a ,ref b ); //<---- por referencia

            //valor despues de la funcion
            Console.WriteLine("valor despues de la funcion: a = {0} y b = {1}", a,b);

        }//cierre main 

        static void Cambiar(ref int x,ref int y)//<---- por referencia
        {
            //variable de trabajo
            int temp = 0;

            //cambiamos el valor 
            temp = x;
            x = y;
            y = temp;
        }
    }//cierre programa 
}
