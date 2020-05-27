using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; //Streams
namespace AppArchivos
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombreArchivo = "";
            string cadena = "";

            //pedimos al usuario el nombre del archivo 
            Console.Write("Dame el nombre para el archivo: ");
            nombreArchivo = Console.ReadLine();

            //creacion archivo 
            FileStream fs = new FileStream(nombreArchivo+".txt", FileMode.Create);

            //pedimos lo que el usuario quiera poner en el interior del archivo 
            Console.WriteLine("Escribe la informacion que tendra el archivo: ");

            do
            {
               

                //estamos leyendo la cadena
                cadena = Console.ReadLine();

                //escribimos al stream la cadena
                fs.Write(ASCIIEncoding.ASCII.GetBytes(cadena), 0, cadena.Length);

            } while (cadena != "");


            //CERRAR EL ARCHIVO
            fs.Close();

          
        }
    }
}
