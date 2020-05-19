using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace colecccionesQueue
{
    class Program
    {
        static void Main(string[] args)
        {

            //variables 

            int opcion = 0;
            string valor = "";
            int numero = 0;
            bool encontrado = false;

            
            //creamos queue

            Queue fila = new Queue();

            do
            {
                //menu
                Console.WriteLine("1. Endqueue");
                Console.WriteLine("2. Dequeue");
                Console.WriteLine("3. Clear");
                Console.WriteLine("4. Contains");
                Console.WriteLine("5. Salir");

                //pedimos la opcion 
                Console.Write("escoge una opcion: ");
                valor = Console.ReadLine();
                opcion = Convert.ToInt32(valor);

                if(opcion == 1)
                {
                    //pedir el valor a introducir 
                    Console.Write("dame el valor a introducir en el Queue: ");
                    valor = Console.ReadLine();
                    numero = Convert.ToInt32(valor);

                    //agregamos el valor introducido por usuario en el queue
                    fila.Enqueue(numero);
                }

                if(opcion == 2)
                {
                    //obtenemos el elemento
                    numero = (int)fila.Dequeue();

                    //Mostramos el elemento extraido 
                    Console.WriteLine("el valor extraido es: {0}", numero);
                }

                if(opcion == 3)
                {
                    //limpiar contenido de queue
                    fila.Clear();
                }
                if (opcion == 4)
                {
                    //pedir el valor que queremos encontrar 
                    Console.Write("dame el valor que quieres encontrar: ");
                    valor = Console.ReadLine();
                    numero = Convert.ToInt32(valor);

                    //verificamos que elemento esta
                    encontrado = fila.Contains(numero);

                    //resultado 
                    Console.WriteLine("elemento encontrado = {0}", encontrado);
                }

                //mostrar la info del queue
                Console.WriteLine("el queue tiene {0} elementos",fila.Count);
                
                //foreach para mostrarlo 
                foreach(int n in fila)
                    Console.Write(" {0}, ", n);
                    Console.WriteLine("");
                    Console.WriteLine("........");
               

            } while (opcion !=5 );
            

            
           
        }
    }
}
