using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //instaciamos a la clase cubo
            cubo miCubo = new cubo();//<--new crea la insatancia
            cubo miCubo2 = new cubo();

            //instaciamos a la clase Prisma
            prisma miPrisma = new prisma();

            //instaciamos a la clase Prisma la version sobrecargada
            prisma miprisma2 = new prisma(4, 3, 9);

            //asignamos el valor de lado 
            miCubo.lado = 5;
            miCubo2.lado = 7;

            //invocamos metodos
            miCubo.ClacularArea();
            miCubo.CalcularVolumen();
            miCubo2.ClacularArea();
            miCubo2.CalcularVolumen();

            //miPrisma.Ancho = 7;

            //invocar metodos del prisma 
            miPrisma.CalcularArea();
            miPrisma.CalculaVolumen();

            miprisma2.CalcularArea();
            miprisma2.CalculaVolumen();

            //imprimir datos 
            Console.WriteLine("Area={0}, Volumen={1}", miCubo.area, miCubo.volumen);
            Console.WriteLine("Area={0}, Volumen={1}", miCubo2.area, miCubo2.volumen);

            Console.WriteLine(miPrisma.ToString());

            miPrisma.ImprimirResultado();

            Console.WriteLine(miprisma2.ToString());
        }
    }
    class cubo
    {
        //declaramos los datos 
        public int lado;
        public int area;
        public int volumen;

        //metodo para calcular el area
        public void ClacularArea()
        {
            area = (lado * lado) * 6;
        }
        //metodo para calcular el volumen
        public void CalcularVolumen()
        {
            volumen = lado * lado * lado;
        }
    }

    class prisma
    {
        //declaramos los datos 
        private int ancho;
        private int alto;
        private int espesor;
        private int area;
        private int volumen;

        //definiendo las propiedades
        public int Ancho
        {
            get
            {
                return ancho;
            }
            set
            {
                if (value <= 0)
                {
                    ancho = 1;
                }
                else
                {
                    ancho = value;
                }
                   

            }
        }
        public int Alto
        {
            get
            {
                return alto;
            }
            set
            {
                if (value <= 0)
                {
                    alto = 1;
                }
                else
                {
                    alto = value;
                }

            }
        }
        public int Espesor
        {
            get
            {
                return espesor;
            }
            set
            {
                if (value <= 0)
                {
                    espesor = 1;
                }
                else
                {
                    espesor = value;
                }

            }
        }
        public int Area
        {
            get
            {
                return area;
            }
        }
        public int Volumen
        {
            get
            {
                return volumen;

            }
        }
        //definimos los metodos 
        
        //definiendo los costructores se encarga de pedir los datos 
        public prisma()
        {
            //Datos necesarios 
            String valor = "";

            //pedimos los datos
            Console.Write("dame el ancho: ");
            valor = Console.ReadLine();
            ancho = Convert.ToInt32(valor);

            Console.Write("dame el alto: ");
            valor = Console.ReadLine();
            alto = Convert.ToInt32(valor);

            Console.Write("dame el espesor: ");
            valor = Console.ReadLine();
            espesor = Convert.ToInt32(valor);

        }
        //version sobrecargada
        public prisma(int zAncho,int zAlto,int zEspesor)
        {
            //asignamos los valores 

            ancho = zAncho;
            alto = zAlto;
            espesor = zEspesor;
        }

        public void CalculaVolumen()
        {
            volumen = ancho * alto * espesor;
        }

        public void CalcularArea()
        {
            int a1 = 0, a2 = 0, a3 = 0;

            a1 = 2 * CalculaRectangulo(ancho, alto);
            a2 = 2 * CalculaRectangulo(ancho, espesor);
            a3 = 2 * CalculaRectangulo(alto, espesor);

            area = a1 + a2 + a3;
        }

        private int CalculaRectangulo(int a, int b)
        {
            return (a * b);
        }

        public override string ToString()
        {
            String mensaje = "";
            mensaje += "Ancho = " + ancho.ToString() + " Alto = " + alto.ToString() + " Espesor = " + espesor.ToString()+
                " Area = " + area.ToString()
                + espesor.ToString() + " Volumen = " + volumen.ToString();

            return mensaje;
        }

        public void ImprimirResultado()
        {
            Console.WriteLine("El area es: {0}, el volumen es: {1}", area, volumen);

        }
    }

}
