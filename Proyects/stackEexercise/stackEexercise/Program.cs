using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace stackEexercise
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

            //creamos stack
            Stack miTorre = new Stack();
            do
            {
                //mostrar menu 
                Console.WriteLine("1.Push");
                Console.WriteLine("2.Pop");
                Console.WriteLine("3.Clear");
                Console.WriteLine("4.Contains");
                Console.WriteLine("5.Salir");

                Console.Write("Dame la opcion: ");
                valor = Console.ReadLine();
                opcion = Convert.ToInt32(valor);

                if (opcion == 1)
                {
                    //pedimos el valor que se va introducior 
                    Console.Write("Dame el valor a introducir: ");
                    valor = Console.ReadLine();
                    numero = Convert.ToInt32(valor);

                    //agrgamos el valor al stack 
                    miTorre.Push(numero);
                }

                if (opcion == 2)
                {
                    //obtenemos el elemento 
                    numero = (int)miTorre.Pop();

                    //MOSTRAMOS EL ELEMENTO 
                    Console.WriteLine("El valor obtenido es: {0} ", numero);
                }

                if (opcion == 3)
                {
                    //limpiamos el contenido del stack 

                    miTorre.Clear();
                }
                if (opcion == 4)
                {
                    //Pedimos el valor que queremos encontrar 
                    Console.Write("dame el valor a encontrar: ");
                    valor = Console.ReadLine();
                    numero = Convert.ToInt32(valor);

                    //verificamos que este el elemento 
                    encontrado = miTorre.Contains(numero);

                    //mostramos resultado
                    Console.WriteLine("Encontrado - {0}", encontrado);
                }

                //Mostramos la info del stack 
                Console.WriteLine("el stack tiene {0} elementos", miTorre.Count);
                foreach (int n in miTorre)
                    Console.Write(" {0}, ", n);

                Console.WriteLine("");
                Console.WriteLine("....");

            } while (opcion != 5);



        }
    }
}
