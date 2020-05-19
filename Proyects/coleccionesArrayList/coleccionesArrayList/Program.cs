using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections; //<--- import nameSpace

namespace coleccionesArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            //variavles 
            int indice = 0;
            int cantidad = 0;

            //declaramos nuestro arrayList "datos"

            ArrayList datos = new ArrayList();

            //agrgamos valores al arrayList 
            datos.Add(7);
            datos.Add(5);
            datos.Add(1);

            Console.WriteLine("mostramos los vaores iniciales de arraylist: ");
            imprime(datos);

            //adicionamos mas elementos al ArrayList haciendo haciendolo crecer 
            datos.Add(4);
            datos.Add(5);

            //obtenemos el indice
            indice = datos.Add(10);

            Console.WriteLine("despues de agregar mas elementos: ");
            imprime(datos);
            Console.WriteLine("El ultimo elemento tiene el indice de: {0}", indice);
            Console.WriteLine("\n..........");

            //imprimir un elemento en particulae
            Console.WriteLine("el valor del indice 2 es de: {0}", datos[2]);
            Console.WriteLine("\n..........");

            //modificar un dato 
            datos[3] = 55;
            Console.WriteLine("despues de modificar el dato: ");
            imprime(datos);

            //obtenemos la cantidad de elementos 
            cantidad = datos.Count;
            Console.WriteLine("La cantidad de elemntos es de: {0} ", cantidad);
            Console.WriteLine("\n..........");

            //insertamos un elemento en una posicion en particular 
            datos.Insert(2, 88);
            Console.WriteLine("despues de insertar el elmento: ");
            imprime(datos);

            //eliminando un elemento 
            datos.RemoveAt(4);
            Console.WriteLine("despues de eleimnar el elemento: ");
            imprime(datos);

            //encontramos el indice donde se encuentra el primer numero 5
            indice = datos.IndexOf(5);
            Console.WriteLine("El primer numero 5 se encuentra en el indice: {0}", indice);
            Console.WriteLine("\n..........");
        }
        static void imprime(ArrayList arreglo)
        {
            foreach (int n in arreglo)
            {
                Console.Write(" {0}, ", n);
            }
            Console.WriteLine("\n..........");
        }
    }
}
