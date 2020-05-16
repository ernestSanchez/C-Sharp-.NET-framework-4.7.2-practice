using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testFunctions
{
    class Program
    {
  
        
        static void Main(string[] args)
        {
            //variables necesarias
            int opcion = 0;
            string valor = "";
            //mostrar menu 
            Console.WriteLine("1 - Suma");
            Console.WriteLine("2 - Resta");
            Console.WriteLine("3 - Multiplicacion");
            Console.WriteLine("4 - Division");

            //PEDIMOS LA OPCION
            Console.Write("escoge una opcion: ");
            valor = Console.ReadLine();
            opcion = Convert.ToInt32(valor);

            //verificacion para la suma 
            if(opcion == 1)
            {
                Suma();
            }
            //verificacion para la resta 
            if (opcion == 2)
            {
                //variable para el resultado
                float resultado = 0;

                //invocamos y obtenemos el resultado
                resultado = Resta();

                //mostramos el resultado 
                Console.WriteLine("El resultado de la resta es: {0}", resultado);

            }
            //verificacion para la multiplicacion 
            if (opcion == 3)
            {
                //variables necesarias
                float n1 = 0;
                float n2 = 0;
                string numero = "";

                //pedimos los valores
                n1 = PedirFlotante("Dame el primer numero: ");
                n2 = PedirFlotante("Dame el segundo numero: ");
               
                //invocamos a la funcion 
                Multiplicacion(n1,n2);
            }
            //verificacion para la division 
            if (opcion == 4)
            {
                //variables 
                float n1 = 0.0f;
                float n2 = 0.0f;
                float resultado = 0.0f;
                string numero = "";

                //pedimos valoes
                n1 = PedirFlotante("Dame el primer numero: ");
                n2 = PedirFlotante("Dame el segundo numero: ");

                //invocamos funcion 
                resultado = Division(n1,n2);

                //mostramos resultado 
                Console.WriteLine("El resultado es: {0}", resultado);
            }

        }//Cierre Main
         
        //Funcion que ejecuta codigo
        static void Suma ()
        {
            //Funcion que ejecuta codigo

            //Variables necesarias
            float a = 0;
            float b = 0;
            float r = 0;
            string numero = "";

            //pedimos los valores 
            Console.Write("dame el primer numero: ");
            numero = Console.ReadLine();
            a = Convert.ToSingle(numero);

            Console.Write("dame el segundo numero: ");
            numero = Console.ReadLine();
            b = Convert.ToSingle(numero);

            //calcular 

            r = a + b;

            Console.WriteLine("el resultado de {0} + {1} = {2}", a, b, r);
        }
        
        //Funcion que regresa un valor
        static float Resta()
        {
            //Funcion que regresa un valor

            //variables
            float a = 0;
            float b = 0;
            float r = 0;
            string numero = "";

            //pedimos los valores 
            Console.Write("dame el primer numero: ");
            numero = Console.ReadLine();
            a = Convert.ToSingle(numero);

            Console.Write("dame el segundo numero: ");
            numero = Console.ReadLine();
            b = Convert.ToSingle(numero);

            //calcular result
            r = a - b;

            //regresamos el resultado
            return r;
        } 

        //funcion que recibe valores
        static void Multiplicacion (float a,float b)
        {
            //funciones que reciben valores
            
            // en este caso viene del caso 3 del if

            //variables necesarias
            float r;

            //clacular el valor 

            r = a * b;

            //mostramos el resultado 
            Console.WriteLine("el resultado es: {0}", r);
        }

        //funcion que recibe parametros y regresa un valor
        static float Division (float a,float b)
        {
            //funcion que recibe parametros y regresa un valor

            //variables 
            float r = 0;

            //Verificamos para la division entre 0
            if (b == 0)
            {
                Console.WriteLine("no es posible dividir entre 0");
                return  0.0f;
            }
            else
            {
                r = a / b;
                return r;
            }
        }

        static float PedirFlotante(string mensaje)
        {
            //variables que necesitamos 
            float numero = 0.0f;
            string valor = "";

            //mostramos mensaje 
            Console.Write(mensaje);

            //obtenemos el valor 
            valor = Console.ReadLine();
            numero = Convert.ToSingle(valor);

            //REGRESAMOS EL DATO 
            return numero;

        }
    }
}
