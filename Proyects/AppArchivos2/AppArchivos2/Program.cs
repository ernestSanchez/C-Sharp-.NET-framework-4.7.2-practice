using System;
using System.Collections.Generic;
using System.IO;//<----Streams
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AppArchivos2
{
    class Program
    {
        static void Main(string[] args)
        {
            //ARREGLO DE BYTES
            byte[] recibeInformacion = new byte[100];

            string nombreArchivo = "";

            Console.Write("escribe el nombre del archivo a abrir: ");
            nombreArchivo = Console.ReadLine();

            //creacion del stream para lectura
            FileStream fs = new FileStream(nombreArchivo + ".txt", FileMode.Open);

            //leer contenido del archivo
            fs.Read(recibeInformacion, 0, (int)fs.Length);

            //mostrar contenido la info leida
            Console.WriteLine(ASCIIEncoding.ASCII.GetString(recibeInformacion));

            //CERRAMOS EL stream
            fs.Close();



        }
    }
}
