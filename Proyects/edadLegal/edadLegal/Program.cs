using System;


namespace edadLegal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escriba su nombre y pulse enter:");
            string name = Console.ReadLine();   // <--------------------- input user readline 
            Console.WriteLine("Escriba su edad y pulse enter:");
            int edad = int.Parse(Console.ReadLine()); //<--------------- int es para numeros int de integrer(integros) Parse funcion para parsear a numero
            if (edad >= 18)
            {
                Console.WriteLine("tu nombre es " + name + " y legalmente eres mayor de edad");
            }
            else 
            {
                Console.WriteLine("tu nombre es " + name + " y legalmente NO eres mayor de edad");  

            }
        }
    }
}
