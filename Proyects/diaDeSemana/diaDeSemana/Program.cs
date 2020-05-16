using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diaDeSemana
{
    class Program
    {
        static void Main(string[] args)
        {
            string valor = "";
            int opcion = 0;
            string resultado = "";

            // pedir al usuario un numero del 1 al 7 
            Console.Write("Escribe un numero del 1 al 7: ");
            valor = Console.ReadLine();
            opcion = Convert.ToInt32(valor);
            
            // switch seleccion usuario
            
            switch (opcion)
            {
                case 1:
                    resultado = "Lunes";
                    break;
                case 2:
                    resultado = "Martes";
                    break;
                case 3:
                    resultado = "Miercoles";
                    break;
                case 4:
                    resultado = "Jueves";
                    break;
                case 5:
                    resultado = "Viernes";
                    break;
                case 6:
                    resultado = "Sabado";
                    break;
                case 7:
                    resultado = "Domingo";
                    break;
                default:
                    Console.WriteLine("superas el rango solicitado");
                    break;
            }


            // responder con el nombre del dia de la semana 
            if (( opcion <= 0) || ( opcion > 7 ))
            {
                Console.WriteLine("Vuelve a intentarlo");
            }
            else
            {
                Console.WriteLine("El dia de la semana es: {0}", resultado);
            }
            


        }
    }
}
