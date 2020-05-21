using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appEnumeraciones
{
    class Program
    {
        enum mes {Enero,Febrero,Marzo,Abril,Mayo,Junio,Julio,Agosto,Septiembre,Octubre,Noviembre,Diciembre};

        enum color {Rojo = 4, Negro, Purpura};
        static void Main(string[] args)
        {
            int numero = 0;

            //declarar variable tipo mes 
            mes miMes;

            //asignamos valor  
            miMes = mes.Mayo;

            //Pasamos de enumeracio a entero 
            numero = (int)miMes;

            //mostramos la info 
            Console.WriteLine("El mes es: {0}, con valor de: {1}", miMes, numero);

            //crear variable tipo color 
            color miColor = color.Negro;

            //pasamos el valor a un numero 
            numero = (int)miColor;

            //mostramos la info 
            Console.WriteLine("El color es: {0}, con valor de: {1}", miColor, numero);

        }
    }
}
