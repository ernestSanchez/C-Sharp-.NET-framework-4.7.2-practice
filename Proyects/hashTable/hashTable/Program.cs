using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables 
            int opcion = 0;
            string valor = "";
            bool encontrado = false;
            string llave = "";
            double precio = 0;

            //crear hashtable
            Hashtable tabla = new Hashtable();

            do
            {
                //mostramos nuestro menu
                Console.WriteLine("1. Agregar elemento");
                Console.WriteLine("2. Quitar elemento");
                Console.WriteLine("3. Clear");
                Console.WriteLine("4. Encontrar el Key");
                Console.WriteLine("5. Encontrar el Value");
                Console.WriteLine("6. Salir");

                //pedimos la opcion deseada
                Console.Write("Escoge una opcion: ");
                valor = Console.ReadLine();
                opcion = Convert.ToInt32(valor);

                if (opcion == 1)
                {
                    //pedimos nombre producto 
                    Console.Write("dame el nombre del producto: ");
                    valor = Console.ReadLine();
                    llave = Convert.ToString(valor);

                    //precio producto
                    Console.Write("dame el precio del producto: ");
                    valor = Console.ReadLine();
                    precio = Convert.ToDouble(valor);

                    //Agregamos el valor introducido por el usuario en el Hastable
                    tabla.Add(llave, precio);
                }

                if(opcion ==2)
                {
                    //pedimos el nombre del producto a eliminar 
                    Console.Write("Dame el nombre del producto que quieres eliminar: ");
                    valor = Console.ReadLine();
                    llave = Convert.ToString(valor);

                    //quitamos el elemento
                    tabla.Remove(llave);
                }
                if(opcion == 3)
                {
                    //limpiamos nuestro Hastable
                    tabla.Clear();
                }

                if (opcion == 4)
                {
                    //pedimos el key que qeremos encontrar 
                    Console.Write("dame el key que quieres encontrar: ");
                    valor = Console.ReadLine();
                    llave = Convert.ToString(valor);

                    //verificacion que se encuentre key 
                    encontrado = tabla.Contains(llave);

                    //mostramos si se encontro 
                    Console.WriteLine("Elemento encontrado = {0}", encontrado);

                }
                if (opcion == 5)
                {
                    //pedimos el value que qeremos encontrar 
                    Console.Write("dame el value que quieres encontrar: ");
                    valor = Console.ReadLine();
                    precio = Convert.ToDouble(valor);

                    //verificacion que se encuentre key 
                    encontrado = tabla.Contains(precio);

                    //mostramos si se encontro 
                    Console.WriteLine("Elemento encontrado = {0}", encontrado);

                }

                //mostramos la informacion 
                Console.WriteLine("El Hastable tiene {0} parejas de key-value", tabla.Count);

                foreach (DictionaryEntry datos in tabla)
                    Console.WriteLine("[{0},{1}]\t", datos.Key, datos.Value);
                Console.WriteLine("");
                Console.WriteLine("......");

            } while (opcion != 6);

        }
    }
}
