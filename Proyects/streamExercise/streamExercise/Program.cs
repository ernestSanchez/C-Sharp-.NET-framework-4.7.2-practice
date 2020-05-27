using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace streamExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //creamos el Stream 
            MemoryStream ms = new MemoryStream(70);

            //cadena para Stram 
            String cadenaStream = "";

            //variables restantes 
            int capacidad = 0;
            long longitud = 0;
            long posicion = 0;

            //arreglo bytes 
            byte[] buffer = new byte[70];

            //peticion de la cadena al usuario 
            Console.Write("dame la cadena para usar en el flujo: ");
            cadenaStream = Console.ReadLine();

            ms.Write(ASCIIEncoding.ASCII.GetBytes(cadenaStream), 0, cadenaStream.Length);

            capacidad = ms.Capacity;
            longitud = ms.Length;
            posicion = ms.Position;

            //mostramos info 

            Console.WriteLine("capacidad: {0}, longitud: {1}, posicion: {2}", capacidad, longitud, posicion);

            //ms.Seek(0, SeekOrigin.Begin); //<-------nos estamos colocando a 0 distancia del inicio  

            //ms.Read(buffer, 0, 7); //<------desde la posicion donde nos encontramos leemos 7 bytes

            ////mostramos info 
            //Console.WriteLine(ASCIIEncoding.ASCII.GetString(buffer));

            //ms.Seek(5, SeekOrigin.Begin); //<----- nos estamos colocando a 5 distancia del inicio 
            //ms.Read(buffer, 0, 6);
            ////mostramos info 
            //Console.WriteLine(ASCIIEncoding.ASCII.GetString(buffer));

            ms.Seek(-17, SeekOrigin.End);
            ms.Read(buffer, 0, 8);
            ////mostramos info 
            Console.WriteLine(ASCIIEncoding.ASCII.GetString(buffer));

            //Estamos cerrando el flujo 
            ms.Close();
        }
    }
}
