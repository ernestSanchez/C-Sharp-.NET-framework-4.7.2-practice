using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace coleccionesStack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack miTorre = new Stack();

            miTorre.Push(7);
            miTorre.Push(11);
            miTorre.Push(8);

            int valor = 0, cantidad = 0;

            valor = (int)miTorre.Pop(); //CON EL POP SACAREMOS EL ULTIMO ELEMENTO AÑADIDO CON EL PUSH EN ESTE CASO LO AÑADIMOS A LA VAR VALOR 
            foreach (int n in miTorre)       //<------reiteracion de los elementos del stack 
                Console.WriteLine("{0}",n);

            cantidad = miTorre.Count;          //<----cantidad de elementos del stack 
            Console.WriteLine("{0}", cantidad);

            miTorre.Clear(); //<--- borrar todos los elementos del stack 

            bool enStack = false; //<----- buscar elemeto 7 en stack nos devolvera true o false 

            enStack = miTorre.Contains(7);
        }
    }
}
