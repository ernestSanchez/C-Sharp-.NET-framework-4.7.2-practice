
// C# :

// frameWork.NET

//tipos de archivos .exe .dll assemblys contiene grupos de clases 
//.dll es el que contiene las librerias 

// ESTA DIVIDIDO EN DOS PCOMPONENTES (CLR) Y (FCLR)

// -(CLR) Comom Language Runtime
// Es un mini software para interpretar,se ejecuts cuando le dampos a un app o aplicacion 
//maquina virtual que ejecuta nuestra app 

//(FCL) framework Class Library 
//es un conjunto de librarias para desarrollar nuestras aplicaciones provee de las herramientas

//las funciones en Microsoft se llaman  metodos.

// identificadores = variables siempre tienen que empezar con un guion bajo

// gerarquia de operadores 
    //1- ()
    //2- * , /, %
    // %                    <---- llamado resto o Modulo  da el residuo de la division
    //3- +,-

// palabras clave o Keyword

// ejemplo int 

// https://docs.microsoft.com/es-mx/dotnet/csharp/language-reference/keywords/




////////////////////////////// CLASES //////////////////////////////////////////////////

// clases : creamos classes para abstraer diferentes entidades,nombres,objetos o sustantivos en los que podemos mediante es abstraccion definir estados y comportamientos 
    // ej : Persona ,Coche , Idea , Juan ,Sueño...

                        // cada clase tiene 2 mienbros estados y comportamientos 
                        // eje:  clase Coche 
                        //         estado: <---- COMPONENTES 
                        //         -puertas
                        //         -ruedas
                        //         -tipoMotor
                        //         Comportamientos: <------- ACCCIONES VERBOS 
                        //         -Enceder Coche
                        //         -Apagar Coche
                        //         -Tocar Claxon 




//importar librerias  eje: using System;

// using System; ---> importar libreria

// public class program <-- classe  
// {
// 	static void Main() <--- funcion 
// 	{
// 		Console.WriteLine("Hola Mundo");		 <----console log de cmd 
// 	}
// }

//compilar eje:
//c:\Windows\Microsoft.NET\Framework\v4.0.30319\csc HolaMundo.cs

//para ver fecha

// using System;

// public class program <----clase 
// {
// 	static void Main()
// 	{
// 		Console.WriteLine(DateTime.Now.DayOfWeek);		
// 	}
// }

//// visual studio 

//short cut ctrl+f5 (start Widout debugging)

///////////////////////////////////// pasar dar argumentos por consola 

// using System;

// namespace Saludo
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.WriteLine("Hola " + args[0] + " " + args[1]);
//         }
//     }
// }

///////////////////////////////////// inputs i outputs 


// using System;


// namespace edadLegal
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.WriteLine("Escriba su nombre y pulse enter:");
//             string name = Console.ReadLine();   // <--------------------- input user readline 
//             Console.WriteLine("Escriba su edad y pulse enter:");
//             int edad = int.Parse(Console.ReadLine()); //<--------------- int es para numeros int de integrer(integros) Parse funcion para parsear a numero
//             if (edad >= 18)
//             {
//                 Console.WriteLine("tu nombre es " + name + " y legalmente eres mayor de edad");
//             }
//             else 
//             {
//                 Console.WriteLine("tu nombre es " + name + " y legalmente NO eres mayor de edad");  

//             }
//         }
//     }
// }



//////////////////////// reference type 

// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;

// namespace Valoraciones
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             LibroValoraciones Libro = new LibroValoraciones(); //<--- creamos objeto con new para llamar al constructor una nueva instancia
//             Libro.AgregarValoracion(3.5f);
//             Libro.AgregarValoracion(5);

//             LibroValoraciones Libro2 = Libro; //<---- reference type referenciando libro2 con libro
//             Libro2.AgregarValoracion(2);
          

//         }
//     }
// }


// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;

// namespace Valoraciones
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.WriteLine(LibroValoraciones.nombre); //<------no es estancia por que el librovaloraciones le puse static y puedo tranbajar sin crear objeto 
//             LibroValoraciones Libro = new LibroValoraciones(); //<--- creamos objeto con new para llamar al constructor una nueva instancia
//             Libro.AgregarValoracion(3.5f);
//             Libro.AgregarValoracion(5);

//             LibroValoraciones Libro2 = Libro; //<---- reference type referenciando libro2 con libro
//             Libro2.AgregarValoracion(2);

//         }
//     }
// }


////// testing (testeo) 
     ///test unitarios 
     //add new testprojectUnit

/////////////////////////////tipos de variables c#

//- variable de valor 


//- variable de referencia 


////////////////////////// CURSO 2 //////////////////////

// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;

// namespace Seccion2
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             //Console.WriteLine("1. Precalentar el horno");
//             //Console.WriteLine("2. Mezclar harina y mantequilla");
//             //Console.WriteLine("3. Agregar azucar y huevo");
//             //Console.WriteLine("4. Amasar mezcla");
//             //Console.WriteLine("5. Darles forma y colocar charola");
//             //Console.WriteLine("6. Hornear durante 10 minutos");

//             ///*Declarando 3 variables de tipo entero 
//             // * numeroLibros,librosNiños,librosMatematicas
//             // * y les asigno un valor de 500, 100, 200 */
//             //int numeroLibros = 500, librosNiños = 100, librosMatematicas = 200;

//             ////Declarando 3 variables de tipo double y asigno valor 
//             //double promedioFinal = 9.8;

//             //numeroLibros = 500; // asigno el valor de 500 a la variable "numeroLibros"

//             //char salon;
//             //salon = 'A';

//             //string saludo = "Hola";

//             //bool x = false;

//             //float promedioExamenes = 8.5f;

//             string nombre;

//             //preguntamos nombre usuario
//             Console.Write("Como te llamas?: "); //<---- no da salto de linea siempre va seguido en vez de abajo
//             nombre = Console.ReadLine();   //<------ asignamos la info que el user escribe en la consola

//             //Saludamos Usuario 
//             Console.WriteLine("Hola {0},un placer", nombre); // {0} en lista ponemos la variable que tenemos luego en este caso nombre
//         }
//     }
// }

///////////////////////// conversiones ////////////////////

string entrada;
int num1 = 5, num2, resultado;

// preguntamos al usuario el numero
Console.Write("Dame un numero para sumarlo: ");
// se asignma a la vsariable de tipo string "entrada"
entrada = Console.ReadLine();

//convertimos la cadena a tipo int
num2 = Convert.ToInt32(entrada); //<--- conversion como el parse +
num2 = Int32.Parse(entrada);  //<----- otra forma de hacerlo

resultado = num1 + num2;

//mostramos resultado 
Console.WriteLine("El resultado de la suma es: {0}", resultado);
 
 /// diagramas de flujo metologia de trabajo /////

 //Realizar un programa de computadora que haga el calculo 
            // del area y perimetro de un rectangulo

            //Variables:

            double altura, ancho, area, perimetro;

            //Pedimos la altura y convertimos a tipo double 
            Console.Write("Dame la altura: ");
            altura = Convert.ToDouble(Console.ReadLine());

            //Pedimos el ancho  y convertimos a tipo double 
            Console.Write("Dame el ancho: ");
            ancho = Convert.ToDouble(Console.ReadLine());

            //calculamos el area
            area = altura * ancho;

            //calculamos el perimtro 
            perimetro = 2 * (altura + ancho);

            //Mostramos resultados pantalla
            Console.WriteLine("El area es: {0}", area);
            Console.WriteLine("El perimetro es: {0}", perimetro);
 