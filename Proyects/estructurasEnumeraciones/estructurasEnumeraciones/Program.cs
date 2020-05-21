using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace estructurasEnumeraciones
{
    class Program
    {
        static void Main(string[] args)
        {
            //estructuras es un conjunto de datos agrupados

            //definir una estructura
            //    acceso struct nombre
            //{
            //    acceso tipo campo1;

            //            acceso tipo campo2;    

            //            ...

            //                public //para  acceder a la estructura desde el exterior fuera del ambito 

            //                private //para no poder acceder desde el exterior a la extructura
            //}

            //---------------------------------------------------------------------------------------------------//

            //Agenda amigo;

            //Agenda amigo1, amigo2, amigo3;

            //Agenda[] amigos = new Agenda[15];
            //Agenda[] clientes = new Agenda[3];

            //Para acceder a la estructura
            //VariableEstructura.Campo

            //amigo.Edad = 25;



            // Console.WriteLine(amigo.ToString());

            //---------------------------------------------------------------------------------------------------//

            //Agenda[] amigos = new Agenda[5];

            //amigos[1].Edad = 25;
            //amigos[1].Nombre = "Pedro";
            //amigos[1].Telefono = "5845987214";

            //Console.WriteLine(amigos[1].ToString());

            //---------------------------------------------------------------------------------------------------//

            //para asignar campos al constructor

            Agenda amigo = new Agenda("Pedro", 30, "1844579749", "pl.Catalunya", 32); //<--- insatanciamos con un new 

            Console.WriteLine(amigo.ToString());

            Agenda prueba = new Agenda("Juan", 25, "12385649" , "Bailen" , 28);
            Console.WriteLine(prueba.ToString());

            Agenda prueba2 = new Agenda("Marco", 29);
            Console.WriteLine(prueba2.ToString());

            Agenda prueba3 = new Agenda("Hector");
            Console.WriteLine(prueba3.ToString());

        }//cierre Main

        //estructuras es un conjunto de datos agrupados
        public struct Agenda
        {
            public String Nombre;
            public int Edad;
            public String Telefono;
            public Direccion Domicilio; //<---- declaramos la estructura Direccion y le damos un nombre

            public override string ToString()
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("Nombre: {0} ,Edad: {1} ,Telefono: {2}",Nombre,Edad,Telefono);
          
                //agrgando la cadena proviniente de domicilio
                sb.Append(Domicilio.ToString());
                return (sb.ToString());
            }

            //constructor 1
            // se inicializa al llamar la estructura y sirve para asignar valores 
            public Agenda (String pNombre, int pEdad, String pTelefono, String pCalle, int pNumero)//<-- asignamos calle y numero los datos de la  estructura direccion
            {
                //llevamos  a cabo la asignacion 
                Nombre = pNombre;
                Edad = pEdad;

                if (pTelefono.Length == 10)//<--- verificacion antes de asignar en la variable
                {
                    Telefono = pTelefono;
                }
                else
                {
                    Telefono = "El telf no es valido";
                }
                //instanciamos domicilio por medio del new con los datos que le corresponden
                Domicilio = new Direccion(pCalle, pNumero);

            }

            //constructor 2
            public Agenda(String pNombre, int pEdad)
            {
                //Llevamos a cabo la asignacion
                Nombre = pNombre;
                Edad = pEdad;

                Telefono = "Sin telefono";
                Domicilio = new Direccion("Sin direccion", 0);// le ponemos 0 por que como minimo nos pide un parametro para el default
            }

            //constructor 3
            public Agenda (String pNombre)//<-- pedimos el valor del nombre lo demas lo pedimos dentro del constructor
            {
                //Llevamos a cabo la asignacion del nombre 
                Nombre = pNombre;

                //Pedimos Edad 
                Console.Write("dame la edad: ");
                Edad = Convert.ToInt32(Console.ReadLine());

                //Pedimos el telf
                Console.Write("dame el tlf: ");
                Telefono = Console.ReadLine();

                if(Telefono.Length != 10)
                {
                    Telefono = "tlf no valido";
                }

                Domicilio = new Direccion("Sin direccion", 0);// le ponemos 0 por que como minimo nos pide un parametro para el default

            }
        }

        //estructura2
        public struct Direccion
        {
            public String Calle;
            public int Numero;

            //constructor
            public Direccion(String pCalle, int pNumero)
            {
                //asignacion a las variables de la structura 
                Calle = pCalle;
                Numero = pNumero;
             }

            public override string ToString()
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat(" Direccion: {0} #{1}", Calle, Numero);
                return (sb.ToString());
            }
        }

    }
}
