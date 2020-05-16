using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;


namespace Valoraciones
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear el Objeto Libro
            LibroValoraciones Libro = new LibroValoraciones();
            Libro.Idioma = IdiomaLibro.ES;
            Libro.Nombre = "El libro de valoraciones Ernest:";
            Libro.Nombre = null;
            Console.WriteLine(Libro.Nombre);
            SpeechSynthesizer hablar = new SpeechSynthesizer();
            
            Vector3D miVector;

            //Asignar Propiedades
            miVector.x = 10;
            miVector.y = 20;
            miVector.z = 30.30f;

            //Asignar Valoraciones
            Libro.AgregarValoracion(5);
            Libro.AgregarValoracion(4);
            Libro.AgregarValoracion(3);
            Libro.AgregarValoracion(0.5f);
            Libro.AgregarValoracion(1);
            Libro.AgregarValoracion(3.5f);

            //publicar Valoraciones

            hablar.Speak("Este es el promedio de las valoraciones");
            CalcularValoraciones publicar =  Libro.PublicarValoraciones();
            float valoracionMax = publicar.ValoracionMax;
            float valoracionMin = publicar.ValoracionMin;
            float PromedioValoraciones = publicar.PromedioValoraciones;


            EscribirValoraciones("promedio de valoracion es: ", PromedioValoraciones);
            EscribirValoraciones("valoracon maxima es: ",valoracionMax);
            EscribirValoraciones("valoracon minima es: " ,(int)valoracionMin);
            EscribirValoraciones("La letra de tu valoracion es: " + Libro.ValoracionesLetras);
            Console.Beep();
            Console.ReadLine();
           
        }
        private static void EscribirValoraciones(string descripcion)
        {
            Console.WriteLine("{0}" , descripcion);
        }
        private static void EscribirValoraciones(string descripcion,float valoracion)
        {
            Console.WriteLine("{0}"+"{1}",descripcion,valoracion);
        }
        private static void EscribirValoraciones(string descripcion, int valoracion)
        {
            Console.WriteLine("{0}" + "{1}", descripcion, valoracion);
        }
    }
}
