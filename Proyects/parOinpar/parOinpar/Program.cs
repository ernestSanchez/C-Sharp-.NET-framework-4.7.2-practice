using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parOinpar
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;
            string valor = "";
            
            // pedir numero a usuario
            Console.Write("Dime un numero: ");
            //recibo la info del usuario
            valor = Console.ReadLine(); //<-----
            //parseo de string a numero
            numero = Convert.ToInt32(valor);
            // formula

        

            if (numero % 2 == 0)
            {
                Console.WriteLine("El numero: {0} es Par", numero);

            }
            else
            {
                Console.WriteLine("El numero: {0} es Impar", numero);
            }

            //decir si es par o inpar
        }
    }
}
