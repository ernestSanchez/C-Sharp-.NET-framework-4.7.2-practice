using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enumeraciones
{
    class Program
    {
        //declarar enumeracion 
        //enum nombre {valor1,valor2, ...valor}; <--- sintax
        enum semana {Lunes,Martes,Miercoles,Jueves,Viernes,Sabado,Domingo};

    //enum semana { Lunes = 5, Martes, Miercoles, Jueves, Viernes, Sabado, Domingo };//<-- para iniciar la numeracion como quiera 

        static void Main(string[] args)
        {
            //declaramos la variable
            semana elDia;

            //le asignamos valor 
            elDia = semana.Sabado;

            //metodo toString()
            String mensaje = "El dia es ";
            mensaje = mensaje + elDia.ToString();
            Console.WriteLine(mensaje);

            //metodo tipo dato 
            Console.WriteLine("eL dia es: {0}", elDia);

            //metodo numerico asignar numero 
            int valor = 0;
            valor = (int)elDia;
            Console.WriteLine(valor);

            //experesion arigmetica 
            int salario = 0;
            int pagoDia = 200;

            salario = pagoDia * ((int)elDia);

            if(elDia == semana.Viernes)
            {
                .....
            }

        }
    }
}
