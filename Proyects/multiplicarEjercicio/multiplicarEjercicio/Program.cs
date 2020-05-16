using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiplicarEjercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;//Variable de control
            int numero = 0;//numero para tabla
            int resultado = 0;
            string valor = "";//info usuario

            Console.Write("Dame un número para mostrarte la tabla de multiplicar: ");
            valor = Console.ReadLine();
            numero = Convert.ToInt32(valor);

            for (n = 1; n <= 10; n++)
            {
                resultado = n * numero;
                Console.WriteLine("{0} * {1} = {2}", n, numero, resultado);
            }
        }
    }
}
